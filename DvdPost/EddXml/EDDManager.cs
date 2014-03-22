using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EddXml
{
    public enum EDDMANDATESTATUS { MANADATESIGNED_WAITINGONBANKINITIATION = 2, SENTTOBANKFORINITIATION = 3, INITIATEDATBANK = 4, STOPPED = 5 };
    
    public class EDDManager
    {        
        public const string CREDITOR_HES_IBAN = "BE93310191369467";    

        Document _eddXML = new Document();
        int _pmtTrnxCounter;
        int _pmtInfCounter = 0;
        List<PaymentInstructionInformation4> _pmtInfCreditor;
        Dictionary<string, int> eddMandateStatusCounter = new Dictionary<string, int>();

        public EDDManager()
        {
            _eddXML.CstmrDrctDbtInitn = new CustomerDirectDebitInitiationV02();
            _pmtInfCreditor = new List<PaymentInstructionInformation4>();
            
        }

        public string CreateEDDXMLFileManager(DataTable dtReconduction, string messageID)
        {

            //TODO: 1. instancirati clsEDD
            //2. popuniti header
            //3. u petlji puniti 
            //Dim totalDomId As Integer = 0
            //Dim numberOfRefund As Integer = 0
            //Dim totalRefundAmount As Decimal = 0
            //Dim totalFundId As Integer = 0
            //Dim strcommunication As String
            //Dim cpt As Integer = 0
            //Dim sql As String
            //Dim lastDomId As Integer

            //Header(_eddXML, dtReconduction.Rows.Count, messageID);
            //sql = DvdPostData.ClsPayment.getIdLastPayment()
            //lastDomId = DvdPostData.clsConnection.ExecuteScalar(sql)
            //RaiseEvent initMapping_Event(dtReconduction.Rows.Count)

            foreach (DataRow dr in dtReconduction.Rows)
            {
                //cpt = cpt + 1
                //strcommunication = clsCompta.CreateCommunicationStruct(lastDomId + cpt, ClsCustomersData.TypePaymentCommunication.DOMICILIATION)
                //If ClsBatchDomiciliation.InsertDomiciliationPayment(dr, strcommunication, lastDomId + cpt) Then
                //    strMsg = strMsg + LineData(dr, cpt, strcommunication)
                //    lastDomId = DvdPostData.clsConnection.ExecuteScalar(sql)
                //    RaiseEvent stepMapping_event(cpt)
                //Else
                //    cpt -= 1
                //End If

            }
            return _eddXML.ToString();

        }

        public string Header(int numberOfTransactions, string messageID, decimal ctrlSUM )
        {
            DateTime mesDT = DateTime.Now;            
            _eddXML.CstmrDrctDbtInitn.GrpHdr = new GroupHeader39(); 
            _eddXML.CstmrDrctDbtInitn.GrpHdr.MsgId = messageID;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.CreDtTm = mesDT;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.CtrlSumSpecified = true;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.CtrlSum = ctrlSUM;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.NbOfTxs = numberOfTransactions.ToString();
            
            Party6Choice orgid = new Party6Choice();
            OrganisationIdentification4 OrgId = new OrganisationIdentification4();
            GenericOrganisationIdentification1[] goi = new GenericOrganisationIdentification1[1];
            goi[0] = new GenericOrganisationIdentification1();
            goi[0].Id = "0478510502";
            goi[0].Issr = "KBO-BCE";
            OrgId.Othr = goi;
            orgid.Item = OrgId; 
            _eddXML.CstmrDrctDbtInitn.GrpHdr.InitgPty = new PartyIdentification32();
            _eddXML.CstmrDrctDbtInitn.GrpHdr.InitgPty.Id = orgid;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.InitgPty.Nm = "Home Entertainment Services SA";

            return mesDT.ToString("yyyyMMddThhmmss"); 

        }

        public void paymentInfoCreditor(string pmtInfId, int numberOfTransactions, decimal ctrlSUM, SequenceType1Code action)
        {
            //_eddXML.CstmrDrctDbtInitn.PmtInf = new PaymentInstructionInformation4[1];
            //_eddXML.CstmrDrctDbtInitn.PmtInf[0] = new PaymentInstructionInformation4(); 
            DateTime requestCollectionDate = DateTime.Now; 
            _pmtTrnxCounter = 0;

            int actionIndex = 0;
            //
            if (numberOfTransactions == 0)
            {
                return;
            }
            //
            switch (action)
            {
                case SequenceType1Code.FRST: {actionIndex = 0 ; requestCollectionDate = requestCollectionDate.AddDays(6);  break;}
                case SequenceType1Code.RCUR: actionIndex = 1; requestCollectionDate = requestCollectionDate.AddDays(3); break;
                case SequenceType1Code.FNAL: actionIndex = 3; requestCollectionDate = requestCollectionDate.AddDays(3); break;
            }
            eddMandateStatusCounter.Add(action.ToString(), _pmtInfCounter);             
            //
            //pmtInfCreditor[actionIndex] = new PaymentInstructionInformation4();
            PaymentInstructionInformation4 pmtInfCreditor = new PaymentInstructionInformation4();
            pmtInfCreditor.PmtInfId = pmtInfId;
            pmtInfCreditor.PmtMtd = PaymentMethod2Code.DD;
            pmtInfCreditor.BtchBookg = true;
            pmtInfCreditor.NbOfTxs = numberOfTransactions.ToString();
            pmtInfCreditor.CtrlSum = ctrlSUM;
            pmtInfCreditor.CtrlSumSpecified = true;
            //
            PaymentTypeInformation20 pmtTypeInfo20 = new PaymentTypeInformation20();
            ServiceLevel8Choice serviceLevel8Choice = new ServiceLevel8Choice();
            serviceLevel8Choice.Item = "SEPA";
            serviceLevel8Choice.ItemElementName = ItemChoiceType4.Cd;
            pmtTypeInfo20.SvcLvl = serviceLevel8Choice;
            LocalInstrument2Choice localInstrument2Choice = new LocalInstrument2Choice();
            localInstrument2Choice.Item = "CORE";
            localInstrument2Choice.ItemElementName = ItemChoiceType5.Cd;            
            pmtInfCreditor.PmtTpInf = new PaymentTypeInformation20();
            pmtInfCreditor.PmtTpInf.SvcLvl = serviceLevel8Choice;
            pmtInfCreditor.PmtTpInf.LclInstrm = localInstrument2Choice;
            pmtInfCreditor.PmtTpInf.SeqTp = action;
            pmtInfCreditor.PmtTpInf.SeqTpSpecified = true;
            //
            pmtInfCreditor.ReqdColltnDt = requestCollectionDate ;
            //
            pmtInfCreditor.Cdtr = new PartyIdentification32();
            pmtInfCreditor.Cdtr.Nm = "DVDPost - Home Entertainment Services";
            pmtInfCreditor.Cdtr.PstlAdr = new PostalAddress6();
            pmtInfCreditor.Cdtr.PstlAdr.Ctry = "BE";
            string[] adrLine = new string[2];
            adrLine[0] = "Rue Des Veterinaires 42A";
            adrLine[1] = "1070 Anderlecht, Bruxelles";
            pmtInfCreditor.Cdtr.PstlAdr.AdrLine = adrLine;
            //
            AccountIdentification4Choice accountIdentification4Choice = new AccountIdentification4Choice();
            accountIdentification4Choice.Item = CREDITOR_HES_IBAN; //"BE68539007547034";
            pmtInfCreditor.CdtrAcct = new CashAccount16();
            pmtInfCreditor.CdtrAcct.Id = accountIdentification4Choice;
            //
            pmtInfCreditor.CdtrAgt = new BranchAndFinancialInstitutionIdentification4();
            pmtInfCreditor.CdtrAgt.FinInstnId = new FinancialInstitutionIdentification7(); 
            pmtInfCreditor.CdtrAgt.FinInstnId.BIC = "BBRUBEBB";
            //
            pmtInfCreditor.ChrgBr = ChargeBearerType1Code.SLEV;
            //
            Party6Choice party6Choice = new Party6Choice();

            //OrganisationIdentification4 organisationIdentification4 = new OrganisationIdentification4();
            //organisationIdentification4.BICOrBEI = "BE65ZZZ0478510502";
            //party6Choice.Item = organisationIdentification4;
            PersonIdentification5 personIdentification5 = new PersonIdentification5();
  
            GenericPersonIdentification1 genericPersonIdentification1 = new GenericPersonIdentification1();
            genericPersonIdentification1.Id = "BE65ZZZ0478510502";
            genericPersonIdentification1.SchmeNm = new PersonIdentificationSchemeName1Choice();
            genericPersonIdentification1.SchmeNm.Item = "SEPA";

            personIdentification5.Othr = new GenericPersonIdentification1[1];
            personIdentification5.Othr[0] = genericPersonIdentification1;
            party6Choice.Item = personIdentification5;

            pmtInfCreditor.CdtrSchmeId = new  PartyIdentification32();
            pmtInfCreditor.CdtrSchmeId.Id = party6Choice;

            _pmtInfCreditor.Add(pmtInfCreditor);  
            
            //ovo negde na kraju
            //_eddXML.CstmrDrctDbtInitn.PmtInf = new PaymentInstructionInformation4[]; 
            //_eddXML.CstmrDrctDbtInitn.PmtInf = _pmtInfCreditor.ToArray() ;            
            //_eddXML.CstmrDrctDbtInitn.PmtInf[eddMandateStatusCounter[action.ToString()]].DrctDbtTxInf = new DirectDebitTransactionInformation9[numberOfTransactions];
            _pmtInfCreditor[eddMandateStatusCounter[action.ToString()]].DrctDbtTxInf = new DirectDebitTransactionInformation9[numberOfTransactions];
            _pmtInfCounter++;
            //
        }

        public void CreatePayment(DataRow dr, string strcommunication, int lastDomId, string mndtId, string orgnlMndtId, string orgnlCdtrSchmeIdOthrID,
            string dbtrNm, string dbtrIBAN, string dbtrAgentBIC, string dbtrStreetAddress, string dbtrPostCodeAndCityAddress, SequenceType1Code action, 
            DateTime dateOfSignature , bool isMigration, bool ibanChanged, string oldIBAN, bool eddMandateIdChanged, string oldEddMandateId, bool bicChanged, string oldBIC)
        {
            bool isInitiation = (EddXml.SequenceType1Code.FRST == action);
            DateTime signatureDate;
            //if ( dateOfSignature = DBNull.Value)
            //{
            //    dateOfSignature = DateTime.MinValue;
            //}   
            if (isInitiation && isMigration )
            {
                signatureDate = DateTime.Now.AddDays(6);
            }
            else
            {
                signatureDate= dateOfSignature;
            }

            DirectDebitTransactionInformation9 payment = new DirectDebitTransactionInformation9();
            payment.PmtId = new PaymentIdentification1();
            payment.PmtId.InstrId = lastDomId.ToString();
            payment.PmtId.EndToEndId = strcommunication;
            //
            payment.InstdAmt = new ActiveOrHistoricCurrencyAndAmount();
            payment.InstdAmt.Ccy = "EUR";
            payment.InstdAmt.Value = getAmount(dr);
            //
            payment.DrctDbtTx = new DirectDebitTransaction6();
            payment.DrctDbtTx.MndtRltdInf = new MandateRelatedInformation6();
            payment.DrctDbtTx.MndtRltdInf.MndtId = mndtId;
            payment.DrctDbtTx.MndtRltdInf.DtOfSgntr = signatureDate;
            payment.DrctDbtTx.MndtRltdInf.DtOfSgntrSpecified = true;
            if (isInitiation )
            {
                if (isMigration)
                {
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInd = true;
                    payment.DrctDbtTx.MndtRltdInf.AmdmntIndSpecified = true;

                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls = new AmendmentInformationDetails6();
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlMndtId = (string)((isMigration ? "DOM80" : string.Empty) + orgnlMndtId);
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlCdtrSchmeId = new PartyIdentification32();
                    Party6Choice party6Chice = new Party6Choice();
                    /*
                    OrganisationIdentification4 organisationIdentification4 = new OrganisationIdentification4();
                    organisationIdentification4.Othr = new GenericOrganisationIdentification1[1];
                    organisationIdentification4.Othr[0] = new GenericOrganisationIdentification1();
                    organisationIdentification4.Othr[0].Id = (isMigration?"DOM80":string.Empty) & orgnlCdtrSchmeIdOthrID;
                    organisationIdentification4.Othr[0].SchmeNm = new OrganisationIdentificationSchemeName1Choice();
                    organisationIdentification4.Othr[0].SchmeNm.Item = "SEPA";
                    organisationIdentification4.Othr[0].SchmeNm.ItemElementName = ItemChoiceType.Prtry;
                    */
                    PersonIdentification5 personIdentification5 = new PersonIdentification5();
                    personIdentification5.Othr = new GenericPersonIdentification1[1];
                    personIdentification5.Othr[0] = new GenericPersonIdentification1();
                    personIdentification5.Othr[0].Id = (string)((isMigration ? "DOM80" : string.Empty) + orgnlCdtrSchmeIdOthrID);
                    personIdentification5.Othr[0].SchmeNm = new PersonIdentificationSchemeName1Choice();
                    personIdentification5.Othr[0].SchmeNm.Item = "SEPA";
                    personIdentification5.Othr[0].SchmeNm.ItemElementName = ItemChoiceType1.Prtry;
                    party6Chice.Item = personIdentification5;
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlCdtrSchmeId.Id = party6Chice;
                }
                if (bicChanged)
                {
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInd = true;
                    payment.DrctDbtTx.MndtRltdInf.AmdmntIndSpecified = true;
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls = new AmendmentInformationDetails6();
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAgt = new BranchAndFinancialInstitutionIdentification4();
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAgt.FinInstnId = new FinancialInstitutionIdentification7();
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAgt.FinInstnId.BIC = oldBIC;
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAgt.FinInstnId.Othr = new GenericFinancialIdentification1();
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAgt.FinInstnId.Othr.Id = "SMNDA";
                    if (ibanChanged || eddMandateIdChanged)
                    {                        
                        if (ibanChanged)
                        {
                            payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct = new CashAccount16();
                            payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct.Id = new AccountIdentification4Choice();
                            payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct.Id.Item = oldIBAN;
                            payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct.Nm = "IBAN";
                        }
                        if (eddMandateIdChanged)
                        {
                            payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlMndtId = (string)(orgnlMndtId);
                        }

                    }
                }
            }
            else if (ibanChanged || eddMandateIdChanged )
            {
                payment.DrctDbtTx.MndtRltdInf.AmdmntInd = true;
                payment.DrctDbtTx.MndtRltdInf.AmdmntIndSpecified = true;
                payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls = new AmendmentInformationDetails6();

                if (ibanChanged)
                {
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct = new CashAccount16();
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct.Id = new AccountIdentification4Choice();
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct.Id.Item = oldIBAN;
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlDbtrAcct.Nm = "IBAN";
                }
                if (eddMandateIdChanged)
                {
                    payment.DrctDbtTx.MndtRltdInf.AmdmntInfDtls.OrgnlMndtId = (string)(orgnlMndtId);
                }
               
            }
            else
            {
                payment.DrctDbtTx.MndtRltdInf.AmdmntInd = false;
                payment.DrctDbtTx.MndtRltdInf.AmdmntIndSpecified = false;
            }

            //
            payment.DbtrAgt = new BranchAndFinancialInstitutionIdentification4();
            payment.DbtrAgt.FinInstnId = new FinancialInstitutionIdentification7();
            payment.DbtrAgt.FinInstnId.BIC = dbtrAgentBIC;
            //
            payment.Dbtr = new PartyIdentification32(); 
            payment.Dbtr.Nm = dbtrNm;
            payment.Dbtr.PstlAdr = new PostalAddress6();
            payment.Dbtr.PstlAdr.Ctry = "BE";
            payment.Dbtr.PstlAdr.AdrLine = new string[2];
            payment.Dbtr.PstlAdr.AdrLine[0] = dbtrStreetAddress;
            payment.Dbtr.PstlAdr.AdrLine[1] = dbtrPostCodeAndCityAddress;
            //
            payment.DbtrAcct = new CashAccount16();
            payment.DbtrAcct.Ccy = "EUR";
            payment.DbtrAcct.Id = new AccountIdentification4Choice();
            payment.DbtrAcct.Id.Item = dbtrIBAN;
            //
            payment.RmtInf = new RemittanceInformation5();
            payment.RmtInf.Strd = new StructuredRemittanceInformation7[1];
            payment.RmtInf.Strd[0] = new StructuredRemittanceInformation7(); 
            payment.RmtInf.Strd[0].CdtrRefInf = new CreditorReferenceInformation2();
            payment.RmtInf.Strd[0].CdtrRefInf.Tp = new CreditorReferenceType2();
            payment.RmtInf.Strd[0].CdtrRefInf.Tp.CdOrPrtry = new CreditorReferenceType1Choice();
            payment.RmtInf.Strd[0].CdtrRefInf.Tp.CdOrPrtry.Item = DocumentType3Code.SCOR;
            payment.RmtInf.Strd[0].CdtrRefInf.Tp.Issr = "BBA";
            payment.RmtInf.Strd[0].CdtrRefInf.Ref = strcommunication;
            //
            _pmtInfCreditor[eddMandateStatusCounter[action.ToString()]].DrctDbtTxInf[_pmtTrnxCounter++] = payment;  
            //_eddXML.CstmrDrctDbtInitn.PmtInf[eddMandateStatusCounter[action.ToString() ]].DrctDbtTxInf[_pmtTrnxCounter++] = payment;  
        }

        public void finalizeXMLDoc()
        {
            _eddXML.CstmrDrctDbtInitn.PmtInf = new PaymentInstructionInformation4[eddMandateStatusCounter.Count]; 
            _eddXML.CstmrDrctDbtInitn.PmtInf = _pmtInfCreditor.ToArray() ;            
            //_eddXML.CstmrDrctDbtInitn.PmtInf[eddMandateStatusCounter[action.ToString()]].DrctDbtTxInf = new DirectDebitTransactionInformation9[numberOfTransactions];
        }

        public void SerializeObject( string filePathName)
        {
            if (_eddXML == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(_eddXML.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, _eddXML);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(filePathName);
                    stream.Close();
                }
            }
            catch(Exception ex)
            {
                int i = 4;
                //Log exception here
            }
        }

        public string SerializeObjectToString()
        {
            if (_eddXML == null) { return string.Empty; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(_eddXML.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, _eddXML);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    stream.Close();
                    return xmlDocument.OuterXml;                    
                }
            }
            catch (Exception ex)
            {
                int i = 4;
                //Log exception here
                return string.Empty;
            }
        }

        private decimal getAmount(DataRow drReconduction ) 
        {
            return decimal.Parse(drReconduction["amount"].ToString ());
        }
    }
}

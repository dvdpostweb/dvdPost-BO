using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace EddToXml
{
    public class EDDManager
    {
        Document _eddXML = new Document();

        public EDDManager()
        {

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

        private void Header(int numberOfTransactions, string messageID)
        {
            _eddXML.CstmrDrctDbtInitn.GrpHdr.MsgId = messageID;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.CreDtTm = DateTime.Now;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.NbOfTxs = numberOfTransactions.ToString();

            Party6Choice orgid = new Party6Choice ();
            OrganisationIdentification4 OrgId = new OrganisationIdentification4();
            GenericOrganisationIdentification1[] goi = new GenericOrganisationIdentification1[1];
            goi[0].Id = "0478510502";
            goi[0].Issr = "KBO-BCE";
            OrgId.Othr = goi;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.InitgPty.Id = orgid;
            _eddXML.CstmrDrctDbtInitn.GrpHdr.InitgPty.Nm = "Home Entertainment Services SA";
                
        }

        private void paymentInfoCreditor(int pmtInfId, int numberOfTransactions, decimal ctrlSUM)
        {
            PaymentInstructionInformation4[] pmtInfCreditor = new  PaymentInstructionInformation4 [1];
            pmtInfCreditor[0].PmtInfId = pmtInfId.ToString();            
            pmtInfCreditor[0].PmtMtd = PaymentMethod2Code.DD ; 
            pmtInfCreditor[0].BtchBookg = true;
            pmtInfCreditor[0].NbOfTxs = numberOfTransactions.ToString();
            pmtInfCreditor[0].CtrlSum = ctrlSUM;
            //
            PaymentTypeInformation20 pmtTypeInfo20 = new PaymentTypeInformation20();
            ServiceLevel8Choice serviceLevel8Choice = new ServiceLevel8Choice();
            serviceLevel8Choice.Item = "<Cd>SEPA</Cd>";
            serviceLevel8Choice.ItemElementName =  ItemChoiceType4.Cd;
            pmtTypeInfo20.SvcLvl = serviceLevel8Choice;  
            LocalInstrument2Choice localInstrument2Choice = new LocalInstrument2Choice();
            localInstrument2Choice.Item = "<Cd>CORE</Cd>";
            localInstrument2Choice.ItemElementName =  ItemChoiceType5.Cd;
            pmtInfCreditor[0].PmtTpInf.LclInstrm = localInstrument2Choice;
            pmtInfCreditor[0].PmtTpInf.SeqTp = SequenceType1Code.FRST;
            pmtInfCreditor[0].PmtTpInf.SeqTpSpecified = true;
            //
            pmtInfCreditor[0].ReqdColltnDt = DateTime.Now; 
            //
            pmtInfCreditor[0].Cdtr.Nm = "DVDPost - Home Entertainment Services";
            pmtInfCreditor[0].Cdtr.PstlAdr.Ctry = "BE";
            string[] adrLine = new string[2];
            adrLine[0] = "Rue Des Veterinaires 42A";
            adrLine[1] = "1070 Anderlecht, Bruxelles";
            pmtInfCreditor[0].Cdtr.PstlAdr.AdrLine = adrLine;
            //
            AccountIdentification4Choice accountIdentification4Choice = new AccountIdentification4Choice();
            accountIdentification4Choice.Item = "<IBAN>BE68539007547034</IBAN>";
            pmtInfCreditor[0].CdtrAcct.Id = accountIdentification4Choice;
            //
            pmtInfCreditor[0].CdtrAgt.FinInstnId.BIC = "BBRUBEBB";
            //
            pmtInfCreditor[0].ChrgBr = ChargeBearerType1Code.SLEV;
            //
            Party6Choice party6Choice = new Party6Choice();
            OrganisationIdentification4 organisationIdentification4 = new OrganisationIdentification4();
             organisationIdentification4.BICOrBEI = "BE65ZZZ0478510502";
             party6Choice.Item = organisationIdentification4;
             pmtInfCreditor[0].CdtrSchmeId.Id = party6Choice;
            //
            _eddXML.CstmrDrctDbtInitn.PmtInf = pmtInfCreditor;
        }

        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }

    }

}

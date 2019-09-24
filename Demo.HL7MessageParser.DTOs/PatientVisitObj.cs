namespace Demo.HL7MessageParser.DTOs
{
    using System;
    using Demo.HL7MessageParser.DTOs.Data;

    /// <summary>
    /// Summary description for PatientVisitRow.
    /// </summary>
    [Serializable]
    public class PatientVisitObj
    {
        private int _index;
        private PatientVisitDataSet _ds;

        public PatientVisitObj()
        {
            _index = 0;
            _ds = new PatientVisitDataSet();
            _ds.V_PATIENT_VISIT.AddV_PATIENT_VISITRow(
                                                        0, // StationID
                                                        0,	//PatientID
                                                        "",	// FirstName
                                                        "",	// MiddleInitial
                                                        "",	// LastName
                                                        "", // Gender
                                                        "", // Height
                                                        "", // Weight
                                                        DateTime.MinValue,  // Brithdate
                                                        "",	// MedRecNumber
                                                        0,	//SiteID
                                                        "", // Physician
                                                        0,	//PatientVisitId
                                                        DateTime.MinValue,	//AdmitDate
                                                        DateTime.MinValue,	//DischargeDate
                                                        0,	//CareUnitId
                                                        "",	// Room
                                                        "",	// Bed
                                                        "",	// AccountNumber
                                                        "",  // Barcode
                                                        false,
                                                        ""  // HospitalService
                                                    );
        }

        public PatientVisitObj(PatientVisitDataSet ds, int index)
        {
            _ds = ds;
            _index = index;
        }

        public PatientVisitObj(VisitObj vo)
        {
            _index = 0;
            _ds = new PatientVisitDataSet();
            _ds.V_PATIENT_VISIT.AddV_PATIENT_VISITRow(
                0,              //StationID
                vo.PatientID,	//PatientID
                "",	// FirstName
                "",	// MiddleInitial
                "",	// LastName
                "", // Gender
                "", // Height
                "", // Weight
                DateTime.MinValue,  // BirthDate
                "",	// MedRecNumber
                0,	//SiteID
                "", // Physician
                vo.PatientVisitId,	//PatientVisitId
                vo.AdmitDate,	//AdmitDate
                vo.DischargeDate,	//DischargeDate
                vo.CareUnitId,	//CareUnitId
                vo.Room,	        // Room
                vo.Bed,	        // Bed
                vo.AccountNumber,	// AccountNumber
                vo.Barcode,         // Barcode
                false,
                vo.HospitalService  // Hospital Service
            );
        }

        public PatientVisitObj(int pvIdx, PatientObj po)
        {
            _index = 0;
            _ds = new PatientVisitDataSet();
            _ds.V_PATIENT_VISIT.AddV_PATIENT_VISITRow(
                0,                                                  //StationID
                (po.PatientVisitList[pvIdx] as VisitObj).PatientID,	//PatientID
                po.FirstName,	// FirstName
                po.MiddleInitial,	// MiddleInitial
                po.LastName,	// LastName
                po.Gender, // Gender
                po.Height,
                po.Weight,
                po.BirthDate,  // BirthDate
                po.MedicalRecordNumber,	// MedRecNumber
                0,	//SiteID
                po.Physician, // Physician
                (po.PatientVisitList[pvIdx] as VisitObj).PatientVisitId,	//PatientVisitId
                (po.PatientVisitList[pvIdx] as VisitObj).AdmitDate,	//AdmitDate
                (po.PatientVisitList[pvIdx] as VisitObj).DischargeDate,	//DischargeDate
                (po.PatientVisitList[pvIdx] as VisitObj).CareUnitId,	//CareUnitId
                (po.PatientVisitList[pvIdx] as VisitObj).Room,	        // Room
                (po.PatientVisitList[pvIdx] as VisitObj).Bed,	        // Bed
                (po.PatientVisitList[pvIdx] as VisitObj).AccountNumber,	// AccountNumber
                (po.PatientVisitList[pvIdx] as VisitObj).Barcode,         // Barcode
                false,
                (po.PatientVisitList[pvIdx] as VisitObj).HospitalService // Hospital Service
           );
        }
        public int StationID
        {
            get { return _ds.V_PATIENT_VISIT[_index].IsStationIDNull() ? 0 : _ds.V_PATIENT_VISIT[_index].StationID; }
            set { _ds.V_PATIENT_VISIT[_index].StationID = value; }
        }

        public int PatientId
        {
            get { return _ds.V_PATIENT_VISIT[_index].PatientID; }
            set { _ds.V_PATIENT_VISIT[_index].PatientID = value; }
        }
        public string FirstName
        {
            get { return _ds.V_PATIENT_VISIT[_index].FirstName; }
            set { _ds.V_PATIENT_VISIT[_index].FirstName = value; }
        }
        public string MiddleInitial
        {
            get { return _ds.V_PATIENT_VISIT[_index].MiddleInitial; }
            set { _ds.V_PATIENT_VISIT[_index].MiddleInitial = value; }
        }
        public string LastName
        {
            get { return _ds.V_PATIENT_VISIT[_index].LastName; }
            set { _ds.V_PATIENT_VISIT[_index].LastName = value; }
        }
        public string Gender
        {
            get { return _ds.V_PATIENT_VISIT[_index].Gender; }
            set { _ds.V_PATIENT_VISIT[_index].Gender = value; }
        }
        public string Height
        {
            get { return _ds.V_PATIENT_VISIT[_index].Height; }
            set { _ds.V_PATIENT_VISIT[_index].Height = value; }
        }
        public string Weight
        {
            get { return _ds.V_PATIENT_VISIT[_index].Weight; }
            set { _ds.V_PATIENT_VISIT[_index].Weight = value; }
        }
        public DateTime BirthDate
        {
            get { return _ds.V_PATIENT_VISIT[_index].IsBirthDateNull() ? DateTime.MinValue : _ds.V_PATIENT_VISIT[_index].BirthDate; }
            set { _ds.V_PATIENT_VISIT[_index].BirthDate = value; }
        }
        public string MedicalRecordNumber
        {
            get { return _ds.V_PATIENT_VISIT[_index].MedRecNumber; }
            set { _ds.V_PATIENT_VISIT[_index].MedRecNumber = value; }
        }
        public int SiteID
        {
            get { return _ds.V_PATIENT_VISIT[_index].SiteID; }
            set { _ds.V_PATIENT_VISIT[_index].SiteID = value; }
        }
        public string Physician
        {
            get { return _ds.V_PATIENT_VISIT[_index].Physician; }
            set { _ds.V_PATIENT_VISIT[_index].Physician = value; }
        }
        public int PatientVisitId
        {
            get { return _ds.V_PATIENT_VISIT[_index].PatientVisitId; }
            set { _ds.V_PATIENT_VISIT[_index].PatientVisitId = value; }
        }
        public DateTime AdmitDate
        {
            get { return _ds.V_PATIENT_VISIT[_index].IsAdmitDateNull() ? DateTime.MinValue : _ds.V_PATIENT_VISIT[_index].AdmitDate; }
            set { _ds.V_PATIENT_VISIT[_index].AdmitDate = value; }
        }
        public DateTime DischargeDate
        {
            get { return _ds.V_PATIENT_VISIT[_index].IsDischargeDateNull() ? DateTime.MinValue : _ds.V_PATIENT_VISIT[_index].DischargeDate; }
            set { _ds.V_PATIENT_VISIT[_index].DischargeDate = value; }
        }
        public int CareUnitId
        {
            get { return _ds.V_PATIENT_VISIT[_index].CareUnitId; }
            set { _ds.V_PATIENT_VISIT[_index].CareUnitId = value; }
        }
        public string Room
        {
            get { return _ds.V_PATIENT_VISIT[_index].Room; }
            set { _ds.V_PATIENT_VISIT[_index].Room = value; }
        }
        public string Bed
        {
            get { return _ds.V_PATIENT_VISIT[_index].Bed; }
            set { _ds.V_PATIENT_VISIT[_index].Bed = value; }
        }
        public string AccountNumber
        {
            get { return _ds.V_PATIENT_VISIT[_index].AccountNumber; }
            set { _ds.V_PATIENT_VISIT[_index].AccountNumber = value; }
        }
        public string Barcode
        {
            get { return _ds.V_PATIENT_VISIT[_index].IsBarcodeNull() ? string.Empty : _ds.V_PATIENT_VISIT[_index].Barcode; }
            set { _ds.V_PATIENT_VISIT[_index].Barcode = value; }
        }

        public bool InMyList
        {
            get { return _ds.V_PATIENT_VISIT[_index].IsInMyListNull() ? false : _ds.V_PATIENT_VISIT[_index].InMyList; }
            set { _ds.V_PATIENT_VISIT[_index].InMyList = value; }
        }

        public string HospitalService
        {
            get { return _ds.V_PATIENT_VISIT[_index].IsHospitalServiceNull() ? string.Empty : _ds.V_PATIENT_VISIT[_index].HospitalService; }
            set { _ds.V_PATIENT_VISIT[_index].HospitalService = value; }
        }

        public PatientVisitDataSet DataSet
        {
            get { return _ds; }
        }

        public override string ToString()
        {
            return _ds.V_PATIENT_VISIT[_index].LastName + ", " + _ds.V_PATIENT_VISIT[_index].FirstName;
        }

        public string ToTCNameString()
        {
            return _ds.V_PATIENT_VISIT[_index].LastName + _ds.V_PATIENT_VISIT[_index].FirstName;
        }
    }
}

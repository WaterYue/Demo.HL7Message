namespace Demo.HL7MessageParser.DTOs
{
	using System;
	using System.Collections;
	using Demo.HL7MessageParser.DTOs.Data;

	/// <summary>
	/// Summary description for PatientRow.
	/// </summary>
	[Serializable]
	public class PatientObj
	{
		private int _index;
		private PatientDataSet _ds;
		private VisitObjList _patientVisitList = null;
		private PatientAllergyObjList _patientAllergyList = null;

		public PatientObj()
		{
			_index = 0;
			_ds = new PatientDataSet();
			_ds.V_PATIENT.AddV_PATIENTRow(
											0,					// PatientID
											"",					// FirstName
											"",					// MiddleInitial
											"",					// LastName
											DateTime.MinValue,	// BirthDate
											"",					// Gender
											"",					// Height
											"",					// Weight
											"",					// Alias
											"",					// MedRedNumber
											"",					// Physician
											0,					// PatientType
											"",					// PatientFaciltyID
											""					// SiteName
											);
		}

		public PatientObj(PatientDataSet ds, int index)
		{
			_ds = ds;
			_index = index;
		}

		public int PatientId
		{
			get { return _ds.V_PATIENT[_index].PatientID; }
			set { _ds.V_PATIENT[_index].PatientID = value; }
		}
		
		public string MedicalRecordNumber
		{
			get { return (_ds.V_PATIENT[_index].IsMedRecNumberNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].MedRecNumber; }
			set 
            {
                if( value.Length > 20 )
                    throw new System.ArgumentException( 
                        "The value violates the MaxLength limit of the MedicalRecordNumber field. MaxLength = 20" );
                _ds.V_PATIENT[_index].MedRecNumber = value; 
            }
		}
		
		public string LastName
		{
			get { return (_ds.V_PATIENT[_index].IsLastNameNull()) ?
					  string.Empty :  _ds.V_PATIENT[_index].LastName; }
			set 
            {
                if( value.Length > 20 )
                    throw new System.ArgumentException( 
                        "The value violates the MaxLength limit of the Last Name field. MaxLength = 20" );
                _ds.V_PATIENT[_index].LastName = value; 
            }
		}
		public string FirstName
		{
			get { return (_ds.V_PATIENT[_index].IsFirstNameNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].FirstName; }
			set 
            {
                if( value.Length > 20 )
                    throw new System.ArgumentException( 
                        "The value violates the MaxLength limit of the First Name field. MaxLength = 20" );
                _ds.V_PATIENT[_index].FirstName = value; 
            }
		}
		public string MiddleInitial
		{
			get { return (_ds.V_PATIENT[_index].IsMiddleInitialNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].MiddleInitial; }
			set 
            {
                _ds.V_PATIENT[_index].MiddleInitial = value;
                //if( value.Length > 0 )
                    //_ds.V_PATIENT[_index].MiddleInitial = value.Substring( 0, 1 ); // we only want 1 char
            }
		}
		public DateTime BirthDate
		{
			get { return (_ds.V_PATIENT[_index].IsBirthDateNull()) ?
					  DateTime.MinValue : _ds.V_PATIENT[_index].BirthDate; }
			set 
            { 
                if (value.Year < 1900)
					value = DateTime.MinValue;
                _ds.V_PATIENT[_index].BirthDate = value; 
            }
		}
		public string Gender
		{
			get { return (_ds.V_PATIENT[_index].IsGenderNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].Gender; }
			set 
            {
                if( value.Length > 0 )
                    _ds.V_PATIENT[_index].Gender = value.Substring( 0, 1 );  // we only want 1 char
            }
		}
		public string Height
		{
			get { return (_ds.V_PATIENT[_index].IsHeightNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].Height; }
			set 
            {
                if( value.Length > 20 )
                    throw new System.ArgumentException( 
                        "The value violates the MaxLength limit of the Height field. MaxLength = 20" );
                _ds.V_PATIENT[_index].Height = value; 
            }
		}
		public string Weight
		{
			get { return (_ds.V_PATIENT[_index].IsWeightNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].Weight; }
			set 
            {
                if( value.Length > 20 )
                    throw new System.ArgumentException( 
                        "The value violates the MaxLength limit of the Weight field. MaxLength = 20" );
                _ds.V_PATIENT[_index].Weight = value; 
            }
		}
		public string Alias
		{
			get { return (_ds.V_PATIENT[_index].IsAliasNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].Alias; }	
			set 
            { 
                if( value.Length > 0 )
                    _ds.V_PATIENT[_index].Alias = value.Substring( 0, 1 ); 
            }
		}
		public string Physician
		{
			get { return (_ds.V_PATIENT[_index].IsPhysicianNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].Physician; }
			set 
            {
                if( value.Length > 20 )
                    value = value.Substring( 0, 20 );
                _ds.V_PATIENT[_index].Physician = value; 
            }
		}
		public short PatientType
		{
			get { return (_ds.V_PATIENT[_index].IsPatientTypeNull()) ?
					  (byte)0 : _ds.V_PATIENT[_index].PatientType; }	
			set { _ds.V_PATIENT[_index].PatientType = value; }
		}

		public string PatientFacilityID
		{
			get { return (_ds.V_PATIENT[_index].IsPatientFacilityIDNull()) ?
					  string.Empty : _ds.V_PATIENT[_index].PatientFacilityID; }
			set 
            {
                if( value.Length > 2 )
                    throw new System.ArgumentException( 
                        "The value violates the MaxLength limit of the PatientFacilityID field. MaxLength = 2" );
                _ds.V_PATIENT[_index].PatientFacilityID = value; 
            }
		}

        public string MDSiteName
		{
			get { return _ds.V_PATIENT[_index].MDSiteName; }
			set 
            { 
                if( value.Length > 128 )
                    throw new System.ArgumentException( 
                        "The value violates the MaxLength limit of the MDSiteName field. MaxLength = 128" );
                _ds.V_PATIENT[_index].MDSiteName = value; 
            }
		}

		public VisitObjList PatientVisitList
		{
			get { return _patientVisitList; }
			set { _patientVisitList = value; }
		}
		public PatientAllergyObjList AllergyList
		{
			get { return _patientAllergyList; }
			set { _patientAllergyList = value; }
		}
		public override string ToString()
		{
			return _ds.V_PATIENT[_index].LastName + ", " + _ds.V_PATIENT[_index].FirstName;
        }
        public string ToTCNameString()
        {
            return _ds.V_PATIENT[_index].LastName + _ds.V_PATIENT[_index].FirstName;
        }

        public PatientDataSet DataSet
		{
			get { return _ds; }
		}
	}
}
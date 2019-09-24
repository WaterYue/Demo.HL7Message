namespace Demo.HL7MessageParser.DTOs
{
	using System;
	using Demo.HL7MessageParser.DTOs.Data;

	/// <summary>
	/// Summary description for PatientAllergyObj.
	/// </summary>
	[Serializable]
	public class PatientAllergyObj
	{

		private int _index;
		private PatientAllergyDataSet _ds;

		public PatientAllergyObj()
		{
			_index = 0;
			_ds = new PatientAllergyDataSet();
			_ds.V_PATIENT_ALLERGY.AddV_PATIENT_ALLERGYRow(
															0,					// PatientAllergyID
															0,					// PatientID
															"",					// DrugClass
															"",					// DrugClassName
															"",					// AllergyName
															DateTime.MinValue,	// EntryDate
															0					// SiteID
															);
		}

		public PatientAllergyObj(PatientAllergyDataSet ds, int index)
		{
			_ds = ds;
			_index = index;
		}

		public int PatientAllergyId
		{
			get { return _ds.V_PATIENT_ALLERGY[_index].PatientAllergyID; }
			set { _ds.V_PATIENT_ALLERGY[_index].PatientAllergyID = value; }
		}

		public int PatientId
		{
			get { return _ds.V_PATIENT_ALLERGY[_index].PatientID; }
			set { _ds.V_PATIENT_ALLERGY[_index].PatientID = value; }
		}

		public string AllergyName
		{
			get { return (_ds.V_PATIENT_ALLERGY[_index].IsAllergyNameNull()) ?
					  string.Empty : _ds.V_PATIENT_ALLERGY[_index].AllergyName; }
			set { _ds.V_PATIENT_ALLERGY[_index].AllergyName = value; }
		}

		public string DrugClass
		{
			get { return (_ds.V_PATIENT_ALLERGY[_index].IsDrugClassNull()) ?
					  string.Empty : _ds.V_PATIENT_ALLERGY[_index].DrugClass; }
			set { _ds.V_PATIENT_ALLERGY[_index].DrugClass = value; }
		}

		public string DrugClassName
		{
			get { return (_ds.V_PATIENT_ALLERGY[_index].IsDrugClassNameNull()) ?
					  string.Empty : _ds.V_PATIENT_ALLERGY[_index].DrugClassName; }
			set { _ds.V_PATIENT_ALLERGY[_index].DrugClassName = value; }
		}

		public DateTime EntryDate
		{
			get { return _ds.V_PATIENT_ALLERGY[_index].EntryDate; }
		}
	}
}

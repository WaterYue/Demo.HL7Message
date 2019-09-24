// ?Med-Dispense
// Author: Martin W Dake
// Class to provide List functionality for the exposed Object Type, in this case PatientAllergyObj

namespace Demo.HL7MessageParser.DTOs
{
	using System;
	using System.Collections;
	using Demo.HL7MessageParser.DTOs.Data;

	/// <summary>
	/// Summary description for PatientAllergyObjList.
	/// </summary>
	/// 
	[Serializable]
	public class PatientAllergyObjList : IList
	{
		private PatientAllergyDataSet _ds;

		public PatientAllergyObjList(PatientAllergyDataSet dsPatientAllergy)
		{
			_ds = dsPatientAllergy;
		}

		#region IEnumerator Members
		//	private implementation of PatientAllergyObjEnumerator
		private class PatientAllergyObjEnumerator : IEnumerator
		{
			private int index;
			private PatientAllergyObjList patientAllergyList;

			//	public within the private implementation
			//	thus, private within PatientAllergyObjList
			public PatientAllergyObjEnumerator(PatientAllergyObjList patientAllergyList)
			{
				this.patientAllergyList = patientAllergyList;
				index = -1;
			}

			//	Increment the index and make sure the
			//	value is valid
			public bool MoveNext()
			{
				return (++index >= patientAllergyList.Count) ? false : true;
			}

			public void Reset()
			{
				index = -1;
			}

			//	Current property defined as the
			//	last string added to the listbox
			public object Current
			{
				get { return (patientAllergyList[index]); }
			}
		}

		// Enumerable classes can return an enumerator
		public IEnumerator GetEnumerator()
		{
			return new PatientAllergyObjEnumerator(this);
		}
		#endregion

		#region IList Members

		public bool IsReadOnly
		{
			get { return false; }
		}

		public object this[int index]
		{
			get
			{
				if ((index > -1) && (index < _ds.V_PATIENT_ALLERGY.Rows.Count))
					return new PatientAllergyObj(_ds, index);
				else
					return null;
			}
			set
			{
				if ((index > -1) && (index < _ds.V_PATIENT_ALLERGY.Rows.Count))
				{
					//PatientAllergyObj objPatientAllergy = value as PatientAllergyObj;
					//_ds.V_PATIENT_ALLERGY[index].FeedBackID = objPatientAllergy.PatientAllergyID;
				}
			}
		}

		public void RemoveAt(int index)
		{
			if ((index < 0) || (index >= _ds.V_PATIENT_ALLERGY.Rows.Count))
			{
				throw new ArgumentOutOfRangeException("The index is out of range.");
			}

			if (_ds.V_PATIENT_ALLERGY.Rows.Count > 0)
			{
				int x = 0;
				foreach (PatientAllergyDataSet.V_PATIENT_ALLERGYRow row in _ds.V_PATIENT_ALLERGY.Rows)
				{
					if (x++ == index)
					{
						_ds.V_PATIENT_ALLERGY.RemoveV_PATIENT_ALLERGYRow(row);
						break;
					}
				}
			}
		}

		public void Insert(int index, object value)
		{
			if ((IsReadOnly) || (IsFixedSize)) 
			{
				throw new NotSupportedException("List is either read-only or a fixed size.");
			}
		}

		public void Remove(object value)
		{
			PatientAllergyObj objPatientAllergy = value as PatientAllergyObj;

			if (_ds.V_PATIENT_ALLERGY.Rows.Count > 0)
			{
				foreach (PatientAllergyDataSet.V_PATIENT_ALLERGYRow row in _ds.V_PATIENT_ALLERGY.Rows)
				{
					if (row.PatientAllergyID == objPatientAllergy.PatientAllergyId)
					{
						_ds.V_PATIENT_ALLERGY.RemoveV_PATIENT_ALLERGYRow(row);
						break;
					}
				}
			}
		}

		public bool Contains(object value)
		{
			bool containsObject = false;

			if (_ds.V_PATIENT_ALLERGY.Rows.Count > 0)
			{
				for (int x = 0; x < _ds.V_PATIENT_ALLERGY.Rows.Count; x++)
				{
					if( !_ds.V_PATIENT_ALLERGY[x].IsAllergyNameNull() )
					{
						if( _ds.V_PATIENT_ALLERGY[x].AllergyName == (value as PatientAllergyObj).AllergyName )
						{
							containsObject = true;
							break;
						}
					}
					else if( !_ds.V_PATIENT_ALLERGY[x].IsDrugClassNull() )
					{
						if( _ds.V_PATIENT_ALLERGY[x].DrugClass == (value as PatientAllergyObj).DrugClass )
						{
							containsObject = true;
							break;
						}
					}
					else if( !_ds.V_PATIENT_ALLERGY[x].IsDrugClassNameNull() )
					{
						if( _ds.V_PATIENT_ALLERGY[x].DrugClassName == (value as PatientAllergyObj).DrugClassName )
						{
							containsObject = true;
							break;
						}
					}
					else if (_ds.V_PATIENT_ALLERGY[x].PatientAllergyID == (value as PatientAllergyObj).PatientAllergyId)
					{
						containsObject = true;
						break;
					}
				}
			}

			return containsObject;
		}

		public void Clear()
		{
			_ds.V_PATIENT_ALLERGY.Clear();
		}

		public int IndexOf(object value)
		{
			int index = -1;
			for (int x = 0; x < _ds.V_PATIENT_ALLERGY.Rows.Count; x++)
			{
				if (_ds.V_PATIENT_ALLERGY[x].PatientAllergyID == (value as PatientAllergyObj).PatientAllergyId)
				{
					index = x;
					break;
				}
			}

			return index;
		}

		public int Add(object value)
		{
			PatientAllergyObj objPatientAllergy = value as PatientAllergyObj;

			_ds.V_PATIENT_ALLERGY.AddV_PATIENT_ALLERGYRow(
															objPatientAllergy.PatientAllergyId,		// PatientAllergyID
															objPatientAllergy.PatientId,			// PatientID
															objPatientAllergy.DrugClass,			// DrugClass
															objPatientAllergy.DrugClassName,		// DrugClassName
															objPatientAllergy.AllergyName,			// AllergyName
															objPatientAllergy.EntryDate,			// EntryDate
															0										// SiteiD
														);
			return 1;
		}

		public bool IsFixedSize
		{
			get { return false; }
		}

		#endregion

		#region ICollection Members

		public bool IsSynchronized
		{
			get { return false; }
		}

		public int Count
		{
			get { return _ds.V_PATIENT_ALLERGY.Rows.Count; }
		}

		public void CopyTo(Array array, int index)
		{
			if ((index < 0) || (index >= _ds.V_PATIENT_ALLERGY.Rows.Count))
			{
				throw new ArgumentOutOfRangeException("The index is out of range.");
			}

			if (array.Length < (this.Count - (index + 1)))
			{
				throw new ArgumentException("Array cannot hold all values.");
			}

			int y = 0;
			for (int x = index; x < _ds.V_PATIENT_ALLERGY.Rows.Count; x++)
			{
				array.SetValue(new PatientAllergyObj(_ds, x), y);
				y++;
			}
		}

		public object SyncRoot
		{
			get { return null; }
		}

		#endregion
	}
}

// ?Med-Dispense
// Author: Martin W Dake
// Class to provide List functionality for the exposed Object Type, in this case PatientObj

namespace Demo.HL7MessageParser.DTOs
{
	using System;
	using System.Collections;
	using Demo.HL7MessageParser.DTOs.Data;

	/// <summary>
	/// Summary description for PatientObjList.
	/// </summary>
	public class PatientObjList : IList
	{
		private PatientDataSet _ds;

		public PatientObjList(PatientDataSet dsPatient)
		{
			_ds = dsPatient;
		}

		#region IEnumerator Members
		//	private implementation of PatientObjEnumerator
		private class PatientObjEnumerator : IEnumerator
		{
			private int index;
			private PatientObjList patientList;

			//	public within the private implementation
			//	thus, private within PatientObjList
			public PatientObjEnumerator(PatientObjList patientList)
			{
				this.patientList = patientList;
				index = -1;
			}

			//	Increment the index and make sure the
			//	value is valid
			public bool MoveNext()
			{
				return (++index >= patientList.Count) ? false : true;
			}

			public void Reset()
			{
				index = -1;
			}

			//	Current property defined as the
			//	last string added to the listbox
			public object Current
			{
				get { return (patientList[index]); }
			}
		}

		// Enumerable classes can return an enumerator
		public IEnumerator GetEnumerator()
		{
			return new PatientObjEnumerator(this);
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
				if ((index > -1) && (index < _ds.V_PATIENT.Rows.Count))
					return new PatientObj(_ds, index);
				else
					return null;
			}
			set
			{
				if ((index > -1) && (index < _ds.V_PATIENT.Rows.Count))
				{
					//PatientObj objPatient = value as PatientObj;
					//_ds.V_PATIENT[index].FeedBackID = objPatient.PatientID;
				}
			}
		}

		public void RemoveAt(int index)
		{
			if ((index < 0) || (index >= _ds.V_PATIENT.Rows.Count))
			{
				throw new ArgumentOutOfRangeException("The index is out of range.");
			}

			if (_ds.V_PATIENT.Rows.Count > 0)
			{
				int x = 0;
				foreach (PatientDataSet.V_PATIENTRow row in _ds.V_PATIENT.Rows)
				{
					if (x++ == index)
					{
						_ds.V_PATIENT.RemoveV_PATIENTRow(row);
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
			PatientObj objPatient = value as PatientObj;

			if (_ds.V_PATIENT.Rows.Count > 0)
			{
				foreach (PatientDataSet.V_PATIENTRow row in _ds.V_PATIENT.Rows)
				{
					if (row.PatientID == objPatient.PatientId)
					{
						_ds.V_PATIENT.RemoveV_PATIENTRow(row);
						break;
					}
				}
			}
		}

		public bool Contains(object value)
		{
			bool containsObject = false;

			if (_ds.V_PATIENT.Rows.Count > 0)
			{
				for (int x = 0; x < _ds.V_PATIENT.Rows.Count; x++)
				{
					if (_ds.V_PATIENT[x].PatientID == (value as PatientObj).PatientId)
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
			_ds.V_PATIENT.Clear();
		}

		public int IndexOf(object value)
		{
			int index = -1;
			for (int x = 0; x < _ds.V_PATIENT.Rows.Count; x++)
			{
				if (_ds.V_PATIENT[x].PatientID == (value as PatientObj).PatientId)
				{
					index = x;
					break;
				}
			}

			return index;
		}

		public int Add(object value)
		{
			PatientObj objPatient = value as PatientObj;

			_ds.V_PATIENT.AddV_PATIENTRow(
											objPatient.PatientId,			// PatientID
											objPatient.FirstName,			// FirstName
											objPatient.MiddleInitial,		// MiddleInitial
											objPatient.LastName,			// LastName
											objPatient.BirthDate,			// BirthDate
											objPatient.Gender,				// Gender
											objPatient.Height,				// Height
											objPatient.Weight,				// Weight
											objPatient.Alias,				// Alias
											objPatient.MedicalRecordNumber,	// MedRedNumber
											objPatient.Physician,			// Physician
											objPatient.PatientType,			// PatientType
											objPatient.PatientFacilityID,	// PatientFaciltyID
											objPatient.MDSiteName			// SiteName
										);
			return 1;
		}

		public bool IsFixedSize
		{
			get { return false; }
		}

		public PatientDataSet DataSet
		{
			get { return _ds; }
		}

		#endregion

		#region ICollection Members

		public bool IsSynchronized
		{
			get { return false; }
		}

		public int Count
		{
			get { return _ds.V_PATIENT.Rows.Count; }
		}

		public void CopyTo(Array array, int index)
		{
			if ((index < 0) || (index >= _ds.V_PATIENT.Rows.Count))
			{
				throw new ArgumentOutOfRangeException("The index is out of range.");
			}

			if (array.Length < (this.Count - (index + 1)))
			{
				throw new ArgumentException("Array cannot hold all values.");
			}

			int y = 0;
			for (int x = index; x < _ds.V_PATIENT.Rows.Count; x++)
			{
				array.SetValue(new PatientObj(_ds, x), y);
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

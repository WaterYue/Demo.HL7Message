namespace Demo.HL7MessageParser.DTOs
{
	using System;
	using System.Data;
	using System.Collections;
	using Demo.HL7MessageParser.DTOs.Data;
    using Demo.HL7MessageParser.DTOs.Data;

    /// <summary>
    /// Summary description for VisitObjList.
    /// </summary>
    /// 
    [Serializable]
	public class VisitObjList : IList
	{
		private VisitDataSet _ds;
		//private VisitObjList _ol;

		public VisitObjList(VisitDataSet dsVisit)
		{
			_ds = dsVisit;
		}
		public VisitObjList(VisitObjList  olVisit)
		{
			_ds = (VisitDataSet)olVisit._ds.Copy();
			//_ol._ds = (VisitDataSet)olVisit._ds.Copy();
		}

		private void CopyToDataSet(DataView dv)
		{
			int idx = 0;
			VisitDataSet ds = new VisitDataSet();

			string[] strColNames = new string[ds.V_VISIT.Columns.Count];
			foreach (DataColumn col in ds.V_VISIT.Columns)
				strColNames[idx++] = col.ColumnName;

			IEnumerator viewEnumerator = dv.GetEnumerator();
			while (viewEnumerator.MoveNext())
			{
				DataRowView drv = (DataRowView)viewEnumerator.Current;
				VisitDataSet.V_VISITRow dr = ds.V_VISIT.NewV_VISITRow();

				foreach (string strName in strColNames)
					dr[strName] = drv[strName];

				ds.V_VISIT.AddV_VISITRow(dr);
			}

			_ds.Dispose();
			_ds = ds;
		}

		#region IEnumerator Members
		//	private implementation of VisitObjEnumerator
		private class VisitObjEnumerator : IEnumerator
		{
			private int index;
			private VisitObjList VisitList;

			//	public within the private implementation
			//	thus, private within VisitObjList
			public VisitObjEnumerator(VisitObjList VisitList)
			{
				this.VisitList = VisitList;
				index = -1;
			}

			//	Increment the index and make sure the
			//	value is valid
			public bool MoveNext()
			{
				return (++index >= VisitList.Count) ? false : true;
			}

			public void Reset()
			{
				index = -1;
			}

			//	Current property defined as the
			//	last string added to the listbox
			public object Current
			{
				get { return (VisitList[index]); }
			}
		}

		// Enumerable classes can return an enumerator
		public IEnumerator GetEnumerator()
		{
			return new VisitObjEnumerator(this);
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
				if ((index > -1) && (index < _ds.V_VISIT.Rows.Count))
					return new VisitObj(_ds, index);
				else
					return null;
			}
			set
			{
				if ((index > -1) && (index < _ds.V_VISIT.Rows.Count))
				{
					//VisitObj objVisit = value as VisitObj;
					//_ds.V_VISIT[index].FeedBackID = objVisit.PatientVisitId;
				}
			}
		}

        public object this[string accountNumber]
		{
			get
			{
                for (int x = 0; x < _ds.V_VISIT.Rows.Count; ++x)
				{
					if( _ds.V_VISIT[x].AccountNumber == accountNumber )
						return new VisitObj(_ds, x);
				}
				
                return null;
			}
		}

		public void RemoveAt(int index)
		{
			if ((index < 0) || (index >= _ds.V_VISIT.Rows.Count))
			{
				throw new ArgumentOutOfRangeException("The index is out of range.");
			}

			if (_ds.V_VISIT.Rows.Count > 0)
			{
				int x = 0;
				foreach (VisitDataSet.V_VISITRow row in _ds.V_VISIT.Rows)
				{
					if (x++ == index)
					{
						_ds.V_VISIT.RemoveV_VISITRow(row);
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
			VisitObj objVisit = value as VisitObj;

			if (_ds.V_VISIT.Rows.Count > 0)
			{
				foreach (VisitDataSet.V_VISITRow row in _ds.V_VISIT.Rows)
				{
					if (row.PatientVisitID == objVisit.PatientVisitId)
					{
						_ds.V_VISIT.RemoveV_VISITRow(row);
						break;
					}
				}
			}
		}

		public bool Contains(object value)
		{
			bool containsObject = false;

			if (_ds.V_VISIT.Rows.Count > 0)
			{
				for (int x = 0; x < _ds.V_VISIT.Rows.Count; x++)
				{
					if (_ds.V_VISIT[x].PatientVisitID == (value as VisitObj).PatientVisitId)
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
			_ds.V_VISIT.Clear();
		}

		public int IndexOf(object value)
		{
			int index = -1;
			for (int x = 0; x < _ds.V_VISIT.Rows.Count; x++)
			{
				if (_ds.V_VISIT[x].PatientVisitID == (value as VisitObj).PatientVisitId)
				{
					index = x;
					break;
				}
			}

			return index;
		}

        public int IndexOf(string accountNumber)
		{
			int index = -1;
			for (int x = 0; x < _ds.V_VISIT.Rows.Count; x++)
			{
				if (_ds.V_VISIT[x].AccountNumber == accountNumber)
				{
					index = x;
					break;
				}
			}

			return index;
		}

		public int Add(object value)
		{
			VisitObj objVisit = value as VisitObj;

			_ds.V_VISIT.AddV_VISITRow
				(
			    objVisit.PatientVisitId,
                objVisit.PatientID,
                objVisit.CareUnitId,
			    objVisit.AdmitDate,
			    objVisit.DischargeDate,
			    objVisit.Room,
			    objVisit.Bed,
			    objVisit.AccountNumber,
                objVisit.Barcode,
                objVisit.HospitalService
                );					
			return 1;
		}

		public bool IsFixedSize
		{
			get { return false; }
		}

		public VisitDataSet DataSet
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
			get { return _ds.V_VISIT.Rows.Count; }
		}

		public void CopyTo(Array array, int index)
		{
			if ((index < 0) || (index >= _ds.V_VISIT.Rows.Count))
			{
				throw new ArgumentOutOfRangeException("The index is out of range.");
			}

			if (array.Length < (this.Count - (index + 1)))
			{
				throw new ArgumentException("Array cannot hold all values.");
			}

			int y = 0;
			for (int x = index; x < _ds.V_VISIT.Rows.Count; x++)
			{
				array.SetValue(new VisitObj(_ds, x), y);
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

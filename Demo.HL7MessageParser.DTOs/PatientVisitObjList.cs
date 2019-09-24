// ?Med-Dispense
// Author: Martin W Dake
// Class to provide List functionality for the exposed Object Type, in this case PatientVisitObj

namespace Demo.HL7MessageParser.DTOs
{
    using System;
    using System.Collections;
    using Demo.HL7MessageParser.DTOs.Data;

    /// <summary>
    /// Summary description for PatientVisitObjList.
    /// </summary>
    /// 
    [Serializable]
    public class PatientVisitObjList : IList
    {
        private PatientVisitDataSet _ds;

        public PatientVisitObjList(PatientVisitDataSet dsPatientVisit)
        {
            _ds = dsPatientVisit;
        }

        public PatientVisitDataSet DataSet
        {
            get { return _ds; }
        }

        #region IEnumerator Members
        //	private implementation of PatientVisitObjEnumerator
        private class PatientVisitObjEnumerator : IEnumerator
        {
            private int index;
            private PatientVisitObjList patientVisitList;

            //	public within the private implementation
            //	thus, private within PatientVisitObjList
            public PatientVisitObjEnumerator(PatientVisitObjList patientVisitList)
            {
                this.patientVisitList = patientVisitList;
                index = -1;
            }

            //	Increment the index and make sure the
            //	value is valid
            public bool MoveNext()
            {
                return (++index >= patientVisitList.Count) ? false : true;
            }

            public void Reset()
            {
                index = -1;
            }

            //	Current property defined as the
            //	last string added to the listbox
            public object Current
            {
                get { return (patientVisitList[index]); }
            }
        }

        // Enumerable classes can return an enumerator
        public IEnumerator GetEnumerator()
        {
            return new PatientVisitObjEnumerator(this);
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
                if ((index > -1) && (index < _ds.V_PATIENT_VISIT.Rows.Count))
                    return new PatientVisitObj(_ds, index);
                else
                    return null;
            }
            set
            {
                if ((index > -1) && (index < _ds.V_PATIENT_VISIT.Rows.Count))
                {
                    //PatientVisitObj objPatientVisit = value as PatientVisitObj;
                    //_ds.V_PATIENT_VISIT[index].FeedBackID = objPatientVisit.PatientVisitID;
                }
            }
        }

        public object this[string accountNumber]
        {
            get
            {
                int index = IndexOf(accountNumber);
                if (index > -1)
                    return new PatientVisitObj(_ds, index);
                else
                    return null;
            }
        }

        public void RemoveAt(int index)
        {
            if ((index < 0) || (index >= _ds.V_PATIENT_VISIT.Rows.Count))
            {
                throw new ArgumentOutOfRangeException("The index is out of range.");
            }

            if (_ds.V_PATIENT_VISIT.Rows.Count > 0)
            {
                int x = 0;
                foreach (PatientVisitDataSet.V_PATIENT_VISITRow row in _ds.V_PATIENT_VISIT.Rows)
                {
                    if (x++ == index)
                    {
                        _ds.V_PATIENT_VISIT.RemoveV_PATIENT_VISITRow(row);
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
            PatientVisitObj objPatientVisit = value as PatientVisitObj;

            if (_ds.V_PATIENT_VISIT.Rows.Count > 0)
            {
                foreach (PatientVisitDataSet.V_PATIENT_VISITRow row in _ds.V_PATIENT_VISIT.Rows)
                {
                    if (row.PatientVisitId == objPatientVisit.PatientVisitId)
                    {
                        _ds.V_PATIENT_VISIT.RemoveV_PATIENT_VISITRow(row);
                        break;
                    }
                }
            }
        }

        public bool Contains(object value)
        {
            bool containsObject = false;

            if (_ds.V_PATIENT_VISIT.Rows.Count > 0)
            {
                for (int x = 0; x < _ds.V_PATIENT_VISIT.Rows.Count; x++)
                {
                    if (_ds.V_PATIENT_VISIT[x].PatientVisitId == (value as PatientVisitObj).PatientVisitId)
                    {
                        containsObject = true;
                        break;
                    }
                }
            }

            return containsObject;
        }

        public void SortByAdmitDate()
        {
            using (System.Data.DataView dv = new System.Data.DataView(_ds.V_PATIENT_VISIT, string.Empty, "AdmitDate ASC", System.Data.DataViewRowState.CurrentRows))
                CopyToDataSet(dv);
        }

        public void Clear()
        {
            _ds.V_PATIENT_VISIT.Clear();
        }

        public int IndexOf(object value)
        {
            int index = -1;
            for (int x = 0; x < _ds.V_PATIENT_VISIT.Rows.Count; x++)
            {
                if (_ds.V_PATIENT_VISIT[x].PatientVisitId == (value as PatientVisitObj).PatientVisitId)
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
            for (int x = 0; x < _ds.V_PATIENT_VISIT.Rows.Count; x++)
            {
                if (_ds.V_PATIENT_VISIT[x].AccountNumber == accountNumber)
                {
                    index = x;
                    break;
                }
            }

            return index;
        }

        private void CopyToDataSet(System.Data.DataView dv)
        {
            int idx = 0;
            PatientVisitDataSet ds = new PatientVisitDataSet();

            string[] strColNames = new string[ds.V_PATIENT_VISIT.Columns.Count];
            foreach (System.Data.DataColumn col in ds.V_PATIENT_VISIT.Columns)
                strColNames[idx++] = col.ColumnName;

            IEnumerator viewEnumerator = dv.GetEnumerator();
            while (viewEnumerator.MoveNext())
            {
                System.Data.DataRowView drv = (System.Data.DataRowView)viewEnumerator.Current;
                PatientVisitDataSet.V_PATIENT_VISITRow dr = ds.V_PATIENT_VISIT.NewV_PATIENT_VISITRow();

                foreach (string strName in strColNames)
                    dr[strName] = drv[strName];

                ds.V_PATIENT_VISIT.AddV_PATIENT_VISITRow(dr);
            }

            _ds = ds;
        }

        public int Add(object value)
        {
            PatientVisitObj objPatientVisit = value as PatientVisitObj;

            _ds.V_PATIENT_VISIT.AddV_PATIENT_VISITRow(
                                                        objPatientVisit.StationID,
                                                        objPatientVisit.PatientId,
                                                        objPatientVisit.FirstName,
                                                        objPatientVisit.MiddleInitial,
                                                        objPatientVisit.LastName,
                                                        objPatientVisit.Gender,
                                                        objPatientVisit.Height,
                                                        objPatientVisit.Weight,
                                                        objPatientVisit.BirthDate,
                                                        objPatientVisit.MedicalRecordNumber,
                                                        objPatientVisit.SiteID,
                                                        objPatientVisit.Physician,
                                                        objPatientVisit.PatientVisitId,
                                                        objPatientVisit.AdmitDate,
                                                        objPatientVisit.DischargeDate,
                                                        objPatientVisit.CareUnitId,
                                                        objPatientVisit.Room,
                                                        objPatientVisit.Bed,
                                                        objPatientVisit.AccountNumber,
                                                        objPatientVisit.Barcode,
                                                        objPatientVisit.InMyList,
                                                        objPatientVisit.HospitalService
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
            get { return _ds.V_PATIENT_VISIT.Rows.Count; }
        }

        public void CopyTo(Array array, int index)
        {
            if ((index < 0) || (index >= _ds.V_PATIENT_VISIT.Rows.Count))
            {
                throw new ArgumentOutOfRangeException("The index is out of range.");
            }

            if (array.Length < (this.Count - (index + 1)))
            {
                throw new ArgumentException("Array cannot hold all values.");
            }

            int y = 0;
            for (int x = index; x < _ds.V_PATIENT_VISIT.Rows.Count; x++)
            {
                array.SetValue(new PatientVisitObj(_ds, x), y);
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

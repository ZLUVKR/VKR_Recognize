using Recognize.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognize.Views
{
    public class PatientViewPresenter
    {
        public List<Entities.Record> Document;

        private RecordDA _recordDA;
        private RecordDA RecordDA
        {
            get { return _recordDA ??= new RecordDA(); }
        }

        public void GetDocument()
        {
            Document = RecordDA.GetAllRecords();
        }
    }
}

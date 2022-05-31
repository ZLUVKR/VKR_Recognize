using Recognize.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognize.Views
{
    public class DetailImageViewPresenter
    {

        private RecordDA _recordDA;
        private RecordDA RecordDA
        {
            get { return _recordDA ??= new RecordDA(); }
        }

        public void SaveRecord(Entities.Record record)
        {
            RecordDA.SaveRecord(record);
        }
    }
}

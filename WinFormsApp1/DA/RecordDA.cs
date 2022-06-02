using System.Data;
using System.Data.Odbc;

namespace Recognize.DA
{
    /// <summary>
    /// Доступ к данным таблицы записи
    /// </summary>
    internal class RecordDA : BaseDA
    {
        public List<Entities.Record> GetAllRecords()
        {
            var records = new List<Entities.Record>();
            using (var cmd = ExcelCmd("select * from [record$]"))
            {
                CmdExecutor(cmd, delegate
                {
                    OdbcDataReader dr = cmd.ExecuteReader();
                    foreach (IDataRecord item in dr)
                    {
                        var record = new Entities.Record()
                        {
                            Id = long.Parse(item["id"].ToString()),
                            PatientName = item["patient_fullname"].ToString(),
                            ImagePath = item["image_path"].ToString(),
                            Сonclusion = item["conclusion"].ToString(),
                            СonclusionOfNeural = item["conclusion_of_neural"].ToString(),
                            DoctorName = item["doctor_fullname"].ToString(),
                        };
                        DateTime inputDate;
                        if (DateTime.TryParse(item["input_date"].ToString(), out inputDate))
                            record.InputDate = inputDate;
                        DateTime endDate;
                        if (DateTime.TryParse(item["end_date"].ToString(), out endDate))
                            record.EndDate = endDate;
                        records.Add(record);
                    }
                });
            }
            return records;
        }

        /// <summary>
        /// Сохранение записи
        /// </summary>
        /// <param name="record">запись, которую необходимо сохранить</param>
        public void SaveRecord(Entities.Record record)
        {

            using (var cmd = ExcelCmd($"update [record$] set conclusion = ?, doctor_fullname = ?, end_date = ?, conclusion_of_neural = ? where id = ?"))
            {
                CmdExecutor(cmd, delegate
                {
                    cmd.Parameters.Add("@conclusion", OdbcType.VarChar).Value = record.Сonclusion;
                    cmd.Parameters.Add("@doctor_fullname", OdbcType.VarChar).Value = record.DoctorName;
                    cmd.Parameters.Add("@end_date", OdbcType.Date).Value = record.EndDate;
                    cmd.Parameters.Add("@conclusion_of_neural", OdbcType.VarChar).Value = record.СonclusionOfNeural;
                    cmd.Parameters.Add("@id", OdbcType.Int).Value = record.Id;

                    cmd.ExecuteNonQuery();
                });
            }
        }
    }
}

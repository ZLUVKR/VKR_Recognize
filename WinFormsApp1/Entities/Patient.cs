namespace Recognize.Entities
{
    internal class Patient
    {
        /// <summary>
        /// ИД
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// ИД привязанного доктора
        /// </summary>
        public long DoctorId { get; set; }

        /// <summary>
        /// Диагнозы
        /// </summary>
        public List<PatientDiagnose> Diagnoses { get; set; }
    }
}

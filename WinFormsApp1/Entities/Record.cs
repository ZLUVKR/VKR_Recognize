namespace Recognize.Entities
{
    public class Record
    {
        /// <summary>
        /// Ид записи
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Имя пациента
        /// </summary>
        public string? PatientName { get; set; }

        /// <summary>
        /// Путь к рентгеновскому снимку
        /// </summary>
        public string? ImagePath { get; set; }

        /// <summary>
        /// Заключение врача
        /// </summary>
        public string? Сonclusion { get; set; }

        /// <summary>
        /// Заключение нейронной сети
        /// </summary>
        public string? СonclusionOfNeural { get; set; }

        /// <summary>
        /// Состояние обработки записи: 1 - проект, 0 - есть заключение
        /// </summary>
        public int ProcessingState
        {
            get { return string.IsNullOrWhiteSpace(Сonclusion) ? 1 : 0; }
        }

        /// <summary>
        /// Состояние обработки записи: 1 - проект, 0 - есть заключение
        /// </summary>
        public string ProcessingStateAsText
        {
            get { return ProcessingState == 1 ? "не обработано" : "есть заключение"; }
        }

        /// <summary>
        /// Имя доктора, который сделал заключение
        /// </summary>
        public string? DoctorName { get; set; }

        /// <summary>
        /// Дата, когда было сделан R - снимок
        /// </summary>
        public DateTime? InputDate { get; set; }

        /// <summary>
        /// Дата, когда было сделано заключение
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}

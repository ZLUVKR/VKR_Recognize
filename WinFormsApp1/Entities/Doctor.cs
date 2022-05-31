namespace Recognize.Entities
{
    /// <summary>
    /// Доктор
    /// </summary>
    internal class Doctor
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
        /// Логин
        /// </summary>
        public string Login { get; set; }   
    }
}

namespace Recognize.Entities
{
    internal class PatientDiagnose
    {
        public long Id { get; set; }

        public long PatientId { get; set; }

        public string ImagePath { get; set; }

        public string Diagnose { get; set; }

        public byte[] ImgData { get; set; }
    }
}

using System;



namespace R5T.E0067
{
    public class FilePath : IFilePath
    {
        #region Static

        public static implicit operator FilePath(string value)
        {
            var output = new FilePath
            {
                Value = value,
            };

            return output;
        }

        #endregion


        public string Value { get; set; }
    }
}

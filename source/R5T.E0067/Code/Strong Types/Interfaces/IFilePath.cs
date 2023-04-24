using System;



namespace R5T.E0067
{
    public interface IFilePath
    {
        #region Static

        //public static virtual implicit operator IFilePath(string value)
        //{
        //    var output = new FilePath
        //    {
        //        Value = value
        //    };

        //    return output;
        //}

        //// STILL not possible in .NET 7.0!
        //// CS0552: user-defined conversions to or from an interface are not allowed
        //public static virtual implicit operator string(IFilePath filePath)
        //{
        //    return filePath.Value;
        //}

        //// Also not possible in .NET 7.0!
        //// CS0552: user-defined conversions to or from an interface are not allowed
        //public static virtual explicit operator string(IFilePath filePath)
        //{
        //    return filePath.Value;
        //}

        //// Now possible in .NET 7.0
        //public static virtual IFilePath operator +(IFilePath a, IFilePath b)
        //{
        //    return new FilePath();
        //}

        #endregion


        public string Value { get; }
    }
}

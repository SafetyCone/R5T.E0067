using System;

using R5T.T0132;


namespace R5T.E0067
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public void TestOfPath(IDirectoryPath directoryPath)
        {

        }

        public void TestOfPath(IFilePath filePath)
        {

        }
    }
}

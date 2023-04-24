using System;

using R5T.T0141;


namespace R5T.E0067.Construction
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        public void InterfaceInstanceFromImplementationInstanceFromStringInstance()
        {
            FilePath filePathA = "A"; /// Ok, due to <see cref="FilePath.op_Implicit(string)"/>

            Console.WriteLine(filePathA);

            //IFilePath filePathB = "B"; // Fails, CS0029: Cannot implicitly convert type 'string' to 'R5T.E0067.IFilePath'
        }
    }
}

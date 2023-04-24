# R5T.E0067
A .NET 7.0 library of strong types as interfaces, exploring the ability to have operators on interfaces in .NET 7.0.


## Results

FAILURE: The result of this experiment is that C# does *not* allow custom conversion operators for interfaces.
Thus there will always be the pesky ".Value" call at every code site where an underlying-type instance is required from a strongly-typed interface instance.
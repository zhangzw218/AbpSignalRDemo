using System;

namespace MigrationDemo.Test.Dtos;

[Serializable]
public class CreateUpdateTempUserDto
{
    public string Name { get; set; }

    //public TempRole TempRole { get; set; }
}
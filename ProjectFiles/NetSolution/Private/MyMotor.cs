using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "Basico_Ejercicio1_Aliases", Guid = "ef3de11c81664ebcdf5bcd9d4f2a59b0")]
public class MyMotor : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int Speed
    {
        get
        {
            return (int)Refs.GetVariable("Speed").Value.Value;
        }
        set
        {
            Refs.GetVariable("Speed").SetValue(value);
        }
    }
    public IUAVariable SpeedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Speed");
        }
    }
    public int Temperature
    {
        get
        {
            return (int)Refs.GetVariable("Temperature").Value.Value;
        }
        set
        {
            Refs.GetVariable("Temperature").SetValue(value);
        }
    }
    public IUAVariable TemperatureVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Temperature");
        }
    }
    public bool Alarm
    {
        get
        {
            return (bool)Refs.GetVariable("Alarm").Value.Value;
        }
        set
        {
            Refs.GetVariable("Alarm").SetValue(value);
        }
    }
    public IUAVariable AlarmVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Alarm");
        }
    }
#endregion
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_LUTRON_HOMEWORKS_QS_HVAC_CONTROLLER_MODULE_S__R02_CF_MOD
{
    public class UserModuleClass_LUTRON_HOMEWORKS_QS_HVAC_CONTROLLER_MODULE_S__R02_CF_MOD : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput HEAT_SET_POINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput HEAT_SET_POINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput COOL_SET_POINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput COOL_SET_POINT_DOWN;
        Crestron.Logos.SplusObjects.AnalogInput INT_ID;
        Crestron.Logos.SplusObjects.StringInput IN__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_TEMPERATURE;
        Crestron.Logos.SplusObjects.AnalogOutput HEAT_SET_POINT;
        Crestron.Logos.SplusObjects.AnalogOutput COOL_SET_POINT;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        object HEAT_SET_POINT_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 164;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.HSPINT < 82 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 166;
                    _SplusNVRAM.HSPINT = (ushort) ( (_SplusNVRAM.HSPINT + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 170;
                    _SplusNVRAM.HSPINT = (ushort) ( 82 ) ; 
                    } 
                
                __context__.SourceCodeLine = 172;
                MakeString ( TX__DOLLAR__ , "#HVAC,{0:d},2,{1:d},{2:d}\r\n", (short)INT_ID  .UshortValue, (short)_SplusNVRAM.CSPINT, (short)_SplusNVRAM.CSPINT) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object HEAT_SET_POINT_DOWN_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 177;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.HSPINT > 63 ))  ) ) 
                { 
                __context__.SourceCodeLine = 179;
                _SplusNVRAM.HSPINT = (ushort) ( (_SplusNVRAM.HSPINT - 1) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 183;
                _SplusNVRAM.HSPINT = (ushort) ( 63 ) ; 
                } 
            
            __context__.SourceCodeLine = 185;
            MakeString ( TX__DOLLAR__ , "#HVAC,{0:d},2,{1:d},{2:d}\r\n", (short)INT_ID  .UshortValue, (short)_SplusNVRAM.CSPINT, (short)_SplusNVRAM.CSPINT) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object COOL_SET_POINT_UP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 190;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CSPINT < 82 ))  ) ) 
            { 
            __context__.SourceCodeLine = 192;
            _SplusNVRAM.CSPINT = (ushort) ( (_SplusNVRAM.CSPINT + 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 196;
            _SplusNVRAM.CSPINT = (ushort) ( 82 ) ; 
            } 
        
        __context__.SourceCodeLine = 198;
        MakeString ( TX__DOLLAR__ , "#HVAC,{0:d},2,{1:d},{2:d}\r\n", (short)INT_ID  .UshortValue, (short)_SplusNVRAM.CSPINT, (short)_SplusNVRAM.CSPINT) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COOL_SET_POINT_DOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 203;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.CSPINT > 63 ))  ) ) 
            { 
            __context__.SourceCodeLine = 205;
            _SplusNVRAM.CSPINT = (ushort) ( (_SplusNVRAM.CSPINT - 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 209;
            _SplusNVRAM.CSPINT = (ushort) ( 63 ) ; 
            } 
        
        __context__.SourceCodeLine = 211;
        MakeString ( TX__DOLLAR__ , "#HVAC,{0:d},2,{1:d},{2:d}\r\n", (short)INT_ID  .UshortValue, (short)_SplusNVRAM.CSPINT, (short)_SplusNVRAM.CSPINT) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP__DOLLAR__;
        TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        
        ushort ACTION_NUMBER = 0;
        
        
        __context__.SourceCodeLine = 225;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~HVAC," , IN__DOLLAR__ ) == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 227;
            TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "~HVAC," , IN__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 228;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Atoi( IN__DOLLAR__ ) == INT_ID  .UshortValue))  ) ) 
                { 
                __context__.SourceCodeLine = 230;
                TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "," , IN__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 231;
                ACTION_NUMBER = (ushort) ( Functions.Atoi( IN__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 232;
                TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "," , IN__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 233;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)ACTION_NUMBER);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 237;
                            CURRENT_TEMPERATURE  .Value = (ushort) ( Functions.Atoi( IN__DOLLAR__ ) ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 241;
                            _SplusNVRAM.HSPINT = (ushort) ( Functions.Atoi( IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 242;
                            HEAT_SET_POINT  .Value = (ushort) ( _SplusNVRAM.HSPINT ) ; 
                            __context__.SourceCodeLine = 243;
                            TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "," , IN__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 244;
                            _SplusNVRAM.CSPINT = (ushort) ( Functions.Atoi( IN__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 245;
                            COOL_SET_POINT  .Value = (ushort) ( _SplusNVRAM.CSPINT ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 295;
        Functions.ClearBuffer ( IN__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    HEAT_SET_POINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( HEAT_SET_POINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( HEAT_SET_POINT_UP__DigitalInput__, HEAT_SET_POINT_UP );
    
    HEAT_SET_POINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( HEAT_SET_POINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( HEAT_SET_POINT_DOWN__DigitalInput__, HEAT_SET_POINT_DOWN );
    
    COOL_SET_POINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( COOL_SET_POINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( COOL_SET_POINT_UP__DigitalInput__, COOL_SET_POINT_UP );
    
    COOL_SET_POINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( COOL_SET_POINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( COOL_SET_POINT_DOWN__DigitalInput__, COOL_SET_POINT_DOWN );
    
    INT_ID = new Crestron.Logos.SplusObjects.AnalogInput( INT_ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INT_ID__AnalogSerialInput__, INT_ID );
    
    CURRENT_TEMPERATURE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_TEMPERATURE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_TEMPERATURE__AnalogSerialOutput__, CURRENT_TEMPERATURE );
    
    HEAT_SET_POINT = new Crestron.Logos.SplusObjects.AnalogOutput( HEAT_SET_POINT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( HEAT_SET_POINT__AnalogSerialOutput__, HEAT_SET_POINT );
    
    COOL_SET_POINT = new Crestron.Logos.SplusObjects.AnalogOutput( COOL_SET_POINT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( COOL_SET_POINT__AnalogSerialOutput__, COOL_SET_POINT );
    
    IN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( IN__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( IN__DOLLAR____AnalogSerialInput__, IN__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    
    HEAT_SET_POINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HEAT_SET_POINT_UP_OnPush_0, false ) );
    HEAT_SET_POINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HEAT_SET_POINT_DOWN_OnPush_1, false ) );
    COOL_SET_POINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( COOL_SET_POINT_UP_OnPush_2, false ) );
    COOL_SET_POINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( COOL_SET_POINT_DOWN_OnPush_3, false ) );
    IN__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( IN__DOLLAR___OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_LUTRON_HOMEWORKS_QS_HVAC_CONTROLLER_MODULE_S__R02_CF_MOD ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint HEAT_SET_POINT_UP__DigitalInput__ = 0;
const uint HEAT_SET_POINT_DOWN__DigitalInput__ = 1;
const uint COOL_SET_POINT_UP__DigitalInput__ = 2;
const uint COOL_SET_POINT_DOWN__DigitalInput__ = 3;
const uint INT_ID__AnalogSerialInput__ = 0;
const uint IN__DOLLAR____AnalogSerialInput__ = 1;
const uint CURRENT_TEMPERATURE__AnalogSerialOutput__ = 0;
const uint HEAT_SET_POINT__AnalogSerialOutput__ = 1;
const uint COOL_SET_POINT__AnalogSerialOutput__ = 2;
const uint TX__DOLLAR____AnalogSerialOutput__ = 3;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort HSPINT = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort CSPINT = 0;
            
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}

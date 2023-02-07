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

namespace UserModule_LUTRON_HOMEWORKS_QS_GROUP_FEEDBACK_PROCESSING_MODULE_R02
{
    public class UserModuleClass_LUTRON_HOMEWORKS_QS_GROUP_FEEDBACK_PROCESSING_MODULE_R02 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SHOW_TRACE_MSGS;
        Crestron.Logos.SplusObjects.AnalogInput OFFSET_GROUP;
        Crestron.Logos.SplusObjects.BufferInput FROM_SORTING_MODULE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> INTEGRATION_ID__DOLLAR__;
        object OFFSET_GROUP_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 176;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( OFFSET_GROUP  .UshortValue >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( OFFSET_GROUP  .UshortValue <= 10 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 178;
                    _SplusNVRAM.OFFSET = (ushort) ( ((OFFSET_GROUP  .UshortValue - 1) * 200) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 181;
                    Print( "OFFSET_GROUP VALUE {0:d} IS OUT OF RANGE\r\n", (short)OFFSET_GROUP  .UshortValue) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FROM_SORTING_MODULE__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            CrestronString TEMP__DOLLAR__;
            CrestronString TEMP2__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            TEMP2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            ushort INT_ID = 0;
            ushort INT_ID_OFFSET = 0;
            
            
            __context__.SourceCodeLine = 188;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( FROM_SORTING_MODULE__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "\r\n" , FROM_SORTING_MODULE__DOLLAR__ ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 190;
                TEMP__DOLLAR__  .UpdateValue ( Functions.Gather ( "\r\n" , FROM_SORTING_MODULE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 191;
                if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 192;
                    Trace( "GATHERED={0}\r\n", TEMP__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 193;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~" , TEMP__DOLLAR__ ) == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 195;
                    INT_ID = (ushort) ( Functions.Atoi( TEMP__DOLLAR__ ) ) ; 
                    __context__.SourceCodeLine = 196;
                    INT_ID_OFFSET = (ushort) ( (INT_ID - _SplusNVRAM.OFFSET) ) ; 
                    __context__.SourceCodeLine = 197;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( INTEGRATION_ID__DOLLAR__[ INT_ID_OFFSET ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 199;
                        INTEGRATION_ID__DOLLAR__ [ INT_ID_OFFSET]  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 203;
                        Print( "INTEGRATION ID {0:d} NOT DEFINED ON LUTRON FEEDBACK PROCESSOR\r\n", (short)INT_ID) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 188;
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
        
        __context__.SourceCodeLine = 251;
        Functions.ClearBuffer ( FROM_SORTING_MODULE__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SHOW_TRACE_MSGS = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_TRACE_MSGS__DigitalInput__, this );
    m_DigitalInputList.Add( SHOW_TRACE_MSGS__DigitalInput__, SHOW_TRACE_MSGS );
    
    OFFSET_GROUP = new Crestron.Logos.SplusObjects.AnalogInput( OFFSET_GROUP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( OFFSET_GROUP__AnalogSerialInput__, OFFSET_GROUP );
    
    INTEGRATION_ID__DOLLAR__ = new InOutArray<StringOutput>( 200, this );
    for( uint i = 0; i < 200; i++ )
    {
        INTEGRATION_ID__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( INTEGRATION_ID__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( INTEGRATION_ID__DOLLAR____AnalogSerialOutput__ + i, INTEGRATION_ID__DOLLAR__[i+1] );
    }
    
    FROM_SORTING_MODULE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_SORTING_MODULE__DOLLAR____AnalogSerialInput__, 5000, this );
    m_StringInputList.Add( FROM_SORTING_MODULE__DOLLAR____AnalogSerialInput__, FROM_SORTING_MODULE__DOLLAR__ );
    
    
    OFFSET_GROUP.OnAnalogChange.Add( new InputChangeHandlerWrapper( OFFSET_GROUP_OnChange_0, false ) );
    FROM_SORTING_MODULE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_SORTING_MODULE__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_LUTRON_HOMEWORKS_QS_GROUP_FEEDBACK_PROCESSING_MODULE_R02 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SHOW_TRACE_MSGS__DigitalInput__ = 0;
const uint OFFSET_GROUP__AnalogSerialInput__ = 0;
const uint FROM_SORTING_MODULE__DOLLAR____AnalogSerialInput__ = 1;
const uint INTEGRATION_ID__DOLLAR____AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort OFFSET = 0;
            
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

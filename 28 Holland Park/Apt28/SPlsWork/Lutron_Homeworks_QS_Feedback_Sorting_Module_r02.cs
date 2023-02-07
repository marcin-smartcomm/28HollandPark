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

namespace UserModule_LUTRON_HOMEWORKS_QS_FEEDBACK_SORTING_MODULE_R02
{
    public class UserModuleClass_LUTRON_HOMEWORKS_QS_FEEDBACK_SORTING_MODULE_R02 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SHOW_TRACE_MSGS;
        Crestron.Logos.SplusObjects.BufferInput FROM_CORE_MODULE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ERROR;
        Crestron.Logos.SplusObjects.StringOutput MONITORING__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> INTEGRATION_ID_GROUP__DOLLAR__;
        object FROM_CORE_MODULE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
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
                ushort INT_ID_GROUP = 0;
                ushort ERROR_ID = 0;
                
                
                __context__.SourceCodeLine = 165;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , FROM_CORE_MODULE__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 167;
                    TEMP2__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0000" , FROM_CORE_MODULE__DOLLAR__ )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 169;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "QNET> " , FROM_CORE_MODULE__DOLLAR__ ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "\r\n" , FROM_CORE_MODULE__DOLLAR__ ) == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 171;
                    TEMP2__DOLLAR__  .UpdateValue ( Functions.Remove ( "QNET> " , FROM_CORE_MODULE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 172;
                    if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 173;
                        Trace( "QNET> REMOVED\r\n") ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 175;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( FROM_CORE_MODULE__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "\r\n" , FROM_CORE_MODULE__DOLLAR__ ) > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 177;
                    TEMP__DOLLAR__  .UpdateValue ( Functions.Gather ( "\r\n" , FROM_CORE_MODULE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 178;
                    if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 179;
                        Trace( "GATHERED={0}\r\n", TEMP__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 180;
                    while ( Functions.TestForTrue  ( ( Functions.Find( "QNET> " , TEMP__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 182;
                        TEMP2__DOLLAR__  .UpdateValue ( Functions.Remove ( "QNET> " , TEMP__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 183;
                        if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 184;
                            Trace( "QNET> REMOVED, TEMP$={0}\r\n", TEMP__DOLLAR__ ) ; 
                            }
                        
                        __context__.SourceCodeLine = 180;
                        } 
                    
                    __context__.SourceCodeLine = 186;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~MONITORING" , TEMP__DOLLAR__ ) == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 188;
                        MONITORING__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 190;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~SYSTEM" , TEMP__DOLLAR__ ) == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 193;
                            if ( Functions.TestForTrue  ( ( SHOW_TRACE_MSGS  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 194;
                                Trace( "SYSTEM RESPONSE RECEIVED, TEMP$={0}\r\n", TEMP__DOLLAR__ ) ; 
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 196;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~ERROR" , TEMP__DOLLAR__ ) == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 198;
                                ERROR_ID = (ushort) ( Functions.Atoi( TEMP__DOLLAR__ ) ) ; 
                                __context__.SourceCodeLine = 199;
                                Functions.Pulse ( 10, ERROR [ ERROR_ID] ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 201;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~" , TEMP__DOLLAR__ ) == 1))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 203;
                                    INT_ID = (ushort) ( Functions.Atoi( TEMP__DOLLAR__ ) ) ; 
                                    __context__.SourceCodeLine = 204;
                                    INT_ID_GROUP = (ushort) ( (((INT_ID - 1) / 200) + 1) ) ; 
                                    __context__.SourceCodeLine = 205;
                                    if ( Functions.TestForTrue  ( ( IsSignalDefined( INTEGRATION_ID_GROUP__DOLLAR__[ INT_ID_GROUP ] ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 207;
                                        INTEGRATION_ID_GROUP__DOLLAR__ [ INT_ID_GROUP]  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 211;
                                        Print( "INTEGRATION ID GROUP {0:d} NOT DEFINED ON LUTRON FEEDBACK SORTER\r\n", (short)INT_ID_GROUP) ; 
                                        } 
                                    
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 175;
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
            
            __context__.SourceCodeLine = 259;
            Functions.ClearBuffer ( FROM_CORE_MODULE__DOLLAR__ ) ; 
            
            
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
        
        ERROR = new InOutArray<DigitalOutput>( 5, this );
        for( uint i = 0; i < 5; i++ )
        {
            ERROR[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ERROR__DigitalOutput__ + i, this );
            m_DigitalOutputList.Add( ERROR__DigitalOutput__ + i, ERROR[i+1] );
        }
        
        MONITORING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MONITORING__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MONITORING__DOLLAR____AnalogSerialOutput__, MONITORING__DOLLAR__ );
        
        INTEGRATION_ID_GROUP__DOLLAR__ = new InOutArray<StringOutput>( 10, this );
        for( uint i = 0; i < 10; i++ )
        {
            INTEGRATION_ID_GROUP__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( INTEGRATION_ID_GROUP__DOLLAR____AnalogSerialOutput__ + i, this );
            m_StringOutputList.Add( INTEGRATION_ID_GROUP__DOLLAR____AnalogSerialOutput__ + i, INTEGRATION_ID_GROUP__DOLLAR__[i+1] );
        }
        
        FROM_CORE_MODULE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_CORE_MODULE__DOLLAR____AnalogSerialInput__, 10000, this );
        m_StringInputList.Add( FROM_CORE_MODULE__DOLLAR____AnalogSerialInput__, FROM_CORE_MODULE__DOLLAR__ );
        
        
        FROM_CORE_MODULE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_CORE_MODULE__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_LUTRON_HOMEWORKS_QS_FEEDBACK_SORTING_MODULE_R02 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SHOW_TRACE_MSGS__DigitalInput__ = 0;
    const uint FROM_CORE_MODULE__DOLLAR____AnalogSerialInput__ = 0;
    const uint ERROR__DigitalOutput__ = 0;
    const uint MONITORING__DOLLAR____AnalogSerialOutput__ = 0;
    const uint INTEGRATION_ID_GROUP__DOLLAR____AnalogSerialOutput__ = 1;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
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

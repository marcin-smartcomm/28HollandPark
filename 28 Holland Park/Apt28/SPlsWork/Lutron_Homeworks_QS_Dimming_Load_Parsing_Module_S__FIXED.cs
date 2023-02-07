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

namespace UserModule_LUTRON_HOMEWORKS_QS_DIMMING_LOAD_PARSING_MODULE_S__FIXED
{
    public class UserModuleClass_LUTRON_HOMEWORKS_QS_DIMMING_LOAD_PARSING_MODULE_S__FIXED : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.AnalogInput INT_ID;
        Crestron.Logos.SplusObjects.StringInput IN__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput LEVEL_BAR;
        Crestron.Logos.SplusObjects.StringOutput LEVEL__DOLLAR__;
        object IN__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString TEMP__DOLLAR__;
                CrestronString WHOLE__DOLLAR__;
                TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
                WHOLE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
                
                ushort WHOLE = 0;
                ushort DEC = 0;
                ushort TOTAL = 0;
                ushort LEVEL_BAR_TEMP = 0;
                
                
                __context__.SourceCodeLine = 176;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "~SHADEGRP," , IN__DOLLAR__ ) == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 178;
                    TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "~SHADEGRP," , IN__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 179;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Atoi( IN__DOLLAR__ ) == INT_ID  .UshortValue))  ) ) 
                        { 
                        __context__.SourceCodeLine = 181;
                        TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "," , IN__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 182;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Atoi( IN__DOLLAR__ ) == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 184;
                            TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "," , IN__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 185;
                            TEMP__DOLLAR__  .UpdateValue ( Functions.Left ( IN__DOLLAR__ ,  (int) ( (Functions.Find( "\u000D" , IN__DOLLAR__ ) - 1) ) )  ) ; 
                            __context__.SourceCodeLine = 186;
                            LEVEL__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 187;
                            WHOLE__DOLLAR__  .UpdateValue ( Functions.Remove ( "." , TEMP__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 188;
                            WHOLE = (ushort) ( (Functions.Atoi( WHOLE__DOLLAR__ ) * 100) ) ; 
                            __context__.SourceCodeLine = 189;
                            DEC = (ushort) ( Functions.Atoi( TEMP__DOLLAR__ ) ) ; 
                            __context__.SourceCodeLine = 190;
                            TOTAL = (ushort) ( (WHOLE + DEC) ) ; 
                            __context__.SourceCodeLine = 191;
                            LEVEL_BAR_TEMP = (ushort) ( Functions.MulDiv( (ushort)( TOTAL ) , (ushort)( 65535 ) , (ushort)( 10000 ) ) ) ; 
                            __context__.SourceCodeLine = 192;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( LEVEL_BAR_TEMP > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LEVEL_BAR_TEMP < 65535 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 194;
                                LEVEL_BAR  .Value = (ushort) ( (LEVEL_BAR_TEMP + 1) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 198;
                                LEVEL_BAR  .Value = (ushort) ( LEVEL_BAR_TEMP ) ; 
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
            
            __context__.SourceCodeLine = 247;
            Functions.ClearBuffer ( IN__DOLLAR__ ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        INT_ID = new Crestron.Logos.SplusObjects.AnalogInput( INT_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( INT_ID__AnalogSerialInput__, INT_ID );
        
        LEVEL_BAR = new Crestron.Logos.SplusObjects.AnalogOutput( LEVEL_BAR__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( LEVEL_BAR__AnalogSerialOutput__, LEVEL_BAR );
        
        IN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( IN__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( IN__DOLLAR____AnalogSerialInput__, IN__DOLLAR__ );
        
        LEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LEVEL__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( LEVEL__DOLLAR____AnalogSerialOutput__, LEVEL__DOLLAR__ );
        
        
        IN__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( IN__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_LUTRON_HOMEWORKS_QS_DIMMING_LOAD_PARSING_MODULE_S__FIXED ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint INT_ID__AnalogSerialInput__ = 0;
    const uint IN__DOLLAR____AnalogSerialInput__ = 1;
    const uint LEVEL_BAR__AnalogSerialOutput__ = 0;
    const uint LEVEL__DOLLAR____AnalogSerialOutput__ = 1;
    
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

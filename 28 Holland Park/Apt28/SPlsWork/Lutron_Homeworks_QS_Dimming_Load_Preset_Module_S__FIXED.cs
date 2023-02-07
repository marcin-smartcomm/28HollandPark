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

namespace UserModule_LUTRON_HOMEWORKS_QS_DIMMING_LOAD_PRESET_MODULE_S__FIXED
{
    public class UserModuleClass_LUTRON_HOMEWORKS_QS_DIMMING_LOAD_PRESET_MODULE_S__FIXED : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.AnalogInput INTEGRATION_ID;
        Crestron.Logos.SplusObjects.AnalogInput LEVEL_IN;
        Crestron.Logos.SplusObjects.StringInput DELAY_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput FADE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        object LEVEL_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                ushort J = 0;
                
                
                __context__.SourceCodeLine = 173;
                I = (ushort) ( Functions.MulDiv( (ushort)( LEVEL_IN  .UshortValue ) , (ushort)( 100 ) , (ushort)( 65535 ) ) ) ; 
                __context__.SourceCodeLine = 174;
                J = (ushort) ( (Functions.MulDiv( (ushort)( LEVEL_IN  .UshortValue ) , (ushort)( 10000 ) , (ushort)( 65535 ) ) - (I * 100)) ) ; 
                __context__.SourceCodeLine = 176;
                TX__DOLLAR__  .UpdateValue ( "#SHADEGRP," + Functions.ItoA (  (int) ( INTEGRATION_ID  .UshortValue ) ) + ",1," + Functions.ItoA (  (int) ( I ) ) + "." + Functions.ItoA (  (int) ( J ) ) + "," + FADE_TIME__DOLLAR__ + "," + DELAY_TIME__DOLLAR__ + "\r\n"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        INTEGRATION_ID = new Crestron.Logos.SplusObjects.AnalogInput( INTEGRATION_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( INTEGRATION_ID__AnalogSerialInput__, INTEGRATION_ID );
        
        LEVEL_IN = new Crestron.Logos.SplusObjects.AnalogInput( LEVEL_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LEVEL_IN__AnalogSerialInput__, LEVEL_IN );
        
        DELAY_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DELAY_TIME__DOLLAR____AnalogSerialInput__, 10, this );
        m_StringInputList.Add( DELAY_TIME__DOLLAR____AnalogSerialInput__, DELAY_TIME__DOLLAR__ );
        
        FADE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FADE_TIME__DOLLAR____AnalogSerialInput__, 10, this );
        m_StringInputList.Add( FADE_TIME__DOLLAR____AnalogSerialInput__, FADE_TIME__DOLLAR__ );
        
        TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
        
        
        LEVEL_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( LEVEL_IN_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_LUTRON_HOMEWORKS_QS_DIMMING_LOAD_PRESET_MODULE_S__FIXED ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint INTEGRATION_ID__AnalogSerialInput__ = 0;
    const uint LEVEL_IN__AnalogSerialInput__ = 1;
    const uint DELAY_TIME__DOLLAR____AnalogSerialInput__ = 2;
    const uint FADE_TIME__DOLLAR____AnalogSerialInput__ = 3;
    const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
    
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

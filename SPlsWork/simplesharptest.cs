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
using TestLib;

namespace UserModule_SIMPLESHARPTEST
{
    public class UserModuleClass_SIMPLESHARPTEST : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput B1;
        Crestron.Logos.SplusObjects.DigitalOutput DOUT;
        Crestron.Logos.SplusObjects.StringOutput SOUT;
        TestLib.Test MYTEST;
        object B1_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 15;
                DOUT  .Value = (ushort) ( MYTEST.ReturnInt() ) ; 
                __context__.SourceCodeLine = 16;
                SOUT  .UpdateValue ( MYTEST . ReturnString ( )  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        SocketInfo __socketinfo__ = new SocketInfo( 1, this );
        InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
        _SplusNVRAM = new SplusNVRAM( this );
        
        B1 = new Crestron.Logos.SplusObjects.DigitalInput( B1__DigitalInput__, this );
        m_DigitalInputList.Add( B1__DigitalInput__, B1 );
        
        DOUT = new Crestron.Logos.SplusObjects.DigitalOutput( DOUT__DigitalOutput__, this );
        m_DigitalOutputList.Add( DOUT__DigitalOutput__, DOUT );
        
        SOUT = new Crestron.Logos.SplusObjects.StringOutput( SOUT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( SOUT__AnalogSerialOutput__, SOUT );
        
        
        B1.OnDigitalPush.Add( new InputChangeHandlerWrapper( B1_OnPush_0, true ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        MYTEST  = new TestLib.Test();
        
        
    }
    
    public UserModuleClass_SIMPLESHARPTEST ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint B1__DigitalInput__ = 0;
    const uint DOUT__DigitalOutput__ = 0;
    const uint SOUT__AnalogSerialOutput__ = 0;
    
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

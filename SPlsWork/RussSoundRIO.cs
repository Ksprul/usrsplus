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
using RIO;

namespace UserModule_RUSSSOUNDRIO
{
    public class UserModuleClass_RUSSSOUNDRIO : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput KITCHEN_SELECTSONOS;
        Crestron.Logos.SplusObjects.DigitalInput KITCHEN_SELECTAPPLETV;
        Crestron.Logos.SplusObjects.DigitalInput KITCHEN_OFF;
        Crestron.Logos.SplusObjects.DigitalInput DININGROOM_SELECTSONOS;
        Crestron.Logos.SplusObjects.DigitalInput DININGROOM_SELECTAPPLETV;
        Crestron.Logos.SplusObjects.DigitalInput DININGROOM_OFF;
        Crestron.Logos.SplusObjects.DigitalInput LOGGIA_SELECTSONOS;
        Crestron.Logos.SplusObjects.DigitalInput LOGGIA_SELECTAPPLETV;
        Crestron.Logos.SplusObjects.DigitalInput LOGGIA_OFF;
        Crestron.Logos.SplusObjects.DigitalInput MASTERBEDROOM_SELECTSONOS;
        Crestron.Logos.SplusObjects.DigitalInput MASTERBEDROOM_SELECTAPPLETV;
        Crestron.Logos.SplusObjects.DigitalInput MASTERBEDROOM_OFF;
        Crestron.Logos.SplusObjects.DigitalInput GUESTLOUNGE_SELECTSONOS;
        Crestron.Logos.SplusObjects.DigitalInput GUESTLOUNGE_SELECTAPPLETV;
        Crestron.Logos.SplusObjects.DigitalInput GUESTLOUNGE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput GREATROOM_SELECTSONOS;
        Crestron.Logos.SplusObjects.DigitalInput GREATROOM_SELECTAPPLETV;
        Crestron.Logos.SplusObjects.DigitalInput GREATROOM_OFF;
        Crestron.Logos.SplusObjects.AnalogInput KITCHEN_VOL;
        Crestron.Logos.SplusObjects.AnalogInput DININGROOM_VOL;
        Crestron.Logos.SplusObjects.AnalogInput LOGGIA_VOL;
        Crestron.Logos.SplusObjects.AnalogInput MASTERBEDROOM_VOL;
        Crestron.Logos.SplusObjects.AnalogInput GUESTLOUNGE_VOL;
        Crestron.Logos.SplusObjects.AnalogInput GREATROOM_VOL;
        RIO.Driver MYDRIVER;
        object KITCHEN_SELECTSONOS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 28;
                MYDRIVER . SelectSonos ( (int)( 1 )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object KITCHEN_SELECTAPPLETV_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 29;
            MYDRIVER . SelectAppleTV ( (int)( 1 )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KITCHEN_OFF_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 30;
        MYDRIVER . ZoneOff ( (int)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KITCHEN_VOL_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 31;
        MYDRIVER . SetVolume ( (int)( 1 ), (int)( KITCHEN_VOL  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DININGROOM_SELECTSONOS_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 33;
        MYDRIVER . SelectSonos ( (int)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DININGROOM_SELECTAPPLETV_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 34;
        MYDRIVER . SelectAppleTV ( (int)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DININGROOM_OFF_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 35;
        MYDRIVER . ZoneOff ( (int)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DININGROOM_VOL_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 36;
        MYDRIVER . SetVolume ( (int)( 3 ), (int)( DININGROOM_VOL  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOGGIA_SELECTSONOS_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 38;
        MYDRIVER . SelectSonos ( (int)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOGGIA_SELECTAPPLETV_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 39;
        MYDRIVER . SelectAppleTV ( (int)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOGGIA_OFF_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 40;
        MYDRIVER . ZoneOff ( (int)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOGGIA_VOL_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 41;
        MYDRIVER . SetVolume ( (int)( 4 ), (int)( LOGGIA_VOL  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTERBEDROOM_SELECTSONOS_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 43;
        MYDRIVER . SelectSonos ( (int)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTERBEDROOM_SELECTAPPLETV_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 44;
        MYDRIVER . SelectAppleTV ( (int)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTERBEDROOM_OFF_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 45;
        MYDRIVER . ZoneOff ( (int)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTERBEDROOM_VOL_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 46;
        MYDRIVER . SetVolume ( (int)( 5 ), (int)( MASTERBEDROOM_VOL  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUESTLOUNGE_SELECTSONOS_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 48;
        MYDRIVER . SelectSonos ( (int)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUESTLOUNGE_SELECTAPPLETV_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 49;
        MYDRIVER . SelectAppleTV ( (int)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUESTLOUNGE_OFF_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 50;
        MYDRIVER . ZoneOff ( (int)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUESTLOUNGE_VOL_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 51;
        MYDRIVER . SetVolume ( (int)( 6 ), (int)( GUESTLOUNGE_VOL  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GREATROOM_SELECTSONOS_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 53;
        MYDRIVER . SelectSonos ( (int)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GREATROOM_SELECTAPPLETV_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 54;
        MYDRIVER . SelectAppleTV ( (int)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GREATROOM_OFF_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 55;
        MYDRIVER . ZoneOff ( (int)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GREATROOM_VOL_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 56;
        MYDRIVER . SetVolume ( (int)( 7 ), (int)( GREATROOM_VOL  .IntValue )) ; 
        
        
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
    
    KITCHEN_SELECTSONOS = new Crestron.Logos.SplusObjects.DigitalInput( KITCHEN_SELECTSONOS__DigitalInput__, this );
    m_DigitalInputList.Add( KITCHEN_SELECTSONOS__DigitalInput__, KITCHEN_SELECTSONOS );
    
    KITCHEN_SELECTAPPLETV = new Crestron.Logos.SplusObjects.DigitalInput( KITCHEN_SELECTAPPLETV__DigitalInput__, this );
    m_DigitalInputList.Add( KITCHEN_SELECTAPPLETV__DigitalInput__, KITCHEN_SELECTAPPLETV );
    
    KITCHEN_OFF = new Crestron.Logos.SplusObjects.DigitalInput( KITCHEN_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( KITCHEN_OFF__DigitalInput__, KITCHEN_OFF );
    
    DININGROOM_SELECTSONOS = new Crestron.Logos.SplusObjects.DigitalInput( DININGROOM_SELECTSONOS__DigitalInput__, this );
    m_DigitalInputList.Add( DININGROOM_SELECTSONOS__DigitalInput__, DININGROOM_SELECTSONOS );
    
    DININGROOM_SELECTAPPLETV = new Crestron.Logos.SplusObjects.DigitalInput( DININGROOM_SELECTAPPLETV__DigitalInput__, this );
    m_DigitalInputList.Add( DININGROOM_SELECTAPPLETV__DigitalInput__, DININGROOM_SELECTAPPLETV );
    
    DININGROOM_OFF = new Crestron.Logos.SplusObjects.DigitalInput( DININGROOM_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( DININGROOM_OFF__DigitalInput__, DININGROOM_OFF );
    
    LOGGIA_SELECTSONOS = new Crestron.Logos.SplusObjects.DigitalInput( LOGGIA_SELECTSONOS__DigitalInput__, this );
    m_DigitalInputList.Add( LOGGIA_SELECTSONOS__DigitalInput__, LOGGIA_SELECTSONOS );
    
    LOGGIA_SELECTAPPLETV = new Crestron.Logos.SplusObjects.DigitalInput( LOGGIA_SELECTAPPLETV__DigitalInput__, this );
    m_DigitalInputList.Add( LOGGIA_SELECTAPPLETV__DigitalInput__, LOGGIA_SELECTAPPLETV );
    
    LOGGIA_OFF = new Crestron.Logos.SplusObjects.DigitalInput( LOGGIA_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( LOGGIA_OFF__DigitalInput__, LOGGIA_OFF );
    
    MASTERBEDROOM_SELECTSONOS = new Crestron.Logos.SplusObjects.DigitalInput( MASTERBEDROOM_SELECTSONOS__DigitalInput__, this );
    m_DigitalInputList.Add( MASTERBEDROOM_SELECTSONOS__DigitalInput__, MASTERBEDROOM_SELECTSONOS );
    
    MASTERBEDROOM_SELECTAPPLETV = new Crestron.Logos.SplusObjects.DigitalInput( MASTERBEDROOM_SELECTAPPLETV__DigitalInput__, this );
    m_DigitalInputList.Add( MASTERBEDROOM_SELECTAPPLETV__DigitalInput__, MASTERBEDROOM_SELECTAPPLETV );
    
    MASTERBEDROOM_OFF = new Crestron.Logos.SplusObjects.DigitalInput( MASTERBEDROOM_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( MASTERBEDROOM_OFF__DigitalInput__, MASTERBEDROOM_OFF );
    
    GUESTLOUNGE_SELECTSONOS = new Crestron.Logos.SplusObjects.DigitalInput( GUESTLOUNGE_SELECTSONOS__DigitalInput__, this );
    m_DigitalInputList.Add( GUESTLOUNGE_SELECTSONOS__DigitalInput__, GUESTLOUNGE_SELECTSONOS );
    
    GUESTLOUNGE_SELECTAPPLETV = new Crestron.Logos.SplusObjects.DigitalInput( GUESTLOUNGE_SELECTAPPLETV__DigitalInput__, this );
    m_DigitalInputList.Add( GUESTLOUNGE_SELECTAPPLETV__DigitalInput__, GUESTLOUNGE_SELECTAPPLETV );
    
    GUESTLOUNGE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( GUESTLOUNGE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( GUESTLOUNGE_OFF__DigitalInput__, GUESTLOUNGE_OFF );
    
    GREATROOM_SELECTSONOS = new Crestron.Logos.SplusObjects.DigitalInput( GREATROOM_SELECTSONOS__DigitalInput__, this );
    m_DigitalInputList.Add( GREATROOM_SELECTSONOS__DigitalInput__, GREATROOM_SELECTSONOS );
    
    GREATROOM_SELECTAPPLETV = new Crestron.Logos.SplusObjects.DigitalInput( GREATROOM_SELECTAPPLETV__DigitalInput__, this );
    m_DigitalInputList.Add( GREATROOM_SELECTAPPLETV__DigitalInput__, GREATROOM_SELECTAPPLETV );
    
    GREATROOM_OFF = new Crestron.Logos.SplusObjects.DigitalInput( GREATROOM_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( GREATROOM_OFF__DigitalInput__, GREATROOM_OFF );
    
    KITCHEN_VOL = new Crestron.Logos.SplusObjects.AnalogInput( KITCHEN_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( KITCHEN_VOL__AnalogSerialInput__, KITCHEN_VOL );
    
    DININGROOM_VOL = new Crestron.Logos.SplusObjects.AnalogInput( DININGROOM_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DININGROOM_VOL__AnalogSerialInput__, DININGROOM_VOL );
    
    LOGGIA_VOL = new Crestron.Logos.SplusObjects.AnalogInput( LOGGIA_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( LOGGIA_VOL__AnalogSerialInput__, LOGGIA_VOL );
    
    MASTERBEDROOM_VOL = new Crestron.Logos.SplusObjects.AnalogInput( MASTERBEDROOM_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MASTERBEDROOM_VOL__AnalogSerialInput__, MASTERBEDROOM_VOL );
    
    GUESTLOUNGE_VOL = new Crestron.Logos.SplusObjects.AnalogInput( GUESTLOUNGE_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( GUESTLOUNGE_VOL__AnalogSerialInput__, GUESTLOUNGE_VOL );
    
    GREATROOM_VOL = new Crestron.Logos.SplusObjects.AnalogInput( GREATROOM_VOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( GREATROOM_VOL__AnalogSerialInput__, GREATROOM_VOL );
    
    
    KITCHEN_SELECTSONOS.OnDigitalPush.Add( new InputChangeHandlerWrapper( KITCHEN_SELECTSONOS_OnPush_0, true ) );
    KITCHEN_SELECTAPPLETV.OnDigitalPush.Add( new InputChangeHandlerWrapper( KITCHEN_SELECTAPPLETV_OnPush_1, true ) );
    KITCHEN_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( KITCHEN_OFF_OnPush_2, true ) );
    KITCHEN_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( KITCHEN_VOL_OnChange_3, true ) );
    DININGROOM_SELECTSONOS.OnDigitalPush.Add( new InputChangeHandlerWrapper( DININGROOM_SELECTSONOS_OnPush_4, true ) );
    DININGROOM_SELECTAPPLETV.OnDigitalPush.Add( new InputChangeHandlerWrapper( DININGROOM_SELECTAPPLETV_OnPush_5, true ) );
    DININGROOM_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( DININGROOM_OFF_OnPush_6, true ) );
    DININGROOM_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( DININGROOM_VOL_OnChange_7, true ) );
    LOGGIA_SELECTSONOS.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOGGIA_SELECTSONOS_OnPush_8, true ) );
    LOGGIA_SELECTAPPLETV.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOGGIA_SELECTAPPLETV_OnPush_9, true ) );
    LOGGIA_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOGGIA_OFF_OnPush_10, true ) );
    LOGGIA_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( LOGGIA_VOL_OnChange_11, true ) );
    MASTERBEDROOM_SELECTSONOS.OnDigitalPush.Add( new InputChangeHandlerWrapper( MASTERBEDROOM_SELECTSONOS_OnPush_12, true ) );
    MASTERBEDROOM_SELECTAPPLETV.OnDigitalPush.Add( new InputChangeHandlerWrapper( MASTERBEDROOM_SELECTAPPLETV_OnPush_13, true ) );
    MASTERBEDROOM_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MASTERBEDROOM_OFF_OnPush_14, true ) );
    MASTERBEDROOM_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( MASTERBEDROOM_VOL_OnChange_15, true ) );
    GUESTLOUNGE_SELECTSONOS.OnDigitalPush.Add( new InputChangeHandlerWrapper( GUESTLOUNGE_SELECTSONOS_OnPush_16, true ) );
    GUESTLOUNGE_SELECTAPPLETV.OnDigitalPush.Add( new InputChangeHandlerWrapper( GUESTLOUNGE_SELECTAPPLETV_OnPush_17, true ) );
    GUESTLOUNGE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( GUESTLOUNGE_OFF_OnPush_18, true ) );
    GUESTLOUNGE_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( GUESTLOUNGE_VOL_OnChange_19, true ) );
    GREATROOM_SELECTSONOS.OnDigitalPush.Add( new InputChangeHandlerWrapper( GREATROOM_SELECTSONOS_OnPush_20, true ) );
    GREATROOM_SELECTAPPLETV.OnDigitalPush.Add( new InputChangeHandlerWrapper( GREATROOM_SELECTAPPLETV_OnPush_21, true ) );
    GREATROOM_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( GREATROOM_OFF_OnPush_22, true ) );
    GREATROOM_VOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( GREATROOM_VOL_OnChange_23, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYDRIVER  = new RIO.Driver();
    
    
}

public UserModuleClass_RUSSSOUNDRIO ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint KITCHEN_SELECTSONOS__DigitalInput__ = 0;
const uint KITCHEN_SELECTAPPLETV__DigitalInput__ = 1;
const uint KITCHEN_OFF__DigitalInput__ = 2;
const uint DININGROOM_SELECTSONOS__DigitalInput__ = 3;
const uint DININGROOM_SELECTAPPLETV__DigitalInput__ = 4;
const uint DININGROOM_OFF__DigitalInput__ = 5;
const uint LOGGIA_SELECTSONOS__DigitalInput__ = 6;
const uint LOGGIA_SELECTAPPLETV__DigitalInput__ = 7;
const uint LOGGIA_OFF__DigitalInput__ = 8;
const uint MASTERBEDROOM_SELECTSONOS__DigitalInput__ = 9;
const uint MASTERBEDROOM_SELECTAPPLETV__DigitalInput__ = 10;
const uint MASTERBEDROOM_OFF__DigitalInput__ = 11;
const uint GUESTLOUNGE_SELECTSONOS__DigitalInput__ = 12;
const uint GUESTLOUNGE_SELECTAPPLETV__DigitalInput__ = 13;
const uint GUESTLOUNGE_OFF__DigitalInput__ = 14;
const uint GREATROOM_SELECTSONOS__DigitalInput__ = 15;
const uint GREATROOM_SELECTAPPLETV__DigitalInput__ = 16;
const uint GREATROOM_OFF__DigitalInput__ = 17;
const uint KITCHEN_VOL__AnalogSerialInput__ = 0;
const uint DININGROOM_VOL__AnalogSerialInput__ = 1;
const uint LOGGIA_VOL__AnalogSerialInput__ = 2;
const uint MASTERBEDROOM_VOL__AnalogSerialInput__ = 3;
const uint GUESTLOUNGE_VOL__AnalogSerialInput__ = 4;
const uint GREATROOM_VOL__AnalogSerialInput__ = 5;

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

using PressSdk.CodeGenerators.Abstract.Patterns.SeDefinitions;
using SE.ErrorsDefinitions.ErrorEvents.Enums;
using static SE.ErrorsDefinitions.ErrorEvents.Enums.ErrorEnumerations;

namespace SE.ErrorsDefinitions.ErrorEvents
{
    [ErrorEvent]
    [Description("No communication with aSID temperature sensor")]
    [Extension(nameof(ErrorEventExtension.EventHelper))]
    [Classification(nameof(ErrorEventClassification.AsidEvents))]
    [WhatToDo("Verify sensor wiring are not damaged")]
    [SuspectedCause("Sensor malfunction or damaged wiring")]
    [EventTrigger("aSID temperature sensor communication has timed-out")]
    public class ASID_IR_MLX_COMM_FAILURE
    {
        [SensorIDParam]
        public SensorID1 Sensor { get; }
	
		[SensorIDParam1]
        public SensorID2 Sensor1 { get; }
	
	    [Param("DspErrorBits", ParamMapping.IntParam1, ParamUnit.NoUnits)]
        public int DspErrorBits { get; }

        [Param("DspStatusFlags", ParamMapping.IntParam2, ParamUnit.NoUnits)]
        public int DspStatusFlags { get; }
		
		[AppParam("High limit value", ParamUnit.NoUnits)]
        public int HighLimitValue { get; set; }
		
        [AppParam("Actual Value ", ParamUnit.NoUnits)]
        public int ActualValue { get; set; }
    }
}

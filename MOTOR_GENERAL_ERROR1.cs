
using PressSdk.CodeGenerators.Abstract.Patterns.SeDefinitions;
using SE.ErrorsDefinitions.ErrorEvents.Enums;
using static SE.ErrorsDefinitions.ErrorEvents.Enums.ErrorEnumerations;

namespace SE.ErrorsDefinitions.ErrorEvents
{
    [ErrorEvent]
    [Description("Motor drive general error")]
    [Extension(nameof(ErrorEventExtension.EventHelper))]
    [Classification(nameof(ErrorEventClassification.MotorEvents))]
    [WhatToDo("")]
    [SuspectedCause("Verify vendor error code for more details")]
    [EventTrigger("")]
    public class MOTOR_GENERAL_ERROR
    {
        [MotorIDParam]
        public MotorID Motor { get; }

        [VendorNameIDParam]
        public VendorNameID VendorNameID { get; }

        [VendorErrorCodeParam]
        public VendorErrorCode VendorErrorCode { get; }

    }
}

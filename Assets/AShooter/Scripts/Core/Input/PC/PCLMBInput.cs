﻿using Abstracts;
using UniRx;


namespace Core
{

    internal sealed class PCLMBInput : ISubjectInputProxy<Unit>
    {

        public Subject<Unit> AxisOnChange { get; } = new();


        public PCLMBInput(InputConfig config)
        {
            config.Mouse.LBM.performed += context => AxisOnChange.OnNext(Unit.Default);
        }
        
        
    }
}
﻿using System.Collections.Generic;
using System.Linq;

using ShiftCo.ifmo_ca_lab_3.Evaluation.Interfaces;

namespace ShiftCo.ifmo_ca_lab_3.Evaluation.Expressions
{
    public abstract class Expression : IOperand
    {
        public List<IOperand> Operands { get; set; }
        public List<IAttribute> Attributes { get; set; }
        public abstract void Evaluate();

        public bool IsPrimitive() => (Operands.Count == 1) ? true : false;

        public void RemovePrimitives()
        {
            var var = Operands.Where(o => ((Expression)o).IsPrimitive());
            var varr = var.Select(o => ((Expression)o).Operands.First());
            /*Operands.Concat(var);
            Operands.RemoveAll(o => o is Expression && ((Expression)o).IsPrimitive());*/
        }
    }
}
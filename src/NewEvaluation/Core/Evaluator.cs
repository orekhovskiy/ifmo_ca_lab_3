﻿using System;
using ShiftCo.ifmo_ca_lab_3.Commons;
using ShiftCo.ifmo_ca_lab_3.Commons.Exceptions;
using ShiftCo.ifmo_ca_lab_3.NewEvaluation.Interfaces;
using ShiftCo.ifmo_ca_lab_3.NewEvaluation.Types;
using ShiftCo.ifmo_ca_lab_3.NewEvaluation.Types.Atoms;

namespace ShiftCo.ifmo_ca_lab_3.NewEvaluation.Core
{
    public static class Evaluator
    {
        private const int EvaluationRunsLimit = 100000;
        private static int s_evaluationRuns;

        public static IElement Run(IElement element)
        {
            s_evaluationRuns = 0;
            return Evaluate(element);
        }

        private static IElement Evaluate(IElement elementToEvaluate)
        {
            if (s_evaluationRuns == EvaluationRunsLimit)
            {
                throw new TooManyIterationsException();
            }
            IElement evaluatedElement;
            switch (elementToEvaluate)
            {
                case Integer elementAsInteger:
                    evaluatedElement = EvaluateInteger(elementAsInteger);
                    break;
                case Symbol elementAsSymbol:
                    evaluatedElement = EvaluateSymbol(elementAsSymbol);
                    break;
                case Expression elementAsExpression:
                    evaluatedElement = EvaluateExpression(elementAsExpression);
                    break;
                default:
                    return elementToEvaluate;
            }

            s_evaluationRuns++;
            return ElementNotChanged(elementToEvaluate, evaluatedElement)
                ? evaluatedElement
                : Evaluate(evaluatedElement);
        }

        private static IElement EvaluateInteger(Integer integer)
        {
            throw new NotImplementedException();
        }

        private static IElement EvaluateSymbol(Symbol symbol)
        {
            throw new NotImplementedException();
        }

        private static IElement EvaluateExpression(Expression expression)
        {
            throw new NotImplementedException();
        }

        private static bool ElementNotChanged(IElement initialElement, IElement evaluatedElement)
        {
            return initialElement.Equals(evaluatedElement);
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"GroversAlgorithm\",\"Name\":\"SearchForMarkedInput\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" This operation applies Grover's algorithm to search all possible inputs\",\" to an operation to find a particular marked state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"GroversAlgorithm\",\"Name\":\"SearchForMarkedInput\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"GroversAlgorithm\",\"Name\":\"NIterations\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Returns the number of Grover iterations needed to find a single marked\",\" item, given the number of qubits in a register.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"GroversAlgorithm\",\"Name\":\"NIterations\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
#line hidden
namespace GroversAlgorithm
{
    [SourceLocation("C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs", OperationFunctor.Body, 10, 29)]
    public partial class SearchForMarkedInput : Operation<Int64, IQArray<Result>>, ICallable
    {
        public SearchForMarkedInput(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SearchForMarkedInput";
        String ICallable.FullName => "GroversAlgorithm.SearchForMarkedInput";
        public static OperationInfo<Int64, IQArray<Result>> Info => new OperationInfo<Int64, IQArray<Result>>(typeof(SearchForMarkedInput));
        protected ICallable<Int64, Int64> NIterations
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> PrepareUniform
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectAboutMarked
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectAboutUniform
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysForEach
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<Int64, IQArray<Result>> Body => (__in__) =>
        {
            var nQubits = __in__;
#line hidden
            {
#line 11 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
                var qubits = Allocate.Apply(nQubits);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 13 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
                    PrepareUniform.Apply(qubits);
#line 17 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
                    foreach (var idxIteration in new QRange(0L, (NIterations.Apply(nQubits) - 1L)))
#line hidden
                    {
#line 18 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
                        ReflectAboutMarked.Apply(qubits);
#line 19 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
                        ReflectAboutUniform.Apply(qubits);
                    }

#line 22 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
                    return MicrosoftQuantumArraysForEach.Apply<IQArray<Result>>((MicrosoftQuantumMeasurementMResetZ, qubits));
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(qubits);
                    }
                }
            }
        }

        ;
        public override void Init()
        {
            this.NIterations = this.Factory.Get<ICallable<Int64, Int64>>(typeof(NIterations));
            this.PrepareUniform = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareUniform));
            this.ReflectAboutMarked = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectAboutMarked));
            this.ReflectAboutUniform = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectAboutUniform));
            this.MicrosoftQuantumArraysForEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.ForEach<,>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<SearchForMarkedInput, Int64, IQArray<Result>>(nQubits);
        }
    }

    [SourceLocation("C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs", OperationFunctor.Body, 29, -1)]
    public partial class NIterations : Function<Int64, Int64>, ICallable
    {
        public NIterations(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NIterations";
        String ICallable.FullName => "GroversAlgorithm.NIterations";
        public static OperationInfo<Int64, Int64> Info => new OperationInfo<Int64, Int64>(typeof(NIterations));
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathArcSin
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumMathRound
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var nQubits = __in__;
#line 30 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
            var nItems = (1L << (int)nQubits);
#line 32 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
            var angle = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(nItems))));
#line 33 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
            var nIterations = MicrosoftQuantumMathRound.Apply((((0.25D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / angle) - 0.5D));
#line 34 "C:/Users/Chuck/Desktop/Module%206%20-%20Additional%20QA/Code/C%23/QSharp%20-%20Getting%20Started/GroversAlgorithm/Grover.qs"
            return nIterations;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcSin));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.MicrosoftQuantumMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Math.Round));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<NIterations, Int64, Int64>(nQubits);
        }
    }
}
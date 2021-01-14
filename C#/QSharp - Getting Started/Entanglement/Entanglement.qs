namespace Quantum.Entanglement
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
    operation Entanglement () : (Result, Result) {
        mutable qubitOneState = Zero;
        mutable qubitTwoState = Zero;
        using ((qubitOne, qubitTwo) = (Qubit(), Qubit())) {
            H(qubitOne);
            CNOT(qubitOne, qubitTwo);

            set qubitOneState = M(qubitOne);
            set qubitTwoState = M(qubitTwo);

            Reset(qubitOne);
            Reset(qubitTwo);
		}

        return (qubitOneState, qubitTwoState);
    }
}

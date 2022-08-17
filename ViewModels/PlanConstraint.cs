

using ESAPIX.Constraints;
using Prism.Mvvm;

namespace ESAPX_StarterUI.ViewModels
{
    public class PlanConstraint : BindableBase
    {


        public PlanConstraint(IConstraint constraint)
        {
            this.constraint = constraint;
        }

        private IConstraint _constraint;
        public IConstraint Constraint
        {
            get { return _constraint; }
            set { SetProperty(ref _constraint, value); }
        }

        private ConstraintResult _result;
        private IConstraint constraint;

        public ConstraintResult Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }
    }
}
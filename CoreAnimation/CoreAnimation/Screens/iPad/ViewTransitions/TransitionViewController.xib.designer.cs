// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_CoreAnimation.Screens.iPad.ViewTransitions {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("TransitionViewController")]
	public partial class TransitionViewController {
		
		private MonoTouch.UIKit.UIView _mt_view;
		
		private MonoTouch.UIKit.UIButton _mt_btnTransition;
		
		private MonoTouch.UIKit.UISegmentedControl _mt_sgmntTransitionType;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				 _mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return  _mt_view;
			}
			set {
				 _mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnTransition")]
		private MonoTouch.UIKit.UIButton btnTransition {
			get {
				 _mt_btnTransition = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnTransition")));
				return  _mt_btnTransition;
			}
			set {
				 _mt_btnTransition = value;
				this.SetNativeField("btnTransition", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("sgmntTransitionType")]
		private MonoTouch.UIKit.UISegmentedControl sgmntTransitionType {
			get {
				 _mt_sgmntTransitionType = ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("sgmntTransitionType")));
				return  _mt_sgmntTransitionType;
			}
			set {
				 _mt_sgmntTransitionType = value;
				this.SetNativeField("sgmntTransitionType", value);
			}
		}
	}
}

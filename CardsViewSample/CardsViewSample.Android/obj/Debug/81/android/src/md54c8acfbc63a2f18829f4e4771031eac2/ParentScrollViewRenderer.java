package md54c8acfbc63a2f18829f4e4771031eac2;


public class ParentScrollViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ScrollViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInterceptTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnInterceptTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("PanCardView.Droid.ParentScrollViewRenderer, PanCardView.Droid", ParentScrollViewRenderer.class, __md_methods);
	}


	public ParentScrollViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ParentScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("PanCardView.Droid.ParentScrollViewRenderer, PanCardView.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ParentScrollViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ParentScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("PanCardView.Droid.ParentScrollViewRenderer, PanCardView.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ParentScrollViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ParentScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("PanCardView.Droid.ParentScrollViewRenderer, PanCardView.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ParentScrollViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ParentScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("PanCardView.Droid.ParentScrollViewRenderer, PanCardView.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public boolean onInterceptTouchEvent (android.view.MotionEvent p0)
	{
		return n_onInterceptTouchEvent (p0);
	}

	private native boolean n_onInterceptTouchEvent (android.view.MotionEvent p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

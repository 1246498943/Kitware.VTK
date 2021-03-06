using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRungeKutta4 : vtkInitialValueProblemSolver
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRungeKutta4";

		public new static readonly string MRClassNameKey;

		static vtkRungeKutta4()
		{
			vtkRungeKutta4.MRClassNameKey = "class vtkRungeKutta4";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRungeKutta4.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRungeKutta4"));
		}

		public vtkRungeKutta4(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkRungeKutta4_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRungeKutta4 New()
		{
			vtkRungeKutta4 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRungeKutta4.vtkRungeKutta4_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRungeKutta4() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRungeKutta4.vtkRungeKutta4_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRungeKutta4_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_01(base.GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRungeKutta4_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_02(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRungeKutta4_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

		public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_03(base.GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRungeKutta4_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

		public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
		{
			return vtkRungeKutta4.vtkRungeKutta4_ComputeNextStep_04(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRungeKutta4_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRungeKutta4.vtkRungeKutta4_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkRungeKutta4_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRungeKutta4.vtkRungeKutta4_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkRungeKutta4_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRungeKutta4 NewInstance()
		{
			vtkRungeKutta4 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRungeKutta4.vtkRungeKutta4_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRungeKutta4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkRungeKutta4_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRungeKutta4 SafeDownCast(vtkObjectBase o)
		{
			vtkRungeKutta4 vtkRungeKutta = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRungeKutta4.vtkRungeKutta4_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRungeKutta = (vtkRungeKutta4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRungeKutta.Register(null);
				}
			}
			return vtkRungeKutta;
		}
	}
}

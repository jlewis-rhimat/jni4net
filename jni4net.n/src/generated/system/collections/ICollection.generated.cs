//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Collections {
    
    
    #region Component Designer generated code 
    public partial class ICollection_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Collections.@__ICollection.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Collections.ICollection))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Collections.ICollection))]
    internal sealed partial class @__ICollection : global::java.lang.Object, global::System.Collections.ICollection {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetEnumerator0;
        
        internal static global::net.sf.jni4net.jni.MethodId _CopyTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _Count2;
        
        internal static global::net.sf.jni4net.jni.MethodId _SyncRoot3;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsSynchronized4;
        
        protected @__ICollection(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public int Count {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return env.CallIntMethod(this, global::System.Collections.@__ICollection._Count2);
            }
        }
        
        public object SyncRoot {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.J2C<object>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__ICollection._SyncRoot3));
            }
        }
        
        public bool IsSynchronized {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return env.CallBooleanMethod(this, global::System.Collections.@__ICollection._IsSynchronized4);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Collections.@__ICollection.staticClass = staticClass;
            global::System.Collections.@__ICollection._GetEnumerator0 = env.GetMethodID(global::System.Collections.@__ICollection.staticClass, "GetEnumerator", "()Lsystem/collections/IEnumerator;");
            global::System.Collections.@__ICollection._CopyTo1 = env.GetMethodID(global::System.Collections.@__ICollection.staticClass, "CopyTo", "(Lsystem/Array;I)V");
            global::System.Collections.@__ICollection._Count2 = env.GetMethodID(global::System.Collections.@__ICollection.staticClass, "getCount", "()I");
            global::System.Collections.@__ICollection._SyncRoot3 = env.GetMethodID(global::System.Collections.@__ICollection.staticClass, "getSyncRoot", "()Lsystem/Object;");
            global::System.Collections.@__ICollection._IsSynchronized4 = env.GetMethodID(global::System.Collections.@__ICollection.staticClass, "isSynchronized", "()Z");
        }
        
        public global::System.Collections.IEnumerator GetEnumerator() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IEnumerator>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__ICollection._GetEnumerator0));
        }
        
        public void CopyTo(global::System.Array array, int index) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::System.Collections.@__ICollection._CopyTo1, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, array), global::net.sf.jni4net.utils.Convertor.ParamC2J(env, index));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__ICollection);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetEnumerator", "GetEnumerator0", "()Lsystem/collections/IEnumerator;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CopyTo", "CopyTo1", "(Lsystem/Array;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCount", "Count2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getSyncRoot", "SyncRoot3", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isSynchronized", "IsSynchronized4", "()Z"));
            return methods;
        }
        
        private static global::System.IntPtr GetEnumerator0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/IEnumerator;
            // ()LSystem/Collections/IEnumerator;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.ICollection real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.ICollection>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, ((global::System.Collections.IEnumerable)(real)).GetEnumerator());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void CopyTo1(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr array, int index) {
            // (Lsystem/Array;I)V
            // (LSystem/Array;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.ICollection real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.ICollection>(__env, @__obj);
            real.CopyTo(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Array>(__env, array), index);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static int Count2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.ICollection real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.ICollection>(__env, @__obj);
            return real.Count;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr SyncRoot3(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.ICollection real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.ICollection>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.SyncRoot);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsSynchronized4(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.ICollection real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.ICollection>(__env, @__obj);
            return real.IsSynchronized;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Collections.@__ICollection(env);
            }
        }
    }
    #endregion
}

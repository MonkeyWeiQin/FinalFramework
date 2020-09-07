﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirClient_Component_CPrefabVarWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FirClient.Component.CPrefabVar), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetVarArray", GetVarArray);
		L.RegFunction("GetVarNameByType", GetVarNameByType);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("varData", get_varData, set_varData);
		L.RegVar("varTypes", get_varTypes, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVarArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirClient.Component.CPrefabVar obj = (FirClient.Component.CPrefabVar)ToLua.CheckObject<FirClient.Component.CPrefabVar>(L, 1);
			FirClient.Component.VarData[] o = obj.GetVarArray();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVarNameByType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FirClient.Component.CPrefabVar obj = (FirClient.Component.CPrefabVar)ToLua.CheckObject<FirClient.Component.CPrefabVar>(L, 1);
			FirClient.Component.VarType arg0 = (FirClient.Component.VarType)ToLua.CheckObject(L, 2, typeof(FirClient.Component.VarType));
			string o = obj.GetVarNameByType(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_varData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.Component.CPrefabVar obj = (FirClient.Component.CPrefabVar)o;
			System.Collections.Generic.List<FirClient.Component.VarData> ret = obj.varData;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index varData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_varTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.Component.CPrefabVar obj = (FirClient.Component.CPrefabVar)o;
			System.Collections.Generic.List<string> ret = obj.varTypes;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index varTypes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_varData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.Component.CPrefabVar obj = (FirClient.Component.CPrefabVar)o;
			System.Collections.Generic.List<FirClient.Component.VarData> arg0 = (System.Collections.Generic.List<FirClient.Component.VarData>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<FirClient.Component.VarData>));
			obj.varData = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index varData on a nil value");
		}
	}
}

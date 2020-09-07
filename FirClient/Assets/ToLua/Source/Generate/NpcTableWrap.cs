﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NpcTableWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NpcTable), typeof(System.Object));
		L.RegFunction("Initialize", Initialize);
		L.RegFunction("GetItems", GetItems);
		L.RegFunction("AddItem", AddItem);
		L.RegFunction("GetItemByKey", GetItemByKey);
		L.RegFunction("New", _CreateNpcTable);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("name", get_name, set_name);
		L.RegVar("Items", get_Items, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNpcTable(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NpcTable obj = new NpcTable();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NpcTable.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NpcTable obj = (NpcTable)ToLua.CheckObject<NpcTable>(L, 1);
			obj.Initialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItems(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NpcTable obj = (NpcTable)ToLua.CheckObject<NpcTable>(L, 1);
			System.Collections.Generic.List<NpcTableItem> o = obj.GetItems();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NpcTable obj = (NpcTable)ToLua.CheckObject<NpcTable>(L, 1);
			NpcTableItem arg0 = (NpcTableItem)ToLua.CheckObject<NpcTableItem>(L, 2);
			obj.AddItem(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItemByKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NpcTable obj = (NpcTable)ToLua.CheckObject<NpcTable>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			NpcTableItem o = obj.GetItemByKey(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NpcTable obj = (NpcTable)o;
			string ret = obj.name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Items(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NpcTable obj = (NpcTable)o;
			System.Collections.Generic.List<NpcTableItem> ret = obj.Items;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Items on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NpcTable obj = (NpcTable)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.name = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}
}

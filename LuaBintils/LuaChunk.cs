﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LuaBin {
	public class LuaChunk {
		public Header Header;
		public List<Function> Functions;

		private LuaChunk()  {
			Functions = new List<Function>();
		}

		public LuaChunk(string Path)
			: this() {
			BinaryReader BR = new BinaryReader(File.OpenRead(Path));
			Header = new Header(BR);
			Functions.Add(new Function(BR));
			BR.Close();
		}

		public LuaChunk(Header H)
			: this() {
			Header = H;
			if (H == null)
				Header = new Header();
		}

		public LuaChunk(params Function[] Funcs)
			: this(null, Funcs) {
		}

		public LuaChunk(Header H, params Function[] Funcs)
			: this(H) {
			if (Funcs != null)
				for (int i = 0; i < Funcs.Length; i++)
					Functions.Add(Funcs[i]);
		}

		public Function CreateFunction(byte MaxStackSize = 0, string SrcName = "CODE") {
			Function F = new Function();
			F.Src = SrcName;
			F.MaxStackSize = MaxStackSize;
			Functions.Add(F);
			return F;
		}

		public void Save(string Path) {
			BinaryWriter W = BeginSave(Path);

			this.Header.Save(W);
			foreach (Function Func in Functions)
				Func.Save(W);

			W.Flush();
			W.Close();
		}

		public static BinaryWriter BeginSave(string Path) {
			if (File.Exists(Path))
				File.Delete(Path);
			return new BinaryWriter(File.OpenWrite(Path));
		}
	}
}
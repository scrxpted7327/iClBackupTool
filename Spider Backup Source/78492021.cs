using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

public class _78492021
{
	private static class _43C37435
	{
		public unsafe static object _4C4C6650(void* _23C87CDD)
		{
			uint num = 1177556255u;
			num *= 1700805135;
			num >>= 6;
			Type? typeFromHandle = typeof(void*);
			num = 154490247 * num;
			return Pointer.Box(_23C87CDD, typeFromHandle);
		}

		public unsafe static void* _47E848A9(object _1AE342EE)
		{
			uint num = 105390908u;
			return Pointer.Unbox(_1AE342EE);
		}
	}

	private sealed class _255C6EDC
	{
		private enum _18447280
		{
			_0C6A6743 = 30,
			_7527549F = 9,
			_2D794519 = 0,
			_3FE251F7 = 4,
			_7E1C5571 = 6,
			_73574869 = 24,
			_2D963ED6 = 14,
			_3EED008E = 29,
			_1DA96951 = 28,
			_02A15245 = 5,
			_1F4E1845 = 8,
			_11572DB0 = 69,
			_67AA5B98 = 25,
			_6D6D3580 = 65,
			_513E1C13 = 19,
			_33964E73 = 26,
			_3D5E470C = 27,
			_27E6481A = 23,
			_29E45D42 = 1,
			_192902E0 = 20,
			_4F256908 = 21,
			_0E793748 = 22,
			_5A241FA6 = 11,
			_73104276 = 16,
			_170631FC = 12,
			_345A1BF1 = 31,
			_1FC61068 = 10,
			_064E58A7 = 3,
			_632A25EA = 15,
			_41FF5F32 = 32,
			_17F64E86 = 18,
			_126E3159 = 17,
			_705F0CEA = 13,
			_63A36EDA = 2,
			_21C24351 = 7
		}

		private int _1D947319;

		private byte[] _1FAD46FA;

		public Type _7563392E(Module _0AA86156)
		{
			while (true)
			{
				uint num = 136647452u;
				int num2 = (int)num + -136647452;
				num -= 1971083040;
				bool flag = (byte)num2 != 0;
				while (true)
				{
					num += 297166635;
					bool flag2 = (byte)(num + 1537268954) != 0;
					while (true)
					{
						num <<= 22;
						_18447280 _78492022;
						if (!flag2)
						{
							num ^= 0x70CB78EA;
							_78492022 = (_18447280)_77660A65();
							_18447280 num3 = _78492022;
							num ^= 0x3D415C87;
							Type type;
							bool num10;
							switch (num3)
							{
							default:
								num ^= 0;
								goto case _18447280._73104276;
							case _18447280._2D794519:
								num *= 496375259;
								num <<= 31;
								type = null;
								if (1296960574 * num != 0)
								{
									continue;
								}
								goto IL_082a;
							case _18447280._29E45D42:
							{
								num |= 0x350205C0;
								Type? typeFromHandle2 = typeof(void);
								num ^= 0x4F26282F;
								type = typeFromHandle2;
								num ^= 0x7A6C0DC2;
								goto IL_082a;
							}
							case _18447280._63A36EDA:
							{
								num %= 250571394;
								Type? typeFromHandle = typeof(bool);
								num |= 0x7B7C3013;
								type = typeFromHandle;
								if (num * 1806640633 == 0)
								{
									break;
								}
								num ^= 0xFFFEF05Fu;
								goto IL_082a;
							}
							case _18447280._064E58A7:
							{
								num = 0x4D497349 & num;
								if (num == 793661405)
								{
									goto end_IL_001a;
								}
								num *= 331035831;
								Type? typeFromHandle7 = typeof(char);
								num -= 357569138;
								type = typeFromHandle7;
								num ^= 0x2120D5BD;
								goto IL_082a;
							}
							case _18447280._3FE251F7:
								if (num * 1296912582 == 0)
								{
									break;
								}
								num *= 903894357;
								type = typeof(sbyte);
								if (173373887 == num)
								{
									goto end_IL_001a;
								}
								num ^= 0x7B164931;
								goto IL_082a;
							case _18447280._02A15245:
								num ^= 0x4CC2373B;
								type = typeof(byte);
								num += 3078089898u;
								goto IL_082a;
							case _18447280._7E1C5571:
								num += 429944872;
								type = typeof(short);
								if (num < 446241317)
								{
									break;
								}
								num ^= 0x1DEA9495;
								goto IL_082a;
							case _18447280._21C24351:
								num &= 0x58166A45;
								type = typeof(ushort);
								if (822817608 / num == 0)
								{
									goto end_IL_001a;
								}
								num ^= 0x80022045u;
								goto IL_082a;
							case _18447280._1F4E1845:
								if (num == 1004352167)
								{
									goto IL_0068;
								}
								num = 686888306 - num;
								type = typeof(int);
								num ^= 0x24A6F105;
								goto IL_082a;
							case _18447280._7527549F:
							{
								num = 1306349412 / num;
								if ((num ^ 0x96539CD) == 0)
								{
									break;
								}
								num -= 662380951;
								Type? typeFromHandle6 = typeof(uint);
								num = 203765786 / num;
								type = typeFromHandle6;
								if (145556727 <= num)
								{
									goto end_IL_001a;
								}
								num += 2147483648u;
								goto IL_082a;
							}
							case _18447280._1FC61068:
								type = typeof(long);
								if ((0x2F5D6ED3 & num) == 0)
								{
									break;
								}
								num ^= 0x44A246D;
								goto IL_082a;
							case _18447280._5A241FA6:
								num = 295586539 + num;
								type = typeof(ulong);
								if (1933080472 > num)
								{
									goto IL_0033;
								}
								num ^= 0x15E86F58;
								goto IL_082a;
							case _18447280._170631FC:
							{
								num >>= 4;
								Type? typeFromHandle5 = typeof(float);
								num = 0x33BF3C24 | num;
								type = typeFromHandle5;
								num += 1140867482;
								goto IL_082a;
							}
							case _18447280._705F0CEA:
								num ^= 0xADA0757;
								type = typeof(double);
								num += 4050640070u;
								goto IL_082a;
							case _18447280._73574869:
							{
								num <<= 28;
								Type? typeFromHandle4 = typeof(IntPtr);
								num = 0x33AA5460 ^ num;
								type = typeFromHandle4;
								num += 2622860192u;
								goto IL_082a;
							}
							case _18447280._67AA5B98:
								num = 2135644887 * num;
								if (1568609952 * num == 0)
								{
									goto IL_0068;
								}
								type = typeof(UIntPtr);
								num += 2516457077u;
								goto IL_082a;
							case _18447280._2D963ED6:
								num ^= 0x31E852DE;
								type = typeof(string);
								num ^= 0x35A276B3;
								goto IL_082a;
							case _18447280._1DA96951:
							{
								num = 0x4B0C7BD3 ^ num;
								if (num - 139798128 == 0)
								{
									goto end_IL_001a;
								}
								num /= 1187668428;
								Type? typeFromHandle3 = typeof(object);
								num |= 0x1D341BB5;
								type = typeFromHandle3;
								num += 1657529417;
								goto IL_082a;
							}
							case _18447280._126E3159:
							case _18447280._17F64E86:
							{
								if ((0xEBF5F97 ^ num) == 0)
								{
									goto end_IL_001a;
								}
								num += 1539446189;
								uint num4 = _77660A65();
								num = (uint)(2033409223 << (int)num);
								if (num > 788272959)
								{
									goto end_IL_001a;
								}
								int num5 = (int)num4 & ((int)num + -469762045);
								num *= 939727839;
								uint num6 = (uint)num5;
								num >>= 4;
								if (1405226943 >>> (int)num == 0)
								{
									goto end_IL_001a;
								}
								uint num7;
								uint num8;
								uint num9;
								Type type2;
								switch (num6)
								{
								case 0u:
									num += 1739080733;
									num7 = num ^ 0x6FE8441D;
									goto IL_0728;
								case 1u:
									num ^= 0x47E10A39;
									num7 = num + 3210671559u;
									if (num * 1916491736 == 0)
									{
										break;
									}
									num += 742865380;
									goto IL_0728;
								case 2u:
									num7 = num + 348127232;
									num ^= 0x6BA8441D;
									goto IL_0728;
								default:
									{
										num7 = num ^ 0x6400000;
										num += 1739080733;
										goto IL_0728;
									}
									IL_0728:
									num = 1621522033 - num;
									num8 = num7;
									num9 = num4 >> (int)(num ^ 0xF2BE3256u);
									num = 711798492 % num;
									type2 = _0AA86156.ResolveType((int)(num8 | num9));
									num = 2147095150 / num;
									type = type2;
									if (num == 363626100)
									{
										goto IL_0033;
									}
									goto IL_0766;
								}
								break;
							}
							case _18447280._632A25EA:
								num /= 2125409396;
								if (num == 1679705142)
								{
									goto IL_0033;
								}
								num = 722745730 - num;
								num = 0x4979486A & num;
								type = _7563392E(_0AA86156).MakePointerType();
								if ((num ^ 0x220E4F50) == 0)
								{
									goto end_IL_001a;
								}
								num ^= 0x89100800u;
								goto IL_082a;
							case _18447280._3EED008E:
								num ^= 0x402B1384;
								if (1847203108 > num)
								{
									break;
								}
								num <<= 9;
								type = _7563392E(_0AA86156).MakeArrayType();
								if (num << 12 == 0)
								{
									goto end_IL_001a;
								}
								num += 3180342784u;
								goto IL_082a;
							case _18447280._73104276:
							case _18447280._513E1C13:
							case _18447280._192902E0:
							case _18447280._4F256908:
							case _18447280._0E793748:
							case _18447280._27E6481A:
							case _18447280._33964E73:
							case _18447280._3D5E470C:
								{
									int errorCode = (int)num + -70717990;
									num += 704137907;
									throw new COMException(null, errorCode);
								}
								IL_0766:
								num ^= 0x80000003u;
								goto IL_082a;
								IL_082a:
								if (num >> 10 == 0)
								{
									goto end_IL_001a;
								}
								num10 = flag;
								num = 1404708779 + num;
								if (num10)
								{
									num = 947926218 - num;
									if (1221945469 > num)
									{
										break;
									}
									Type type3 = type;
									num = 0x661106BC ^ num;
									Type type4 = type3.MakeByRefType();
									num = 1871643844 % num;
									type = type4;
									num ^= 0xD3761944u;
								}
								return type;
							}
							break;
						}
						goto IL_0033;
						IL_00b1:
						num = (uint)(354315158 << (int)num);
						_18447280 num11 = _78492022;
						num = 0x4DE3641C | num;
						int num12 = (int)num ^ -840735651;
						num %= 1487691733;
						num += 2278850229u;
						if (num11 == (_18447280)num12)
						{
							continue;
						}
						num *= 1682267147;
						if (num == 721570807)
						{
							goto end_IL_001a;
						}
						_18447280 num13 = _78492022;
						int num14 = (int)num ^ -163871000;
						num += 1546392674;
						num += 1375176728;
						if (num13 == (_18447280)num14)
						{
							continue;
						}
						num ^= 0xD950DFF;
						goto IL_019c;
						IL_0033:
						byte num15 = _692043BB();
						num = 1352217654u;
						_78492022 = (_18447280)num15;
						num = 1410020263 + num;
						if ((int)_78492022 <= (int)num - -1532729411)
						{
							if ((num ^ 0x2AD70934) == 0)
							{
								break;
							}
							goto IL_0068;
						}
						goto IL_00b1;
						IL_019c:
						int num16 = (int)num - -1446367528;
						num /= 1676246827;
						flag2 = (byte)num16 != 0;
						num <<= 11;
						int num17 = _1D947319;
						num *= 1749382390;
						int num18 = num17 - (int)(num - 732409855);
						num = 0x17A70505 & num;
						_1D947319 = num18;
						num += 2696422183u;
						continue;
						IL_0068:
						_18447280 num19 = _78492022;
						int num20 = (int)num ^ -1532729395;
						num ^= 0xD6E4905;
						if (num19 != (_18447280)num20)
						{
							if ((uint)((int)_78492022 - (int)(num + 1446367559)) > (num ^ 0xA9CA2ED9u))
							{
								if (575801726 << (int)num == 0)
								{
									goto IL_00b1;
								}
								goto IL_019c;
							}
							num >>= 26;
							if ((num ^ 0x21930A19) == 0)
							{
								goto end_IL_001a;
							}
							num -= 283845592;
							_77660A65();
							if (691739807 * num == 0)
							{
								goto end_IL_001a;
							}
							num ^= 0x4B4BFF75;
							continue;
						}
						int num21 = (int)num ^ -1446367527;
						num ^= 0x14A067C1;
						flag = (byte)num21 != 0;
						num ^= 0x19356A3E;
					}
					continue;
					end_IL_001a:
					break;
				}
			}
		}

		public uint _77660A65()
		{
			uint num = 1391135577u;
			if (num * 1029006440 != 0)
			{
				goto IL_0012;
			}
			goto IL_02ed;
			IL_0012:
			uint result = default(uint);
			while (true)
			{
				IL_0012_2:
				num ^= 0x315411C2;
				byte[] array = _1FAD46FA;
				num -= 1484470218;
				byte b = array[_1D947319];
				while ((b & (num - 188998225)) != 0)
				{
					num = 0x55611681 ^ num;
					if (1398029896 == num)
					{
						goto IL_0012_2;
					}
					num <<= 2;
					if ((b & (num - 2022428928)) == 0)
					{
						goto IL_00f3;
					}
					num &= 0x35324BC2;
					byte[] array2 = _1FAD46FA;
					num |= 0x411231CD;
					byte num2 = array2[_1D947319];
					num = 737807943 + num;
					uint num3 = num2 & (num ^ 0x9D0C800Bu);
					num ^= 0x71E04964;
					uint num4 = num3 << (int)(num ^ 0xECECC968u);
					num -= 306264757;
					byte[] array3 = _1FAD46FA;
					num %= 617813842;
					num = 0x30D35A76 | num;
					int num5 = _1D947319;
					num = 1621523830 * num;
					byte num6 = array3[num5 + (int)(num ^ 0xCB49CDDBu)];
					num /= 2051045709;
					int num7 = num6 << (int)num - -15;
					num /= 1295792753;
					int num8 = (int)num4 + num7;
					byte[] array4 = _1FAD46FA;
					num >>= 7;
					num >>= 1;
					int num9 = _1D947319;
					num = (uint)(594159355 << (int)num);
					int num10 = array4[num9 + ((int)num + -594159353)] << (int)(num ^ 0x236A26F3);
					num %= 1993242174;
					int num11 = num8 + num10;
					num -= 1019302408;
					byte[] array5 = _1FAD46FA;
					int num12 = _1D947319;
					num = 0xEA4707E | num;
					int num13 = num12 + (int)(num ^ 0xEEACF4FCu);
					num &= 0x6F092619;
					byte num14 = array5[num13];
					num &= 0x34862A55;
					result = (uint)(num11 + num14);
					if (num <= 306131731)
					{
						continue;
					}
					goto IL_02c9;
				}
				num = (uint)(1974748146 << (int)num);
				if (num % 1261182863 != 0)
				{
					do
					{
						num = 2074544694 + num;
						byte[] array6 = _1FAD46FA;
						num = 0x3BD13A4C | num;
						int num15 = _1D947319;
						num *= 2064197281;
						byte num16 = array6[num15];
						num += 607068849;
						int num17 = (int)num ^ -332685424;
						num <<= 17;
						int num18 = num16 & num17;
						num <<= 10;
						result = (uint)num18;
					}
					while (2025082857 <= num);
					num ^= 0x32DE0B16;
					_1D947319 += (int)(num - 1256065813);
					break;
				}
				continue;
				IL_00f3:
				byte num19 = _1FAD46FA[_1D947319];
				num *= 1459429527;
				uint num20 = num + 522163071;
				num = 0x7B15FA2 | num;
				uint num21 = num19 & num20;
				uint num22 = num + 403603494;
				num ^= 0x6B3E0E10;
				uint num23 = num21 << (int)num22;
				byte[] array7 = _1FAD46FA;
				num = 981943587u >> (int)num;
				num = 0x54D92B08 ^ num;
				int num24 = _1D947319;
				num = 0x45832A9A ^ num;
				int num25 = (int)num + -291114802;
				num = 0x23BB02B5 & num;
				result = num23 + array7[num24 + num25];
				num = 0x25BF718A & num;
				num = (uint)(397955070 << (int)num);
				int num26 = _1D947319;
				num ^= 0x7CAC09C2;
				int num27 = num26 + (int)(num - 1796490810);
				num ^= 0xFDB61AC;
				_1D947319 = num27;
				if (num >> 13 != 0)
				{
					num += 3859735430u;
					break;
				}
				continue;
				IL_02c9:
				int num28 = _1D947319;
				num = 1987531783 * num;
				_1D947319 = num28 + (int)(num + 999459725);
				num ^= 0x8EB37F61u;
				break;
			}
			goto IL_02ed;
			IL_02ed:
			num ^= 0x4DB7238E;
			if (num > 16646818)
			{
				return result;
			}
			goto IL_0012;
		}

		public byte _692043BB()
		{
			uint num = 1267148921u;
			byte[] array = _1FAD46FA;
			num = 1852712464u >> (int)num;
			num = 572224975 * num;
			num = (uint)(1552113838 << (int)num);
			int num2 = _1D947319;
			num += 1415580423;
			int num3 = num2;
			num = 43786899 * num;
			num |= 0x16D900F2;
			_1D947319 = num3 + ((int)num - -554089482);
			num = 2090224909 + num;
			num = (uint)(1591351632 << (int)num);
			return array[num3];
		}

		public _255C6EDC(byte[] _4B6E1BB1)
		{
			uint num;
			do
			{
				base._002Ector();
				num = 1379291935u;
			}
			while (num <= 958098588);
			do
			{
				num /= 552748719;
				num ^= 0x3D2610E6;
				_1FAD46FA = _4B6E1BB1;
			}
			while (378102535 * num == 0);
		}
	}

	private enum _4F9431A9
	{
		_6CA800CE = 32,
		_6CFB4607 = 6,
		_5BDC0A64 = 16,
		_75E4388B = 2,
		_61CD5054 = 0,
		_4C0C306E = 11,
		_345A2E51 = 5,
		_246A7697 = 3,
		_0158412B = 10,
		_759E7FF6 = 64,
		_1F8723F3 = 8,
		_508433C8 = 4,
		_4BC50860 = 1,
		_27096716 = 7,
		_46822E71 = 15,
		_753D317F = 9
	}

	private sealed class _0D4C6B37
	{
		private Type _65747F54;

		private uint _00AA7F38;

		private Type[] _6D8C4F87;

		private _4F9431A9 _21E50451;

		public Type _16871E65 => _65747F54;

		public CallingConvention _347C390F
		{
			get
			{
				uint num = 129200553u;
				num = 0x4CD80B97 | num;
				_4F9431A9 num2 = _21E50451;
				num = 2055422857 + num;
				int num3 = (int)num2 & (int)(num ^ 0xCA7EBF47u);
				num *= 1124617540;
				_4F9431A9 _4F9431A10 = (_4F9431A9)num3;
				num = 0x67491EB8 & num;
				uint num4 = num ^ 0x23411621;
				num = 0x447835D9 ^ num;
				int num5 = (int)_4F9431A10 - (int)num4;
				num %= 1066756437;
				switch (num5)
				{
				default:
					if (num < 829521404)
					{
						return (CallingConvention)((int)num + -665041571);
					}
					goto case 2;
				case 0:
					num = 1652120663 - num;
					return (CallingConvention)(num - 987079089);
				case 1:
					return (CallingConvention)(num - 665041569);
				case 2:
					num = 105735694u >> (int)num;
					return (CallingConvention)((int)num + -6608476);
				case 3:
					num += 1377313866;
					return (CallingConvention)(num ^ 0x79BBDEEB);
				}
			}
		}

		public bool _27023992
		{
			get
			{
				uint num = 564947546u;
				_4F9431A9 _4F9431A10 = (_4F9431A9)((int)_21E50451 & ((int)num + -564947531));
				while (true)
				{
					switch (_4F9431A10)
					{
					default:
						goto IL_004b;
					case _4F9431A9._61CD5054:
					case _4F9431A9._4BC50860:
					case _4F9431A9._75E4388B:
					case _4F9431A9._246A7697:
					case _4F9431A9._508433C8:
					case _4F9431A9._345A2E51:
					case _4F9431A9._753D317F:
					case _4F9431A9._4C0C306E:
						return (byte)(num - 564947545) != 0;
					case _4F9431A9._6CFB4607:
					case _4F9431A9._27096716:
					case _4F9431A9._1F8723F3:
					case _4F9431A9._0158412B:
						break;
					}
					break;
					IL_004b:
					if (1113615295 - num != 0)
					{
						num ^= 0;
						break;
					}
				}
				return (byte)(num ^ 0x21AC6A5A) != 0;
			}
		}

		public _0D4C6B37()
		{
			if (553348218 != 476330694)
			{
				base._002Ector();
			}
		}

		public void _11100F8E(byte[] _34756DF0, Module _14D94A03)
		{
			uint num;
			do
			{
				IL_0000:
				_255C6EDC _255C6EDC2 = new _255C6EDC(_34756DF0);
				num = 301662721u;
				num = 0x2EB5CEE & num;
				byte num2 = _255C6EDC2._692043BB();
				num >>= 2;
				_21E50451 = (_4F9431A9)num2;
				if (num >= 1415530769)
				{
					goto IL_0000;
				}
				num >>= 14;
				int num3 = (int)_21E50451 & ((int)num + -219);
				num = 0x9BB3BD9 ^ num;
				if (num3 != 0)
				{
					num *= 217864083;
					if ((num & 0x699764C4) == 0)
					{
						goto IL_0000;
					}
					goto IL_007b;
				}
				goto IL_00ac;
				IL_021e:
				if ((0x635F52AC ^ num) != 0)
				{
					num &= 0x3EAD4D91;
					num = 1843733916u >> (int)num;
					Type type = _255C6EDC2._7563392E(_14D94A03);
					num = (uint)(1469123072 << (int)num);
					_65747F54 = type;
					return;
				}
				goto IL_0000;
				IL_012d:
				num /= 980567310;
				uint num4 = _255C6EDC2._77660A65();
				num = 595022130 % num;
				num &= 0x7CE82180;
				num *= 1673137708;
				_65747F54 = _255C6EDC2._7563392E(_14D94A03);
				num <<= 27;
				num += 1175149793;
				_6D8C4F87 = new Type[num4];
				uint num5 = num - 1175149793;
				num = 1287389197 * num;
				int num6 = (int)num5;
				if (num - 381817671 != 0)
				{
					while (true)
					{
						num = 0x6DB36B06 ^ num;
						if ((num ^ 0x2AFD4E06) == 0)
						{
							break;
						}
						if (num6 < num4)
						{
							Type[] array = _6D8C4F87;
							int num7 = num6;
							num = 306581325u;
							num = 1067480544 + num;
							Type type2 = _255C6EDC2._7563392E(_14D94A03);
							num <<= 28;
							array[num7] = type2;
							num6 += (int)(num ^ 0xD0000001u);
							num += 3218061165u;
							continue;
						}
						if ((num ^ 0x51073A38) == 0)
						{
							break;
						}
						return;
					}
					goto IL_0000;
				}
				goto IL_007b;
				IL_00ac:
				num = 799898971u >> (int)num;
				_4F9431A9 num8 = _21E50451;
				uint num9 = num - 3036;
				num = (uint)(1313227766 << (int)num);
				_4F9431A9 _4F9431A10 = (_4F9431A9)((int)num8 & (int)num9);
				num = 0x62414DE9 ^ num;
				switch (_4F9431A10)
				{
				case _4F9431A9._61CD5054:
				case _4F9431A9._4BC50860:
				case _4F9431A9._75E4388B:
				case _4F9431A9._246A7697:
				case _4F9431A9._508433C8:
				case _4F9431A9._345A2E51:
				case _4F9431A9._1F8723F3:
				case _4F9431A9._753D317F:
				case _4F9431A9._4C0C306E:
					goto IL_012d;
				case _4F9431A9._6CFB4607:
					goto IL_021e;
				case _4F9431A9._27096716:
				case _4F9431A9._0158412B:
					goto IL_0264;
				}
				continue;
				IL_0264:
				num = 939805607 / num;
				uint num10 = _255C6EDC2._77660A65();
				num = 919686329 * num;
				uint num11 = num10;
				_6D8C4F87 = new Type[num11];
				num <<= 25;
				uint num12 = num + 0;
				num >>= 0;
				int num13 = (int)num12;
				if (num * 1993825259 == 0)
				{
					while (true)
					{
						int num14 = num13;
						num %= 1683431287;
						long num15 = num14;
						num = 0x5C67299C ^ num;
						long num16 = num11;
						num >>= 28;
						if (num15 < num16)
						{
							num = 1984525500u;
							Type[] array2 = _6D8C4F87;
							num <<= 5;
							int num17 = num13;
							num = (uint)(1137974859 << (int)num);
							num = 0x1A0E3AD3 ^ num;
							Type type3 = _255C6EDC2._7563392E(_14D94A03);
							num = 1833640567 + num;
							array2[num17] = type3;
							int num18 = num13;
							num <<= 9;
							uint num19 = num ^ 0x4A8E1E01;
							num += 450258349;
							int num20 = num18 + (int)num19;
							num *= 216092725;
							num13 = num20;
							num ^= 0x3E0252D1;
							continue;
						}
						break;
					}
					return;
				}
				goto IL_0000;
				IL_007b:
				num = (uint)(1419919531 << (int)num);
				uint num21 = _255C6EDC2._77660A65();
				num = 1035279192 % num;
				_00AA7F38 = num21;
				num ^= 0x1B4E206A;
				goto IL_00ac;
			}
			while (868118754 == num || num % 1503608000 == 0);
			throw new COMException(null, (int)num ^ -800198704);
		}

		public Type[] _181E08D4()
		{
			uint num = 1015493964u;
			return _6D8C4F87;
		}
	}

	private sealed class _4E2E44B6 : IDisposable
	{
		private List<GCHandle> _49280C3D;

		public void Dispose()
		{
			uint num = 951069974u;
			List<GCHandle>.Enumerator enumerator = _49280C3D.GetEnumerator();
			num = 45242571u >> (int)num;
			using (List<GCHandle>.Enumerator enumerator2 = enumerator)
			{
				if (num >= 81219286)
				{
					goto IL_0030;
				}
				goto IL_0066;
				IL_0066:
				num = (uint)(426919320 << (int)num);
				bool num2 = enumerator2.MoveNext();
				num >>= 20;
				if (num2 || num % 372721817 == 0)
				{
					goto IL_0030;
				}
				goto end_IL_0020;
				IL_0030:
				GCHandle current = enumerator2.Current;
				num = 1431401462u;
				if (1905736411 > num)
				{
					num = (uint)(1442889 << (int)num);
					current.Free();
					num ^= 0x1240000A;
				}
				goto IL_0066;
				end_IL_0020:;
			}
			num = 1386037633u;
			_49280C3D.Clear();
		}

		public _4E2E44B6()
		{
			uint num = 899511858u;
			List<GCHandle> list = new List<GCHandle>();
			num = 745820502 + num;
			_49280C3D = list;
			if (406925278u >> (int)num != 0)
			{
				do
				{
					num = 0x76F54B72 | num;
					base._002Ector();
				}
				while (num << 16 == 0);
			}
		}

		public IntPtr _33CD5A83(object _01001C0B)
		{
			uint num = 1648643117u;
			num = 0x9772102 | num;
			GCHandle gCHandle = GCHandle.Alloc(_01001C0B, (GCHandleType)(num ^ 0x6B776D2C));
			num = 0x1BB56FC9 & num;
			GCHandle item = gCHandle;
			num %= 791942840;
			num %= 2085581914;
			_49280C3D.Add(item);
			num = 0x500B4232 & num;
			num += 231299703;
			return item.AddrOfPinnedObject();
		}
	}

	private abstract class _582960B3
	{
		public virtual char _52B43B98()
		{
			return Convert.ToChar(_0936516D());
		}

		public abstract object _0936516D();

		public virtual IntPtr _47C01150()
		{
			uint num = 373450340u;
			object obj = default(object);
			if ((0x3A83238A ^ num) != 0)
			{
				num = 765733370 % num;
				obj = _0936516D();
			}
			while (true)
			{
				object obj2;
				if (obj == null)
				{
					obj2 = null;
				}
				else
				{
					object obj3 = obj;
					num &= 0x597333C6;
					obj2 = obj3.GetType();
					num += 805936;
				}
				num -= 1622476512;
				num = 479149161 + num;
				Type? typeFromHandle = typeof(IntPtr);
				num >>= 9;
				bool num2 = (Type?)obj2 == typeFromHandle;
				num += 1620382117;
				if (!num2)
				{
					break;
				}
				if ((0x636C3AEA ^ num) != 0)
				{
					object obj4 = obj;
					num %= 2048860423;
					return (IntPtr)obj4;
				}
			}
			throw new InvalidOperationException();
		}

		public virtual sbyte _22B70934()
		{
			object value = _0936516D();
			uint num = 297159425u;
			return Convert.ToSByte(value);
		}

		public virtual ushort _16D4371A()
		{
			uint num = 1048655721u;
			object value = _0936516D();
			num = 1857362387u >> (int)num;
			return Convert.ToUInt16(value);
		}

		public virtual UIntPtr _15842C84()
		{
			object obj;
			object obj2;
			uint num;
			while (true)
			{
				obj = _0936516D();
				if (obj == null)
				{
					num = 1912681663u;
					if (692464606 != num)
					{
						obj2 = null;
						break;
					}
					continue;
				}
				obj2 = obj.GetType();
				num = 1912681663u;
				break;
			}
			num = 124794245 + num;
			if ((Type?)obj2 == typeof(UIntPtr))
			{
				num = 0xDFE0CBB & num;
				return (UIntPtr)obj;
			}
			num = 1247157119 * num;
			throw new InvalidOperationException();
		}

		public virtual double _40F966AC()
		{
			uint num = 2138786572u;
			object value = _0936516D();
			num = 0x6A8F6051 ^ num;
			return Convert.ToDouble(value);
		}

		public virtual long _3E0F495D()
		{
			uint num = 900292389u;
			object value = _0936516D();
			num -= 1416779666;
			return Convert.ToInt64(value);
		}

		protected _582960B3()
		{
			uint num = 1729634037u;
			do
			{
				base._002Ector();
			}
			while (num - 984161053 == 0);
		}

		public virtual short _72435997()
		{
			uint num = 361772612u;
			return Convert.ToInt16(_0936516D());
		}

		public virtual uint _76377E70()
		{
			object value = _0936516D();
			uint num = 1960386981u;
			return Convert.ToUInt32(value);
		}

		public virtual TypeCode _09A801C9()
		{
			uint num = 643064019u;
			throw new InvalidOperationException();
		}

		public virtual object _7BBC17CC(Type _009510E7, bool _49543A54)
		{
			throw new InvalidOperationException();
		}

		public override string ToString()
		{
			object obj2;
			uint num;
			do
			{
				num = 1009272543u;
				object obj = _0936516D();
				num |= 0x4A642613;
				obj2 = obj;
				num <<= 24;
				if (num / 801788473 != 0)
				{
					num = (uint)(1121915270 << (int)num);
					if (obj2 == null && (num & 0x6DF81C08) != 0)
					{
						return null;
					}
				}
				num = 1749700897 / num;
			}
			while (571552432 < num);
			num &= 0x34775FA1;
			return Convert.ToString(obj2);
		}

		public virtual void _53112B56(FieldInfo _552E4502, object _568E5844)
		{
			uint num;
			do
			{
				object obj = _0936516D();
				num = 1035091822u;
				_552E4502.SetValue(obj, _568E5844);
			}
			while (num >= 1133341230);
		}

		public unsafe virtual void* _1AF75EB9()
		{
			throw new InvalidOperationException();
		}

		public virtual bool _27B26B78()
		{
			uint num = 1634023091u;
			object value = _0936516D();
			num &= 0x20F1437;
			return Convert.ToBoolean(value);
		}

		public virtual Type _71C820E4()
		{
			uint num = 2075802818u;
			throw new InvalidOperationException();
		}

		public virtual _76587E10 _689700D4()
		{
			uint num = 904080931u;
			throw new InvalidOperationException();
		}

		public virtual ulong _5ECF32BD()
		{
			uint num = 471728828u;
			return Convert.ToUInt64(_0936516D());
		}

		public virtual float _078008FE()
		{
			uint num = 1226850953u;
			object value = _0936516D();
			num |= 0x339A38F1;
			return Convert.ToSingle(value);
		}

		public virtual byte _70DF711E()
		{
			uint num = 640884848u;
			return Convert.ToByte(_0936516D());
		}

		public virtual bool _11EF2F40()
		{
			return false;
		}

		public virtual int _6AAF062D()
		{
			uint num = 357828081u;
			return Convert.ToInt32(_0936516D());
		}

		public abstract void _727F3897(object _63C53445);

		public virtual _582960B3 _2ED37583()
		{
			uint num = 646985492u;
			return this;
		}

		public abstract _582960B3 _5C7710FF();
	}

	private abstract class _76587E10 : _582960B3
	{
		public override TypeCode _09A801C9()
		{
			return TypeCode.Empty;
		}

		protected _76587E10()
		{
			uint num = 453065172u;
			do
			{
				num = 283519059 * num;
				base._002Ector();
			}
			while (num - 1927900018 == 0);
		}

		public override _76587E10 _689700D4()
		{
			uint num = 864173365u;
			return this;
		}
	}

	private sealed class _50424ADC : _76587E10
	{
		private int _4C62753A;

		public static _582960B3 _27EB338E(_582960B3 _3AEE0AEA, _582960B3 _49C030CC)
		{
			int num = _3AEE0AEA._6AAF062D();
			uint num2 = 330833141u;
			num2 = 0x52A08DA | num2;
			int num3 = _49C030CC._6AAF062D();
			num2 %= 998052276;
			int num4 = num3;
			num2 /= 150826571;
			return new _50424ADC(num & num4);
		}

		public static _582960B3 _159F3DF0(_582960B3 _412D6EEB, _582960B3 _7AC04306, bool _66110BC7, bool _26D34717)
		{
			uint num = 1510163580u;
			uint num3 = default(uint);
			int _7A3475AA;
			uint num8 = default(uint);
			while (true)
			{
				if (_26D34717)
				{
					num = 0x7D9F6FDB & num;
					if (566898914 == num)
					{
						continue;
					}
					num = 898258671 * num;
					uint num2 = _412D6EEB._76377E70();
					num = 0xDD96241 & num;
					num3 = num2;
					goto IL_0036;
				}
				num = 0x2F3F4F41 & num;
				num = 0x3E025FB | num;
				int num4 = _412D6EEB._6AAF062D();
				num = 0x6A454EB5 ^ num;
				num = 0x68773952 ^ num;
				int num5 = _7AC04306._6AAF062D();
				num *= 1027091156;
				num <<= 19;
				int num6;
				if (!_66110BC7)
				{
					num6 = num4 * num5;
				}
				else
				{
					num >>= 21;
					if ((0x4DF47F17 ^ num) == 0)
					{
						continue;
					}
					num = 775387170 / num;
					num6 = checked(num4 * num5);
					num += 3111651070u;
				}
				_7A3475AA = num6;
				num += 1501671326;
				goto IL_0134;
				IL_0053:
				if (_66110BC7)
				{
					goto IL_0075;
				}
				num = 1176125684 + num;
				if (470444190 * num == 0)
				{
					continue;
				}
				int num7 = (int)(num3 * num8);
				goto IL_009a;
				IL_0134:
				num += 901136494;
				if ((num ^ 0x3AF3A13) != 0)
				{
					break;
				}
				goto IL_0075;
				IL_0075:
				if (num - 1229150974 == 0)
				{
					goto IL_0036;
				}
				uint num9 = num3;
				num = 2119981759u >> (int)num;
				num7 = (int)checked(num9 * num8);
				num += 414418318;
				goto IL_009a;
				IL_009a:
				num = 733296042 - num;
				_7A3475AA = num7;
				if (num == 1170896318)
				{
					goto IL_0053;
				}
				goto IL_0134;
				IL_0036:
				num = 315047177u >> (int)num;
				uint num10 = _7AC04306._76377E70();
				num = 441875032 * num;
				num8 = num10;
				goto IL_0053;
			}
			return new _50424ADC(_7A3475AA);
		}

		public override sbyte _22B70934()
		{
			uint num = 650210262u;
			return (sbyte)_4C62753A;
		}

		public static _582960B3 _011B4C33(_582960B3 _10407C5D, _582960B3 _50EC797A, bool _7A5200B2, bool _299036EB)
		{
			int _7A3475AA;
			uint num7 = default(uint);
			uint num;
			do
			{
				IL_0000:
				num = 2104963348u;
				if (_299036EB)
				{
					num >>= 13;
				}
				else
				{
					num = 603979788 + num;
					int num2 = _10407C5D._6AAF062D();
					num = (uint)(241188767 << (int)num);
					if (num <= 1393910375)
					{
						num &= 0x5C7E01B2;
						int num3 = _50EC797A._6AAF062D();
						num += 2087914630;
						int num4 = num3;
						if (num != 2036223128)
						{
							num = 0x38954ACE | num;
							int num5;
							if (!_7A5200B2)
							{
								if (1616602554 == num)
								{
									goto IL_0000;
								}
								num = 365038782 + num;
								num5 = num2 - num4;
							}
							else
							{
								if (num <= 856501958)
								{
									goto IL_0036;
								}
								num ^= 0x6EB9495C;
								num5 = checked(num2 - num4);
								num ^= 0x18F75C1E;
							}
							num <<= 24;
							_7A3475AA = num5;
							num ^= 0x9C080000u;
							continue;
						}
					}
				}
				uint num6 = _10407C5D._76377E70();
				num %= 829184649;
				num7 = num6;
				if (num >> 18 != 0)
				{
					goto IL_0000;
				}
				goto IL_0036;
				IL_00b2:
				num <<= 19;
				int num8;
				_7A3475AA = num8;
				if (num >= 416900177)
				{
					goto IL_0000;
				}
				continue;
				IL_0036:
				num = 321481227 * num;
				uint num9 = _50EC797A._76377E70();
				num %= 1148792708;
				uint num10 = num9;
				num = 502093411 / num;
				if ((num ^ 0x53421BF6) == 0)
				{
					goto IL_0000;
				}
				if (!_7A5200B2)
				{
					if (395597614 * num == 0)
					{
						goto IL_0000;
					}
				}
				else
				{
					num = 13632849 / num;
					if (num < 1683643380)
					{
						uint num11 = num7;
						num = 0x57892D6A | num;
						num8 = (int)checked(num11 - num10);
						num ^= 0x57D92D7A;
						goto IL_00b2;
					}
				}
				num8 = (int)(num7 - num10);
				goto IL_00b2;
			}
			while (num << 18 != 0);
			return new _50424ADC(_7A3475AA);
		}

		public static _582960B3 _12535A29(_582960B3 _03295CEE, _582960B3 _01D17384, bool _588529A7)
		{
			uint num = 325542060u;
			while (_588529A7)
			{
				if (num / 1724199221 == 0)
				{
					uint num2 = _03295CEE._76377E70();
					uint num3 = _01D17384._76377E70();
					num = 1288138893 + num;
					uint num4 = num3;
					num *= 510722280;
					num |= 0x46014F64;
					uint _7A3475AA = num2 % num4;
					num &= 0x65A30DFF;
					return new _50424ADC((int)_7A3475AA);
				}
			}
			num += 1845973564;
			int num5 = _03295CEE._6AAF062D();
			num |= 0x23B47B3;
			int num6 = _01D17384._6AAF062D();
			num |= 0x60031691;
			num = 0x48907B02 & num;
			int _7A3475AA2 = num5 % num6;
			num |= 0xBF93CFF;
			return new _50424ADC(_7A3475AA2);
		}

		public override ushort _16D4371A()
		{
			return (ushort)_4C62753A;
		}

		public override float _078008FE()
		{
			uint num = 1466986348u;
			num &= 0x41603BED;
			int num2 = _4C62753A;
			num = 1822457623 + num;
			return num2;
		}

		public override long _3E0F495D()
		{
			uint num = 1758746832u;
			return _4C62753A;
		}

		public override TypeCode _09A801C9()
		{
			uint num = 1829307500u;
			return (TypeCode)(num - 1829307491);
		}

		public static _582960B3 _42BB5CB8(_582960B3 _6A802D26, _582960B3 _2FD37962)
		{
			uint num = 137062877u;
			int num2 = _6A802D26._6AAF062D();
			num = 842687478u >> (int)num;
			int num3 = _2FD37962._6AAF062D();
			num %= 2119900292;
			int num4 = num3 & (int)(num ^ 0x1E);
			num %= 1556175550;
			return new _50424ADC(num2 << num4);
		}

		public override object _7BBC17CC(Type _539F5D1A, bool _01467757)
		{
			double num13;
			while (true)
			{
				uint num = 164432192u;
				bool num2 = _539F5D1A == typeof(IntPtr);
				num += 624238337;
				if (num2)
				{
					num ^= 0x6EDC6657;
				}
				else if (458703097 % num != 0)
				{
					num = 0x354762C0 ^ num;
					bool num3 = _539F5D1A == typeof(UIntPtr);
					num += 990780879;
					if (num3)
					{
						num /= 1828006252;
						int value;
						if (!_01467757)
						{
							if (num * 2007313033 != 0)
							{
								goto IL_002b;
							}
							num = 708051306 - num;
							value = (int)checked((uint)_4C62753A);
						}
						else
						{
							if (75763021 << (int)num == 0)
							{
								continue;
							}
							value = _4C62753A;
							num += 708051306;
						}
						num *= 636748665;
						return new UIntPtr((uint)value);
					}
					if (2098994951 <= num)
					{
						continue;
					}
					num = 0x67D1FB8 ^ num;
					TypeCode typeCode = Type.GetTypeCode(_539F5D1A);
					num *= 1651199100;
					TypeCode typeCode2 = typeCode;
					num = 1386810048 * num;
					int num4 = (int)typeCode2 - (int)(num ^ 0xDF230805u);
					num = (uint)(1480465229 << (int)num);
					switch (num4)
					{
					default:
						num += 0;
						goto case 8;
					case 0:
						break;
					case 2:
						goto IL_02bf;
					case 4:
					{
						num += 1490749017;
						int num7;
						if (!_01467757)
						{
							num &= 0x17A16D59;
							num7 = _4C62753A;
						}
						else
						{
							num = 0x3873D55 | num;
							uint num8 = checked((uint)_4C62753A);
							num += 1067006566;
							num7 = checked((int)num8);
							num ^= 0xE239595Du;
						}
						return num7;
					}
					case 6:
						goto IL_0359;
					case 1:
						goto IL_03c1;
					case 3:
					{
						num = 323572255 / num;
						num %= 44453241;
						int num5;
						if (!_01467757)
						{
							num = (uint)(296363812 << (int)num);
							num = (uint)(1805536194 << (int)num);
							num5 = checked((ushort)_4C62753A);
						}
						else
						{
							num *= 1750750514;
							num *= 596737295;
							uint num6 = checked((uint)_4C62753A);
							num = 729636282u >> (int)num;
							num5 = checked((ushort)num6);
							num += 2389139046u;
						}
						return (ushort)num5;
					}
					case 5:
						goto IL_0492;
					case 7:
						goto IL_04fc;
					case 9:
						goto IL_054d;
					case 8:
						throw new ArgumentException();
					}
					if (630070888 / num != 0)
					{
						continue;
					}
					num = (uint)(629299685 << (int)num);
					int num9;
					if (!_01467757)
					{
						num9 = checked((sbyte)_4C62753A);
					}
					else
					{
						if (num >> 11 == 0)
						{
							continue;
						}
						num = 0x192E2D38 & num;
						int num10 = _4C62753A;
						num = 568096786 % num;
						uint num11 = checked((uint)num10);
						num = 1082020947 - num;
						num9 = checked((sbyte)num11);
						num += 286679999;
					}
					num = 0x18D04261 ^ num;
					return (sbyte)num9;
				}
				goto IL_002b;
				IL_054d:
				num ^= 0xD3722B8;
				num -= 521880083;
				if (!_01467757)
				{
					if (num >= 463415809)
					{
						int num12 = _4C62753A;
						num /= 1475948329;
						num13 = num12;
						break;
					}
					continue;
				}
				num = 0x1641D91 & num;
				double num14 = (uint)_4C62753A;
				num /= 9399565;
				num13 = num14;
				num += 4294967294u;
				break;
				IL_0065:
				if (!_01467757)
				{
					num %= 1919836239;
					goto IL_0073;
				}
				goto IL_0086;
				IL_0073:
				num &= 0x2B64627E;
				int value2 = _4C62753A;
				goto IL_00ba;
				IL_02bf:
				num >>= 12;
				int num15;
				if (!_01467757)
				{
					if (num >= 437602827)
					{
						continue;
					}
					num15 = checked((short)_4C62753A);
				}
				else
				{
					num = 0x5C6B52BE | num;
					num -= 728514617;
					int num16 = _4C62753A;
					num = 0x6A644B66 | num;
					num15 = checked((short)(uint)num16);
					num += 2224924667u;
				}
				return (short)num15;
				IL_03c1:
				num %= 318456540;
				int num17;
				if (!_01467757)
				{
					if (num * 2144797008 == 0)
					{
						goto IL_002b;
					}
					num <<= 0;
					num17 = checked((byte)_4C62753A);
				}
				else
				{
					if (366549095 <= num)
					{
						goto IL_0086;
					}
					uint num18 = checked((uint)_4C62753A);
					num = 614619258 * num;
					num17 = checked((byte)num18);
					num += 845252747;
				}
				num &= 0xA1167CD;
				return (byte)num17;
				IL_0359:
				if (num > 1345128508)
				{
					num <<= 15;
					long num20;
					if (!_01467757)
					{
						num += 1028917571;
						int num19 = _4C62753A;
						num %= 655965006;
						num20 = num19;
					}
					else
					{
						num = 591483310 + num;
						int num21 = _4C62753A;
						num = 981941288 + num;
						num20 = (uint)num21;
						num += 3094495263u;
					}
					num = 2044476434u >> (int)num;
					return num20;
				}
				continue;
				IL_00ba:
				num %= 606081878;
				return new IntPtr(value2);
				IL_0492:
				if (num == 167474515)
				{
					continue;
				}
				num *= 369387583;
				int num23;
				if (!_01467757)
				{
					num = 2048657903 * num;
					if (1911892469 == num)
					{
						goto IL_0065;
					}
					int num22 = _4C62753A;
					num = (uint)(368206670 << (int)num);
					num23 = (int)checked((uint)num22);
				}
				else
				{
					num = 0x720334DD & num;
					num23 = _4C62753A;
					num ^= 0xB00334D1u;
				}
				num = 2116769922 % num;
				return (uint)num23;
				IL_0086:
				num <<= 25;
				if ((num ^ 0x4C647EF0) == 0)
				{
					continue;
				}
				num %= 642660106;
				int num24 = _4C62753A;
				num %= 634471588;
				value2 = checked((int)(uint)num24);
				num ^= 0x14918AD4;
				goto IL_00ba;
				IL_04fc:
				num %= 897741413;
				if (num <= 2041339284)
				{
					int num26;
					if (!_01467757)
					{
						int num25 = _4C62753A;
						num /= 634782915;
						num26 = (int)checked((uint)num25);
					}
					else
					{
						num >>= 13;
						num26 = _4C62753A;
						num ^= 0x115DD;
					}
					num |= 0x3AB65BCE;
					return (uint)num26;
				}
				continue;
				IL_002b:
				int size = IntPtr.Size;
				num <<= 17;
				int num27 = (int)num ^ -1674838012;
				num = 1168246587 / num;
				if (size == num27)
				{
					num = (uint)(1268928291 << (int)num);
					if (501756529 == num)
					{
						goto IL_0073;
					}
				}
				else
				{
					num <<= 27;
					if (num < 722340457)
					{
						num -= 882913657;
						long value3;
						if (!_01467757)
						{
							num /= 396573125;
							if (847719782 * num == 0)
							{
								continue;
							}
							int num28 = _4C62753A;
							num = 49701406 + num;
							value3 = num28;
						}
						else
						{
							num = 1915449210 / num;
							if ((num ^ 0x68E37CCD) == 0)
							{
								continue;
							}
							value3 = (uint)_4C62753A;
							num += 49701414;
						}
						return new IntPtr(value3);
					}
				}
				goto IL_0065;
			}
			return num13;
		}

		public override int _6AAF062D()
		{
			uint num = 319638785u;
			return _4C62753A;
		}

		public override uint _76377E70()
		{
			uint num = 1108943441u;
			return (uint)_4C62753A;
		}

		public override object _0936516D()
		{
			uint num = 1304823104u;
			return _4C62753A;
		}

		public override double _40F966AC()
		{
			uint num = 746433u;
			num = 292321520u >> (int)num;
			int num2 = _4C62753A;
			num = 1280200864u >> (int)num;
			return num2;
		}

		public override Type _71C820E4()
		{
			uint num = 1894415591u;
			num = 319171223 * num;
			return typeof(int);
		}

		public override UIntPtr _15842C84()
		{
			uint num = 1897884024u;
			int value = _4C62753A;
			num += 1099042925;
			return new UIntPtr((uint)value);
		}

		public static _582960B3 _17D57EAC(_582960B3 _40152CF8, _582960B3 _79296375, bool _61A572C8, bool _13740FA6)
		{
			uint num = 1497521211u;
			int num7;
			if (2094337095 >= num)
			{
				num = 1421956720u >> (int)num;
				if (_13740FA6)
				{
					num >>= 31;
				}
				else if (num != 1714240131)
				{
					num = 24791129 + num;
					int num2 = _40152CF8._6AAF062D();
					num = 1820346823 - num;
					int num3 = num2;
					int num4 = _79296375._6AAF062D();
					num *= 966791898;
					int num5 = num4;
					num = 1029391352 % num;
					num += 1321541342;
					int num6;
					if (!_61A572C8)
					{
						num -= 4416736;
						num6 = num3 + num5;
					}
					else
					{
						num %= 1913198714;
						num6 = checked(num3 + num5);
						num += 1908781978;
					}
					num7 = num6;
					num ^= 0x8363AEBDu;
					goto IL_010b;
				}
			}
			uint num9;
			uint num11;
			do
			{
				uint num8 = _40152CF8._76377E70();
				num = 2072515118 + num;
				num9 = num8;
				num /= 937236081;
				uint num10 = _79296375._76377E70();
				num *= 130556686;
				num11 = num10;
			}
			while (num >= 1989494107);
			num = 460018400 * num;
			int num12;
			if (!_61A572C8)
			{
				num = 146756427u >> (int)num;
				num12 = (int)(num9 + num11);
			}
			else
			{
				num12 = (int)checked(num9 + num11);
				num += 4065919691u;
			}
			num7 = num12;
			goto IL_010b;
			IL_010b:
			num = 750346418 + num;
			int _7A3475AA = num7;
			num = 442196667 * num;
			return new _50424ADC(_7A3475AA);
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 320292499u;
			num = 1297904944u >> (int)num;
			int _7A3475AA = _4C62753A;
			num >>= 13;
			return new _50424ADC(_7A3475AA);
		}

		public override byte _70DF711E()
		{
			return (byte)_4C62753A;
		}

		public override IntPtr _47C01150()
		{
			uint num = 680346818u;
			num = 989606446 + num;
			int value = _4C62753A;
			num = 0x78B56343 ^ num;
			return new IntPtr(value);
		}

		public static _582960B3 _274F64E2(_582960B3 _31213868, _582960B3 _159D4254)
		{
			uint num = 1564096819u;
			int num2 = _31213868._6AAF062D();
			num -= 401899316;
			int num3 = _159D4254._6AAF062D();
			return new _50424ADC(num2 ^ num3);
		}

		public override bool _27B26B78()
		{
			uint num = 1469337504u;
			int num2 = _4C62753A;
			int num3 = (int)num + -1469337504;
			num ^= 0x4B53182A;
			return (uint)num2 > (uint)num3;
		}

		public static _582960B3 _58E83D0A(_582960B3 _56DB522E)
		{
			int _7A3475AA = ~_56DB522E._6AAF062D();
			uint num = 1379163176u;
			return new _50424ADC(_7A3475AA);
		}

		public override _582960B3 _2ED37583()
		{
			return new _39EC73F4((uint)_4C62753A);
		}

		public override char _52B43B98()
		{
			int num = _4C62753A;
			uint num2 = 156004782u;
			return (char)num;
		}

		public override ulong _5ECF32BD()
		{
			uint num = 1727666064u;
			num = 1695428862 / num;
			int num2 = _4C62753A;
			num <<= 5;
			return (uint)num2;
		}

		public static _582960B3 _3CB9335A(_582960B3 _5AB0222C, _582960B3 _775D48CD, bool _25A20F22)
		{
			uint num2 = default(uint);
			int num7 = default(int);
			uint num;
			while (true)
			{
				num = 1713657375u;
				if (_25A20F22)
				{
					do
					{
						num = 0x56CB7761 & num;
						num2 = _5AB0222C._76377E70();
						num >>= 21;
					}
					while (1472086561 == num);
				}
				else
				{
					num ^= 0x6E5644D8;
					if (965229208 * num == 0)
					{
						break;
					}
					num = 530655341u >> (int)num;
					int num3 = _5AB0222C._6AAF062D();
					num -= 538125883;
					if (num << 19 == 0)
					{
						continue;
					}
					int num4 = _775D48CD._6AAF062D();
					num = (uint)(381437053 << (int)num);
					int num5 = num4;
					num = 398161265 / num;
					if (num3 == num5)
					{
						num = 1409111972 + num;
						int num6 = (int)num + -1409111968;
						num %= 1270836013;
						num7 = num6;
						if (1197696717 / num != 0)
						{
							num ^= 0x16489046;
							break;
						}
						goto IL_0054;
					}
					if (num << 29 == 0)
					{
						int num8;
						if (num3 <= num5)
						{
							num8 = (int)num - -8;
						}
						else
						{
							num8 = (int)(num + 2);
							num ^= 0;
						}
						num = 1601900941u >> (int)num;
						num7 = num8;
						num ^= 0x410E6DBC;
						break;
					}
				}
				while (true)
				{
					num >>= 11;
					uint num9 = _775D48CD._76377E70();
					num = 0xAE65C89 & num;
					uint num10 = num2;
					num = 0x1E757C31 | num;
					if (num10 == num9)
					{
						break;
					}
					num <<= 17;
					if (113200487 > num)
					{
						continue;
					}
					uint num11 = num2;
					num = 239159032 - num;
					int num12;
					if (num11 <= num9)
					{
						num += 1804936281;
						num12 = (int)num ^ -2123076775;
					}
					else
					{
						num %= 1315586276;
						num12 = (int)(num ^ 0x15DF46FA);
						num ^= 0x94AB2DA9u;
					}
					num7 = num12;
					if (583863871 << (int)num == 0)
					{
						continue;
					}
					goto IL_00c3;
				}
				goto IL_0054;
				IL_0054:
				num7 = (int)num + -511015981;
				break;
				IL_00c3:
				num ^= 0x9F011760u;
				break;
			}
			num += 175792072;
			int _7A3475AA = num7;
			num = 0x7CF653BF ^ num;
			return new _50424ADC(_7A3475AA);
		}

		public static _582960B3 _409A0EE0(_582960B3 _385A1A7D, _582960B3 _6DE30CB5, bool _11E41756)
		{
			int _7A3475AA;
			while (true)
			{
				uint num = 1121610293u;
				if (_11E41756)
				{
					if ((num ^ 0x225B5358) != 0)
					{
						num ^= 0x47171F2D;
						uint num2 = _385A1A7D._76377E70();
						uint num3 = _6DE30CB5._76377E70();
						num <<= 0;
						uint num4 = num3;
						num = 0x1BDE6FB3 & num;
						num = 1724075372 - num;
						_7A3475AA = (int)(num2 / num4);
						break;
					}
					continue;
				}
				int num5 = _385A1A7D._6AAF062D();
				num &= 0xF97719C;
				int num6 = _6DE30CB5._6AAF062D();
				num = 0x514D6839 & num;
				int num7 = num5 / num6;
				num = 0x44C27926 | num;
				_7A3475AA = num7;
				num ^= 0x2034916A;
				break;
			}
			return new _50424ADC(_7A3475AA);
		}

		public static _582960B3 _25AD7155(_582960B3 _5A322174, _582960B3 _3FDE5CFD)
		{
			uint num = 1657798859u;
			int num2 = _5A322174._6AAF062D();
			num = 2021026363 + num;
			num >>= 5;
			int num3 = _3FDE5CFD._6AAF062D();
			num &= 0x16601D49;
			int num4 = num3;
			num = 1135438065 / num;
			return new _50424ADC(num2 | num4);
		}

		public override void _727F3897(object _5DB54FC1)
		{
			uint num = 1634415835u;
			int num2 = Convert.ToInt32(_5DB54FC1);
			num = (uint)(950171760 << (int)num);
			_4C62753A = num2;
		}

		public override short _72435997()
		{
			uint num = 2126785904u;
			num = 1899850423 / num;
			return (short)_4C62753A;
		}

		public static _582960B3 _5F615EA2(_582960B3 _67B53583)
		{
			return new _50424ADC(-_67B53583._6AAF062D());
		}

		public static _582960B3 _0F661174(_582960B3 _2B490BD5, _582960B3 _464B5D8A, bool _73175304)
		{
			uint num;
			if (!_73175304)
			{
				num = 74146215u;
				if (400099373 != num)
				{
					int num2 = _2B490BD5._6AAF062D();
					num = (uint)(182464030 << (int)num);
					num = 2145218698 + num;
					int num3 = _464B5D8A._6AAF062D();
					num ^= 0x7D8002A7;
					int num4 = num3;
					num = 61435732 + num;
					num = (uint)(1379799395 << (int)num);
					int num5 = num4 & (int)(num ^ 0xA47C22D9u);
					num /= 423253353;
					return new _50424ADC(num2 >> num5);
				}
			}
			uint num6 = _2B490BD5._76377E70();
			num = 883756564u;
			int num7 = _464B5D8A._6AAF062D();
			num = 1190360591 % num;
			int num8 = num7;
			return new _50424ADC((int)(num6 >> (int)((uint)num8 & (num - 306603996))));
		}

		public _50424ADC(int _7A3475AA)
		{
			while (true)
			{
				base._002Ector();
				uint num = 1668891691u;
				if (27275037u >> (int)num != 0)
				{
					num &= 0x2EA61237;
					num ^= 0x567158C0;
					_4C62753A = _7A3475AA;
					if ((num & 0x6A536051) != 0)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class _66FF619D : _76587E10
	{
		private long _6E8A5803;

		public override sbyte _22B70934()
		{
			uint num = 51848162u;
			num = 0x612F2DD1 & num;
			long num2 = _6E8A5803;
			num -= 2033528549;
			return (sbyte)num2;
		}

		public override ushort _16D4371A()
		{
			return (ushort)_6E8A5803;
		}

		public override _582960B3 _2ED37583()
		{
			uint num = 1142496103u;
			long _42877CF = _6E8A5803;
			num = 0x4E4E12E9 & num;
			return new _482E45FB((ulong)_42877CF);
		}

		public static _582960B3 _2E690D97(_582960B3 _1E684842, _582960B3 _3E252313, bool _7DBA79E7, bool _27A92373)
		{
			long num6;
			ulong num8 = default(ulong);
			uint num2;
			while (true)
			{
				if (_27A92373)
				{
					goto IL_0006;
				}
				long num = _1E684842._3E0F495D();
				num2 = 165505152u;
				long num3 = num;
				num2 %= 1774138077;
				if ((0x334D7DDB & num2) != 0)
				{
					num2 %= 1261794599;
					long num4 = _3E252313._3E0F495D();
					num2 = 1027867729 + num2;
					long num5;
					if (!_7DBA79E7)
					{
						num5 = num3 * num4;
					}
					else
					{
						num2 *= 635708406;
						if (num2 > 1637434870)
						{
							continue;
						}
						num2 ^= 0x66857DD3;
						num2 ^= 0x2FA0F03;
						num5 = checked(num3 * num4);
						num2 += 3620019147u;
					}
					num6 = num5;
					num2 += 3140123480u;
					break;
				}
				goto IL_0014;
				IL_006e:
				if (num2 == 946558452)
				{
					goto IL_0006;
				}
				ulong num9;
				long num7 = (long)checked(num8 * num9);
				num2 += 1232930100;
				goto IL_0087;
				IL_0014:
				ulong num10 = _3E252313._5ECF32BD();
				num2 = (uint)(639197520 << (int)num2);
				num9 = num10;
				if ((0xCCB16CF ^ num2) == 0)
				{
					continue;
				}
				num2 <<= 13;
				if (_7DBA79E7)
				{
					goto IL_006e;
				}
				num2 <<= 24;
				ulong num11 = num8;
				num2 = 1101281066 - num2;
				num2 = 0x8D9321E ^ num2;
				num7 = (long)(num11 * num9);
				goto IL_0087;
				IL_0006:
				ulong num12 = _1E684842._5ECF32BD();
				num2 = 84679607u;
				num8 = num12;
				goto IL_0014;
				IL_0087:
				num2 >>= 5;
				num6 = num7;
				if (1852926659 >= num2)
				{
					break;
				}
				goto IL_006e;
			}
			long _52CC445F = num6;
			num2 = 1437936429 + num2;
			return new _66FF619D(_52CC445F);
		}

		public static _582960B3 _2F9725E9(_582960B3 _1D1234AF)
		{
			long num = _1D1234AF._3E0F495D();
			uint num2 = 1935177400u;
			long _52CC445F = ~num;
			num2 = (uint)(1095710157 << (int)num2);
			return new _66FF619D(_52CC445F);
		}

		public override short _72435997()
		{
			uint num = 1906527385u;
			num = 0x4B614CB4 & num;
			long num2 = _6E8A5803;
			num = 1304628671 * num;
			return (short)num2;
		}

		public static _582960B3 _1D2D1B25(_582960B3 _3E16581A, _582960B3 _32950805, bool _7DC00C5C)
		{
			uint num = 512191950u;
			if (_7DC00C5C)
			{
				ulong num2 = _3E16581A._5ECF32BD();
				int num3 = _32950805._6AAF062D();
				num = 429667014 % num;
				int num4 = num3;
				num /= 808848129;
				uint num5 = num ^ 0x3F;
				num = 1372327657 - num;
				ulong _52CC445F = num2 >> (int)((uint)num4 & num5);
				num &= 0x6C6021E0;
				return new _66FF619D((long)_52CC445F);
			}
			num &= 0x54831202;
			long num6 = _3E16581A._3E0F495D();
			int num7 = _32950805._6AAF062D();
			num = 193547257 + num;
			int num8 = num7;
			num = 0x6D77424B | num;
			uint num9 = num ^ 0x6D7F4BC4;
			num = 0x3DD764B4 ^ num;
			long _52CC445F2 = num6 >> (int)((uint)num8 & num9);
			num += 6649875;
			return new _66FF619D(_52CC445F2);
		}

		public static _582960B3 _5EA561DC(_582960B3 _5B525F81, _582960B3 _1B6C7B36)
		{
			uint num = 2094154967u;
			long num2 = _5B525F81._3E0F495D();
			num <<= 7;
			num = 763505054u >> (int)num;
			int num3 = _1B6C7B36._6AAF062D();
			num = 1348083180 + num;
			int num4 = num3;
			num %= 1711242442;
			num = 0xA901E53 ^ num;
			int num5 = num4 & (int)(num ^ 0x1D4CD4AC);
			num &= 0x16AB6C75;
			long _52CC445F = num2 << num5;
			num >>= 19;
			return new _66FF619D(_52CC445F);
		}

		public override Type _71C820E4()
		{
			uint num = 840444790u;
			return typeof(long);
		}

		public static _582960B3 _1D45514F(_582960B3 _1A6355AF, _582960B3 _1C085835)
		{
			uint num = 612134915u;
			long num2 = _1A6355AF._3E0F495D();
			num -= 361837984;
			long num3 = _1C085835._3E0F495D();
			num /= 1106458823;
			long num4 = num3;
			num |= 0x38181CB0;
			num ^= 0x622417D5;
			long _52CC445F = num2 | num4;
			num &= 0x49BA39D1;
			return new _66FF619D(_52CC445F);
		}

		public override UIntPtr _15842C84()
		{
			int size = UIntPtr.Size;
			uint num = 594110800u;
			long value;
			if (size != (int)num + -594110796)
			{
				num = 1065377119 + num;
			}
			else if (613442469 != num)
			{
				int num2 = (int)_6E8A5803;
				num = (uint)(697054215 << (int)num);
				value = (uint)num2;
				num += 3422093313u;
				goto IL_005b;
			}
			num /= 1508967180;
			value = _6E8A5803;
			goto IL_005b;
			IL_005b:
			num ^= 0x4F0E64EA;
			return new UIntPtr((ulong)value);
		}

		public override TypeCode _09A801C9()
		{
			uint num = 1763519420u;
			return (TypeCode)(num - 1763519409);
		}

		public override _582960B3 _5C7710FF()
		{
			long _52CC445F = _6E8A5803;
			uint num = 1668178830u;
			return new _66FF619D(_52CC445F);
		}

		public override byte _70DF711E()
		{
			uint num = 314260759u;
			long num2 = _6E8A5803;
			num &= 0x6DDE7706;
			return (byte)num2;
		}

		public override ulong _5ECF32BD()
		{
			uint num = 1835869204u;
			return (ulong)_6E8A5803;
		}

		public static _582960B3 _22134A0D(_582960B3 _4E342412)
		{
			uint num = 478836706u;
			num /= 319305832;
			long _52CC445F = -_4E342412._3E0F495D();
			num -= 111048326;
			return new _66FF619D(_52CC445F);
		}

		public static _582960B3 _207E1A7C(_582960B3 _14995F94, _582960B3 _10225468, bool _267431A4)
		{
			long _52CC445F;
			uint num2;
			do
			{
				if (_267431A4)
				{
					ulong num = _14995F94._5ECF32BD();
					num2 = 1495208600u;
					ulong num3 = _10225468._5ECF32BD();
					num2 = 1243967106 * num2;
					_52CC445F = (long)(num / num3);
				}
				else
				{
					long num4 = _14995F94._3E0F495D();
					num2 = 1539991977u;
					num2 &= 0x709B5568;
					long num5 = _10225468._3E0F495D();
					num2 = 1556630948 + num2;
					long num6 = num5;
					num2 = 0x22BE349C & num2;
					long num7 = num4 / num6;
					num2 = 384908153 + num2;
					_52CC445F = num7;
					num2 ^= 0xCBF8135;
				}
				num2 |= 0x2DED7926;
			}
			while (388173203 >= num2);
			return new _66FF619D(_52CC445F);
		}

		public override char _52B43B98()
		{
			long num = _6E8A5803;
			uint num2 = 1321928574u;
			return (char)num;
		}

		public override float _078008FE()
		{
			long num = _6E8A5803;
			uint num2 = 1930498704u;
			return num;
		}

		public override long _3E0F495D()
		{
			uint num = 1676430565u;
			return _6E8A5803;
		}

		public override IntPtr _47C01150()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 1919971362u;
				if (size != 4)
				{
					num >>= 0;
					if (num * 837824465 != 0)
					{
						num = 0x5B9A38CC & num;
						value = _6E8A5803;
						break;
					}
				}
				num = 1385636505 * num;
				if (1254849754 << (int)num != 0)
				{
					value = (int)_6E8A5803;
					num ^= 0xE35B852;
					break;
				}
			}
			return new IntPtr(value);
		}

		public override object _7BBC17CC(Type _32481730, bool _0BB17D71)
		{
			uint num = 1744928473u;
			long value;
			while (true)
			{
				num = 470761119 + num;
				num = (uint)(1565788401 << (int)num);
				if (_32481730 == typeof(IntPtr))
				{
					num = 0x7E4F238D | num;
					if (num / 531824931 != 0)
					{
						goto IL_0045;
					}
					goto IL_00ea;
				}
				while (2009464974 < num)
				{
					num += 1004948574;
					Type? typeFromHandle = typeof(UIntPtr);
					num = 619063779 + num;
					if (_32481730 == typeFromHandle)
					{
						if (!_0BB17D71)
						{
							num = 0x72C067BB | num;
							if (1290683643 / num != 0)
							{
								continue;
							}
							goto IL_00ea;
						}
						goto IL_00fe;
					}
					num = 0x2A0A13C0 ^ num;
					TypeCode typeCode = Type.GetTypeCode(_32481730);
					num = 0x7F5E3F9D ^ num;
					TypeCode typeCode2 = typeCode;
					num = 541985537 - num;
					switch ((int)typeCode2 - (int)(num ^ 0x1BB5B0E0))
					{
					default:
						if (num >= 1092563915)
						{
							goto end_IL_00a0;
						}
						num ^= 0;
						goto case 8;
					case 0:
						break;
					case 2:
						goto IL_020b;
					case 4:
					{
						int num9;
						if (!_0BB17D71)
						{
							num ^= 0x3FF623E8;
							num = 1824091389 % num;
							long num8 = _6E8A5803;
							num %= 865863592;
							num9 = checked((int)num8);
						}
						else
						{
							num /= 1658671379;
							if (1102470163 <= num)
							{
								goto end_IL_00a0;
							}
							ulong num10 = checked((ulong)_6E8A5803);
							num = 1920861978 * num;
							num9 = checked((int)num10);
							num ^= 0x243246E3;
						}
						return num9;
					}
					case 6:
					{
						num ^= 0x36C91005;
						long num5;
						if (!_0BB17D71)
						{
							if ((0x5A58620F ^ num) == 0)
							{
								goto end_IL_00a0;
							}
							num >>= 0;
							num5 = _6E8A5803;
						}
						else
						{
							num <<= 18;
							long num6 = _6E8A5803;
							num >>= 8;
							ulong num7 = checked((ulong)num6);
							num = 270688917 + num;
							num5 = checked((long)num7);
							num ^= 0x3DD94275;
						}
						num += 1909462153;
						return num5;
					}
					case 1:
						goto IL_032e;
					case 3:
					{
						num %= 1125661346;
						num = 365893298 * num;
						int num3;
						if (!_0BB17D71)
						{
							if (num == 642069292)
							{
								goto end_IL_00a0;
							}
							num = 0x1EE646DB & num;
							long num2 = _6E8A5803;
							num = 0x1A606BC4 | num;
							num3 = checked((ushort)num2);
						}
						else
						{
							num = 533214761 * num;
							if (2049474323 == num)
							{
								goto end_IL_00a0;
							}
							num ^= 0x781E5761;
							checked
							{
								uint num4 = (uint)_6E8A5803;
								num >>= 21;
								num3 = (ushort)num4;
							}
							num += 451046481;
						}
						num = (uint)(1145991164 << (int)num);
						return (ushort)num3;
					}
					case 5:
						goto IL_0418;
					case 7:
						goto IL_047a;
					case 9:
						goto IL_04da;
					case 8:
						if ((0x7F5027D3 ^ num) != 0)
						{
							throw new ArgumentException();
						}
						goto end_IL_00a0;
					}
					num %= 1427113279;
					num = 1936156561u >> (int)num;
					int num11;
					if (!_0BB17D71)
					{
						num = 0x7571482E ^ num;
						if (90319249 >= num)
						{
							goto IL_0045;
						}
						num = 2115449853 - num;
						num11 = checked((sbyte)_6E8A5803);
					}
					else
					{
						if (num == 321132569)
						{
							break;
						}
						long num12 = _6E8A5803;
						num *= 779514662;
						num11 = checked((sbyte)(ulong)num12);
						num ^= 0x5D627E03;
					}
					num |= 0x42936979;
					return (sbyte)num11;
					IL_032e:
					if ((0x45E52255 ^ num) != 0)
					{
						int num13;
						if (!_0BB17D71)
						{
							if (1494358291 << (int)num == 0)
							{
								continue;
							}
							num = 0x39F61DD9 | num;
							num13 = checked((byte)_6E8A5803);
						}
						else
						{
							num &= 0xAC429B9;
							num += 282532660;
							num13 = checked((byte)(ulong)_6E8A5803);
							num ^= 0x20AC8628;
						}
						num = 1386173462 % num;
						return (byte)num13;
					}
					goto IL_0045;
					IL_020b:
					num &= 0x6F9752E4;
					if (num > 1703022734)
					{
						break;
					}
					int num15;
					if (!_0BB17D71)
					{
						num = 1189554044 - num;
						long num14 = _6E8A5803;
						num %= 361054545;
						num15 = checked((short)num14);
					}
					else
					{
						num = 0x31FB3DF8 & num;
						if (1549624241 << (int)num == 0)
						{
							continue;
						}
						num15 = checked((short)(ulong)_6E8A5803);
						num ^= 0x11D68316;
					}
					return (short)num15;
					IL_0418:
					num |= 0x76451A6D;
					int num16;
					if (!_0BB17D71)
					{
						num = (uint)(951672012 << (int)num);
						if (num << 31 != 0)
						{
							continue;
						}
						num16 = (int)checked((uint)_6E8A5803);
					}
					else
					{
						num = 317982715 % num;
						num = 0x23931B06 & num;
						long num17 = _6E8A5803;
						num += 10557691;
						num16 = (int)checked((uint)(ulong)num17);
						num += 677929987;
					}
					return (uint)num16;
					IL_047a:
					num = 1455106469u >> (int)num;
					num = 1560304940 * num;
					long num19;
					if (!_0BB17D71)
					{
						num -= 1747012487;
						long num18 = _6E8A5803;
						num >>= 31;
						num19 = (long)checked((ulong)num18);
					}
					else
					{
						if ((num & 0x6A842B31) == 0)
						{
							goto IL_0045;
						}
						num19 = _6E8A5803;
						num += 2144185796;
					}
					num *= 1886347001;
					return (ulong)num19;
					IL_04da:
					num |= 0x54B83D03;
					double num21;
					if (!_0BB17D71)
					{
						num = 0x191E5FA1 | num;
						if (num / 894900496 == 0)
						{
							goto IL_0045;
						}
						long num20 = _6E8A5803;
						num *= 482348739;
						num21 = num20;
					}
					else
					{
						if (num < 661663121)
						{
							break;
						}
						num = 0x145E09F7 | num;
						long num22 = _6E8A5803;
						num <<= 20;
						num21 = (ulong)num22;
						num += 3238956789u;
					}
					return num21;
					continue;
					end_IL_00a0:
					break;
				}
				continue;
				IL_00fe:
				if (718757054 != num)
				{
					value = _6E8A5803;
					num ^= 0x43C42209;
					break;
				}
				continue;
				IL_0045:
				while (true)
				{
					long value2;
					if (!_0BB17D71)
					{
						if (num << 5 == 0)
						{
							continue;
						}
						value2 = _6E8A5803;
					}
					else
					{
						if (845035899 == num)
						{
							break;
						}
						num -= 1224551583;
						value2 = checked((long)(ulong)_6E8A5803);
						num += 1224551583;
					}
					num = 1133607730 % num;
					IntPtr intPtr = new IntPtr(value2);
					num /= 252141567;
					return intPtr;
				}
				continue;
				IL_00ea:
				num = 0x1628544C & num;
				value = (long)checked((ulong)_6E8A5803);
				break;
			}
			num = 428229926 * num;
			return new UIntPtr((ulong)value);
		}

		public override void _727F3897(object _4F95636A)
		{
			uint num;
			do
			{
				num = 214374403u;
				num = 0x6501DA0 & num;
				long num2 = Convert.ToInt64(_4F95636A);
				num = 1899954488u >> (int)num;
				_6E8A5803 = num2;
			}
			while (num % 1218277588 == 0);
		}

		public unsafe override void* _1AF75EB9()
		{
			return _47C01150().ToPointer();
		}

		public override int _6AAF062D()
		{
			uint num = 1545680833u;
			long num2 = _6E8A5803;
			num = 285169143 % num;
			return (int)num2;
		}

		public static _582960B3 _3B3E58BA(_582960B3 _47DD3EA3, _582960B3 _2222439E, bool _50EF12A2)
		{
			uint num = 484315888u;
			if ((0x7C7804D5 ^ num) != 0)
			{
				num *= 1640311243;
				if (_50EF12A2)
				{
					num <<= 25;
					goto IL_0028;
				}
			}
			if (num != 1247759123)
			{
				num -= 287708478;
				long num2 = _47DD3EA3._3E0F495D();
				num /= 1209674889;
				num >>= 30;
				long num3 = _2222439E._3E0F495D();
				long _52CC445F = num2 % num3;
				num = 0x67B31036 | num;
				return new _66FF619D(_52CC445F);
			}
			goto IL_0028;
			IL_0028:
			num /= 1799306347;
			ulong num4 = _47DD3EA3._5ECF32BD();
			ulong num5 = _2222439E._5ECF32BD();
			num -= 665195337;
			return new _66FF619D((long)(num4 % num5));
		}

		public static _582960B3 _3D30647A(_582960B3 _13C3741F, _582960B3 _447D68FE)
		{
			uint num = 221270824u;
			long num2 = _13C3741F._3E0F495D();
			num = 1277963658 - num;
			long num3 = _447D68FE._3E0F495D();
			num = 375663807u >> (int)num;
			num = 0x32453065 & num;
			return new _66FF619D(num2 & num3);
		}

		public static _582960B3 _0E4A18C3(_582960B3 _3CDD3691, _582960B3 _7D30130D, bool _45777EA9, bool _1C7676D6)
		{
			long num6;
			uint num;
			while (true)
			{
				if (_1C7676D6)
				{
					num = 132808261u;
					ulong num2 = _3CDD3691._5ECF32BD();
					if ((num ^ 0x776858D7) == 0)
					{
						continue;
					}
					ulong num3 = _7D30130D._5ECF32BD();
					num -= 753758086;
					ulong num4 = num3;
					if (num % 945585874 == 0)
					{
						continue;
					}
					do
					{
						num = 0x1CB8605F & num;
						long num5;
						if (!_45777EA9)
						{
							num ^= 0x41040517;
							num = 0x3AE02DC0 ^ num;
							num5 = (long)(num2 - num4);
						}
						else
						{
							num = 1705007971 - num;
							num &= 0x695A6E5E;
							num &= 0x54465D95;
							num5 = (long)checked(num2 - num4);
							num += 589029572;
						}
						num6 = num5;
					}
					while (46989701 * num == 0);
					break;
				}
				long num7 = _3CDD3691._3E0F495D();
				long num8 = _7D30130D._3E0F495D();
				num = 44172661u;
				long num9 = num8;
				num = 961823475 / num;
				num = 230651995 % num;
				long num10;
				if (!_45777EA9)
				{
					num <<= 30;
					num = 2381149 + num;
					num10 = num7 - num9;
				}
				else
				{
					num = 1408455548 / num;
					if (1861498896 <= num)
					{
						continue;
					}
					num = 1668967395u >> (int)num;
					num >>= 13;
					num10 = checked(num7 - num9);
					num ^= 0xC024555Du;
				}
				num = 0x350E16A3 | num;
				num6 = num10;
				num += 1848496329;
				break;
			}
			long _52CC445F = num6;
			num ^= 0x512A4579;
			return new _66FF619D(_52CC445F);
		}

		public static _582960B3 _6CCC34C2(_582960B3 _5C935C34, _582960B3 _5C76692D, bool _39BE465B)
		{
			uint num = 715676091u;
			int _7A3475AA;
			ulong num6 = default(ulong);
			while (true)
			{
				if (_39BE465B)
				{
					num = 0x42E53308 & num;
					if (num >> 7 != 0)
					{
						goto IL_0020;
					}
					goto IL_003c;
				}
				num = 273352560 / num;
				num *= 1004674627;
				long num2 = _5C935C34._3E0F495D();
				num |= 0x1AA56360;
				if (1178863251 % num == 0)
				{
					continue;
				}
				long num3 = _5C76692D._3E0F495D();
				num <<= 3;
				long num4 = num3;
				if (1561529707 * num == 0)
				{
					continue;
				}
				num <<= 30;
				num *= 1770401920;
				if (num2 == num4)
				{
					num = 1853304634 - num;
					_7A3475AA = (int)(num - 1853304630);
					if ((num ^ 0x66232463) == 0)
					{
						continue;
					}
					num += 285736868;
				}
				else
				{
					num = 0x391A09B9 | num;
					if (1739004405 == num)
					{
						goto IL_003c;
					}
					int num5;
					if (num2 <= num4)
					{
						num5 = (int)num + -958007729;
					}
					else
					{
						num += 1948272742;
						num5 = (int)num ^ -1388686819;
						num ^= 0x94205BA6u;
					}
					num |= 0x75A0B16;
					_7A3475AA = num5;
					num ^= 0x40252561;
				}
				goto IL_01a7;
				IL_0020:
				num = 467143199 - num;
				num6 = _5C935C34._5ECF32BD();
				if ((0x2B631E3D ^ num) == 0)
				{
					continue;
				}
				goto IL_003c;
				IL_003c:
				ulong num7 = _5C76692D._5ECF32BD();
				num *= 484980108;
				ulong num8 = num7;
				num *= 206786682;
				ulong num9 = num6;
				num = 0xAD360AD & num;
				if (num9 != num8)
				{
					ulong num10 = num6;
					num = 774534169 + num;
					int num11;
					if (num10 <= num8)
					{
						num11 = (int)(num - 813339801);
					}
					else
					{
						num = 1962815230 / num;
						num11 = (int)(num ^ 0);
						num += 813339807;
					}
					_7A3475AA = num11;
					if (num < 1030161872)
					{
						num += 1325701693;
						goto IL_01a7;
					}
				}
				num = 0x7F3F0E5E | num;
				_7A3475AA = (int)num + -2139041498;
				if (1765350664 >= num)
				{
					goto IL_0020;
				}
				goto IL_01a7;
				IL_01a7:
				num = 0x4FCE0790 | num;
				if (num >= 964323098)
				{
					break;
				}
				goto IL_0020;
			}
			return new _50424ADC(_7A3475AA);
		}

		public override object _0936516D()
		{
			uint num = 1915970184u;
			num *= 1306603554;
			long num2 = _6E8A5803;
			num = (uint)(1073639749 << (int)num);
			return num2;
		}

		public override bool _27B26B78()
		{
			uint num = 936604182u;
			num ^= 0x70B41EF2;
			long num2 = _6E8A5803;
			num = (uint)(1822425944 << (int)num);
			long num3 = (int)num ^ -905955968;
			num -= 2106484468;
			return (ulong)num2 > (ulong)num3;
		}

		public static _582960B3 _755C7C0C(_582960B3 _3E497320, _582960B3 _5CE62C25, bool _68670692, bool _006C6E3D)
		{
			uint num = 1600737299u;
			long num5;
			ulong num6 = default(ulong);
			ulong num10 = default(ulong);
			while (true)
			{
				num = 863403061 % num;
				if (_006C6E3D)
				{
					num = 0x62D53A2D & num;
				}
				else
				{
					num *= 375260639;
					if (1633834150 * num == 0)
					{
						continue;
					}
					num /= 251531230;
					long num2 = _3E497320._3E0F495D();
					num -= 1330400222;
					long num3 = _5CE62C25._3E0F495D();
					if (2016561398 <= num)
					{
						num *= 1641358668;
						long num4;
						if (!_68670692)
						{
							if (num + 665734605 == 0)
							{
								continue;
							}
							num = 2037388707 + num;
							num4 = num2 + num3;
						}
						else
						{
							num /= 592975533;
							if ((0x9D86B28 & num) != 0)
							{
								goto IL_005c;
							}
							num4 = checked(num2 + num3);
							num ^= 0x93463437u;
						}
						num += 2076204855;
						num5 = num4;
						num ^= 0x3A2531D8;
						break;
					}
				}
				num6 = _3E497320._5ECF32BD();
				num ^= 0x60A14C18;
				if (num >= 484466817)
				{
					goto IL_0036;
				}
				goto IL_005c;
				IL_00aa:
				long num7;
				num5 = num7;
				if (2033221165 << (int)num != 0)
				{
					break;
				}
				goto IL_008e;
				IL_008e:
				num >>= 17;
				ulong num8 = num6;
				ulong num9 = num10;
				num = 365036192 * num;
				num7 = (long)checked(num8 + num9);
				num ^= 0xDE14F16;
				goto IL_00aa;
				IL_0036:
				num >>= 21;
				ulong num11 = _5CE62C25._5ECF32BD();
				num = (uint)(1944221813 << (int)num);
				num10 = num11;
				num -= 1787646887;
				goto IL_005c;
				IL_005c:
				if (_68670692)
				{
					goto IL_008e;
				}
				num *= 1252616628;
				if (num == 1256675255)
				{
					goto IL_0036;
				}
				ulong num12 = num6;
				num += 1470456429;
				ulong num13 = num10;
				num -= 1653894987;
				num7 = (long)(num12 + num13);
				goto IL_00aa;
			}
			long _52CC445F = num5;
			num = 0x3F3E577A & num;
			return new _66FF619D(_52CC445F);
		}

		public override double _40F966AC()
		{
			return _6E8A5803;
		}

		public static _582960B3 _18B551FE(_582960B3 _495F6626, _582960B3 _717A25F6)
		{
			uint num = 400967090u;
			long num2 = _495F6626._3E0F495D();
			long num3 = _717A25F6._3E0F495D();
			num /= 2091601259;
			long num4 = num3;
			num -= 128988883;
			long _52CC445F = num2 ^ num4;
			num = (uint)(1323174875 << (int)num);
			return new _66FF619D(_52CC445F);
		}

		public override uint _76377E70()
		{
			return (uint)_6E8A5803;
		}

		public _66FF619D(long _52CC445F)
		{
			uint num = 1087055213u;
			base._002Ector();
			if (121311686 != num)
			{
				do
				{
					_6E8A5803 = _52CC445F;
				}
				while (2077771821 == num);
			}
		}
	}

	private sealed class _5A103814 : _76587E10
	{
		private float _488C2885;

		public override float _078008FE()
		{
			uint num = 1337936399u;
			num &= 0x1B3E5BB6;
			return _488C2885;
		}

		public override object _7BBC17CC(Type _42975D8C, bool _60845E05)
		{
			uint num2;
			while (true)
			{
				bool num = _42975D8C == typeof(IntPtr);
				num2 = 372210147u;
				if (num)
				{
					num2 -= 1291347498;
					if (296777774 != num2)
					{
						break;
					}
				}
				while (true)
				{
					num2 = (uint)(1818967376 << (int)num2);
					Type? typeFromHandle = typeof(UIntPtr);
					num2 = 0x7ACC42D2 & num2;
					if (_42975D8C == typeFromHandle)
					{
						num2 = 569127052 * num2;
						float num3 = _488C2885;
						num2 /= 1559305826;
						ulong value = checked((ulong)num3);
						num2 = 925314890 - num2;
						return new UIntPtr(value);
					}
					num2 = 788754964 % num2;
					num2 |= 0x5E291AA6;
					TypeCode typeCode = Type.GetTypeCode(_42975D8C);
					num2 = 1199442946u >> (int)num2;
					TypeCode typeCode2 = typeCode;
					num2 = 0x2AF84EC1 & num2;
					if (314858717 == num2)
					{
						break;
					}
					switch ((int)typeCode2 - (int)(num2 ^ 4))
					{
					default:
						if ((num2 ^ 0x59133D59) == 0)
						{
							goto end_IL_0058;
						}
						num2 += 0;
						goto case 6;
					case 0:
						break;
					case 2:
						goto IL_01a0;
					case 4:
					{
						int num7 = checked((int)_488C2885);
						num2 %= 1588277739;
						return num7;
					}
					case 1:
						goto IL_022b;
					case 3:
					{
						num2 ^= 0x235C17F1;
						float num5 = _488C2885;
						num2 = 587294848 / num2;
						ushort num6 = checked((ushort)num5);
						num2 <<= 5;
						return num6;
					}
					case 5:
						goto IL_0288;
					case 7:
					{
						float num4 = _488C2885;
						num2 = 1677680883u >> (int)num2;
						return checked((ulong)num4);
					}
					case 6:
						num2 -= 1337730730;
						throw new ArgumentException();
					}
					num2 = 1633319063u >> (int)num2;
					int num9;
					if (!_60845E05)
					{
						if (num2 % 533755820 == 0)
						{
							continue;
						}
						num2 = 523704105u >> (int)num2;
						float num8 = _488C2885;
						num2 >>= 13;
						num9 = checked((sbyte)num8);
					}
					else
					{
						if ((0x54380892 ^ num2) == 0)
						{
							goto end_IL_0000;
						}
						float num10 = _488C2885;
						num2 %= 138810520;
						checked
						{
							uint num11 = (uint)num10;
							num2 = 0x4E680F49 ^ num2;
							num9 = (sbyte)num11;
						}
						num2 += 3067684357u;
					}
					return (sbyte)num9;
					IL_0288:
					if (943551948 > num2)
					{
						num2 = 1817116882 + num2;
						uint num12 = checked((uint)_488C2885);
						num2 = 1904437333 % num2;
						return num12;
					}
					continue;
					IL_01a0:
					if (num2 >= 1993344359)
					{
						goto end_IL_0000;
					}
					int num14;
					if (!_60845E05)
					{
						num2 = 2106162195 + num2;
						num2 |= 0xEF23644;
						float num13 = _488C2885;
						num2 -= 1259294893;
						num14 = checked((short)num13);
					}
					else
					{
						num2 += 1995445572;
						if (1694064362 > num2)
						{
							continue;
						}
						num2 = 1217413947 % num2;
						float num15 = _488C2885;
						num2 = 186064449 / num2;
						num14 = checked((short)(uint)num15);
						num2 ^= 0x34EC2DA7;
					}
					num2 <<= 8;
					return (short)num14;
					IL_022b:
					num2 <<= 21;
					if (num2 >= 207176628)
					{
						goto end_IL_0000;
					}
					num2 = 0x40EF33A1 & num2;
					float num16 = _488C2885;
					num2 -= 1588799117;
					byte num17 = checked((byte)num16);
					num2 = 0x421B6E06 ^ num2;
					return num17;
					continue;
					end_IL_0058:
					break;
				}
				continue;
				end_IL_0000:
				break;
			}
			num2 /= 524956978;
			long value2 = checked((long)_488C2885);
			num2 = 1846816630 / num2;
			IntPtr intPtr = new IntPtr(value2);
			num2 <<= 4;
			return intPtr;
		}

		public override void _727F3897(object _0C781DAD)
		{
			uint num = 1323443933u;
			if (num * 1475022398 != 0)
			{
				num = (uint)(1738694693 << (int)num);
				float num2 = Convert.ToSingle(_0C781DAD);
				num -= 1641694014;
				_488C2885 = num2;
			}
		}

		public static _582960B3 _54097123(_582960B3 _201213CA, _582960B3 _31197437, bool _0C67472D, bool _550D5844)
		{
			uint num = 1969301719u;
			if (num >= 751839009)
			{
				goto IL_0011;
			}
			goto IL_001f;
			IL_0011:
			_582960B3 obj;
			if (!_550D5844)
			{
				num = 0x28986527 ^ num;
			}
			else if (num > 478111525)
			{
				num -= 304687706;
				obj = _201213CA._2ED37583();
				num += 4206972787u;
				goto IL_0046;
			}
			goto IL_001f;
			IL_0046:
			float num2 = obj._078008FE();
			num = 219561983u >> (int)num;
			if (1011772523 + num != 0)
			{
				while (true)
				{
					num += 1094804167;
					_582960B3 obj2;
					if (!_550D5844)
					{
						obj2 = _31197437;
					}
					else
					{
						num = 2009611265 / num;
						obj2 = _31197437._2ED37583();
						num += 1094807516;
					}
					float num3 = obj2._078008FE();
					if (num / 602813921 == 0)
					{
						break;
					}
					float _3A4B;
					if (!_0C67472D)
					{
						num /= 931885122;
						if ((num ^ 0x5A0D6E08) == 0)
						{
							continue;
						}
						num >>= 11;
						num = (uint)(2005036580 << (int)num);
						_3A4B = num2 + num3;
					}
					else
					{
						if (num < 855131178)
						{
							break;
						}
						_3A4B = num2 + num3;
						num ^= 0x36C301F9;
					}
					num <<= 12;
					return new _5A103814(_3A4B);
				}
			}
			goto IL_0011;
			IL_001f:
			obj = _201213CA;
			goto IL_0046;
		}

		public override TypeCode _09A801C9()
		{
			uint num = 403191157u;
			return (TypeCode)((int)num + -403191144);
		}

		public static _582960B3 _695126C8(_582960B3 _51CC7E9F)
		{
			float num = _51CC7E9F._078008FE();
			uint num2 = 270733491u;
			return new _5A103814(0f - num);
		}

		public override long _3E0F495D()
		{
			return (long)_488C2885;
		}

		public override ushort _16D4371A()
		{
			uint num = 1059586072u;
			num >>= 22;
			float num2 = _488C2885;
			num &= 0x2900232B;
			return (ushort)num2;
		}

		public override uint _76377E70()
		{
			uint num = 340609373u;
			num = 337721090u >> (int)num;
			return (uint)_488C2885;
		}

		public override byte _70DF711E()
		{
			uint num = 1229923296u;
			return (byte)_488C2885;
		}

		public static _582960B3 _7F0F7C23(_582960B3 _03130F64, _582960B3 _2E1B14E4, bool _2DE97829)
		{
			uint num = 231802047u;
			if (num + 889814052 != 0)
			{
				goto IL_0012;
			}
			goto IL_0018;
			IL_0012:
			while (_2DE97829)
			{
				if (2023062754 * num == 0)
				{
					continue;
				}
				goto IL_002a;
			}
			goto IL_0018;
			IL_0038:
			_582960B3 obj;
			float num2 = ((_582960B3)obj)._078008FE();
			num = (uint)(1647989382 << (int)num);
			float num3 = num2;
			num = 0x6D894A69 | num;
			_582960B3 obj2;
			if (!_2DE97829)
			{
				num = 0x474E0776 ^ num;
				obj2 = _2E1B14E4;
			}
			else
			{
				num = 1132166810 - num;
				obj2 = _2E1B14E4._2ED37583();
				num ^= 0xFF35792Eu;
			}
			num = 60907978 - num;
			float num4 = obj2._078008FE();
			num = 624238950 + num;
			if (1937535400 != num)
			{
				num %= 1161315128;
				int num6;
				if (num3 == num4)
				{
					num = 0x11FC6A2E ^ num;
					uint num5 = num ^ 0x3F9A0643;
					num >>= 10;
					num6 = (int)num5;
				}
				else
				{
					int num7;
					if (!(num3 > num4))
					{
						num7 = (int)(num ^ 0x2E666C61);
					}
					else
					{
						num7 = (int)(num ^ 0x2E666C6B);
						num += 0;
					}
					num6 = num7;
					num ^= 0x2E698AE8;
				}
				num >>= 17;
				int _7A3475AA = num6;
				num = 1102776375 * num;
				return new _50424ADC(_7A3475AA);
			}
			goto IL_0012;
			IL_002a:
			obj = _03130F64._2ED37583();
			num += 0;
			goto IL_0038;
			IL_0018:
			obj = _03130F64;
			goto IL_0038;
		}

		public override object _0936516D()
		{
			return _488C2885;
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1451449090u;
			return new _5A103814(_488C2885);
		}

		public override Type _71C820E4()
		{
			uint num = 540738748u;
			num = 1698765341 % num;
			return typeof(float);
		}

		public static _582960B3 _0B5F41B5(_582960B3 _212F77BD, _582960B3 _04655DE9, bool _019939C4, bool _4BC139BF)
		{
			while (true)
			{
				IL_0000:
				uint num = 1940918676u;
				if (!_4BC139BF)
				{
					goto IL_000c;
				}
				if (1660581344 >= num)
				{
					continue;
				}
				_582960B3 obj = _212F77BD._2ED37583();
				num ^= 0;
				goto IL_002b;
				IL_002b:
				float num2 = obj._078008FE();
				num -= 2016960163;
				float num3 = num2;
				if (2146446638 == num)
				{
					continue;
				}
				while (true)
				{
					_582960B3 obj2;
					if (!_4BC139BF)
					{
						if (num >> 2 == 0)
						{
							break;
						}
						obj2 = _04655DE9;
					}
					else
					{
						num = 1759007586u >> (int)num;
						if (2032095695 * num == 0)
						{
							goto IL_0000;
						}
						obj2 = _04655DE9._2ED37583();
						num += 4218912389u;
					}
					float num4 = obj2._078008FE();
					num ^= 0x41875F4;
					float num5 = num4;
					if ((0x63901C19 & num) != 0)
					{
						num <<= 11;
						float _3A4B;
						if (!_019939C4)
						{
							if (num / 1984782785 == 0)
							{
								goto IL_0000;
							}
							num = 77078840 * num;
							_3A4B = num3 * num5;
						}
						else
						{
							num = 1723693492u >> (int)num;
							if ((num ^ 0x55026A97) == 0)
							{
								continue;
							}
							num = 1768650259 + num;
							num *= 745174548;
							_3A4B = num3 * num5;
							num ^= 0x76EB58C;
						}
						num = 1751461364 / num;
						return new _5A103814(_3A4B);
					}
					goto IL_0000;
				}
				goto IL_000c;
				IL_000c:
				obj = _212F77BD;
				goto IL_002b;
			}
		}

		public override bool _27B26B78()
		{
			return Convert.ToBoolean(_488C2885);
		}

		public static _582960B3 _4C4356D8(_582960B3 _49947B97, _582960B3 _343704D3, bool _303C7038)
		{
			uint num = 391334519u;
			_582960B3 obj;
			if ((!_303C7038 && num != 1154635279) || 408421815 <= num)
			{
				obj = _49947B97;
			}
			else
			{
				num |= 0x65AC529F;
				obj = _49947B97._2ED37583();
				num += 2673078136u;
			}
			num += 2057795534;
			float num2 = obj._078008FE();
			_582960B3 obj2;
			if (!_303C7038)
			{
				obj2 = _343704D3;
			}
			else
			{
				num &= 0x57DC5346;
				obj2 = _343704D3._2ED37583();
				num ^= 0x80228001u;
			}
			float num3 = obj2._078008FE();
			float _3A4B = num2 / num3;
			num = 576930828 * num;
			return new _5A103814(_3A4B);
		}

		public override UIntPtr _15842C84()
		{
			long value;
			uint num;
			if (IntPtr.Size != 4)
			{
				num = 351413296u;
				num = 0x319822D6 | num;
				value = (long)(ulong)_488C2885;
			}
			else
			{
				num = 1214006724u;
				num = 1824943794u >> (int)num;
				float num2 = _488C2885;
				num *= 878977990;
				value = (uint)num2;
				num += 302279732;
			}
			num >>= 17;
			return new UIntPtr((ulong)value);
		}

		public override int _6AAF062D()
		{
			uint num = 1111123481u;
			num -= 2138775018;
			return (int)_488C2885;
		}

		public override sbyte _22B70934()
		{
			uint num = 1563565919u;
			return (sbyte)_488C2885;
		}

		public override double _40F966AC()
		{
			float num = _488C2885;
			uint num2 = 98186960u;
			return num;
		}

		public static _582960B3 _5F8B1692(_582960B3 _5BCD7FDB, _582960B3 _62FA00B4, bool _737313E2, bool _73435303)
		{
			float _3A4B;
			uint num;
			while (true)
			{
				if (!_73435303)
				{
					goto IL_0006;
				}
				num = 846490843u;
				if (num == 877484752)
				{
					continue;
				}
				_582960B3 obj = _5BCD7FDB._2ED37583();
				goto IL_0023;
				IL_0023:
				num = 1885108787u;
				float num2 = obj._078008FE();
				num >>= 12;
				_582960B3 obj2;
				if (!_73435303)
				{
					num = 0x36C75D8C | num;
					obj2 = _62FA00B4;
				}
				else
				{
					if (num == 1569915488)
					{
						goto IL_0006;
					}
					obj2 = _62FA00B4._2ED37583();
					num ^= 0x36C05808;
				}
				float num3 = obj2._078008FE();
				num = 0x57B56B85 ^ num;
				float num4 = num3;
				num = 0x46AE2BBB ^ num;
				if (846136316 > num)
				{
					if (!_737313E2)
					{
						num = 0x51411B9D ^ num;
						num = 647961843 - num;
						_3A4B = num2 - num4;
						break;
					}
					if (2114944942 > num)
					{
						_3A4B = num2 - num4;
						num += 2284189846u;
						break;
					}
				}
				continue;
				IL_0006:
				obj = _5BCD7FDB;
				goto IL_0023;
			}
			num = 946554477 * num;
			return new _5A103814(_3A4B);
		}

		public override ulong _5ECF32BD()
		{
			uint num = 100402213u;
			num &= 0x78B12C30;
			float num2 = _488C2885;
			num >>= 12;
			return (ulong)num2;
		}

		public override IntPtr _47C01150()
		{
			uint num = 1250252786u;
			long value;
			while (true)
			{
				if (IntPtr.Size != (int)num + -1250252782)
				{
					if (num > 1329681871)
					{
						continue;
					}
				}
				else if (970070603 - num != 0)
				{
					num = 0x19241362 ^ num;
					value = (int)_488C2885;
					num ^= 0x1B455FF4;
					break;
				}
				num = 1222908772 % num;
				float num2 = _488C2885;
				num %= 1469712062;
				value = (long)num2;
				break;
			}
			num = 0x2D372081 | num;
			return new IntPtr(value);
		}

		public override short _72435997()
		{
			uint num = 2028220801u;
			return (short)_488C2885;
		}

		public override char _52B43B98()
		{
			uint num = 585393851u;
			num = 1070468083 / num;
			return (char)_488C2885;
		}

		public _5A103814(float _3A4B3048)
		{
			uint num = 151473209u;
			if (num >> 27 != 0)
			{
				base._002Ector();
				if (num * 1655850028 != 0)
				{
					num = 0x7B2ED9 & num;
					_488C2885 = _3A4B3048;
				}
			}
		}
	}

	private sealed class _77315431 : _76587E10
	{
		private double _0A895AA3;

		public static _582960B3 _5ECB5C23(_582960B3 _4C823830)
		{
			uint num = 159852125u;
			num >>= 8;
			double num2 = _4C823830._40F966AC();
			num = 0x576D3B37 | num;
			return new _77315431(0.0 - num2);
		}

		public override int _6AAF062D()
		{
			uint num = 1860006583u;
			return (int)_0A895AA3;
		}

		public override char _52B43B98()
		{
			uint num = 560399519u;
			double num2 = _0A895AA3;
			num %= 2100822133;
			return (char)num2;
		}

		public override sbyte _22B70934()
		{
			uint num = 1843673072u;
			double num2 = _0A895AA3;
			num &= 0xD2D2FFF;
			return (sbyte)num2;
		}

		public override byte _70DF711E()
		{
			uint num = 367949275u;
			double num2 = _0A895AA3;
			num = 396036238u >> (int)num;
			return (byte)num2;
		}

		public override bool _27B26B78()
		{
			uint num = 1869167324u;
			num = 482699493 * num;
			return Convert.ToBoolean(_0A895AA3);
		}

		public static _582960B3 _483F64ED(_582960B3 _43484A0B, _582960B3 _465245BA, bool _38FA6044)
		{
			uint num = 611988596u;
			if ((num ^ 0x6CDA0D98) != 0)
			{
				goto IL_0012;
			}
			goto IL_0020;
			IL_0012:
			if (!_38FA6044)
			{
				num >>= 18;
				goto IL_0020;
			}
			num += 846219775;
			_582960B3 obj;
			if (num % 526611050 != 0)
			{
				num = (uint)(823924065 << (int)num);
				obj = _43484A0B._2ED37583();
				num ^= 0xAB08091Eu;
				goto IL_0056;
			}
			goto IL_0080;
			IL_00a0:
			num ^= 0x7AB70964;
			_582960B3 obj2;
			double num2 = ((_582960B3)obj2)._40F966AC();
			num = 514538669 - num;
			double num4 = default(double);
			if ((0x5270666D ^ num) != 0)
			{
				double num3 = num4;
				num &= 0x266A55F1;
				num <<= 0;
				int num5;
				if (num3 == num2)
				{
					num5 = (int)num + -576720956;
					if (num % 1269777348 == 0)
					{
						goto IL_0012;
					}
				}
				else
				{
					num = 0x173959D5 ^ num;
					double num6 = num4;
					num = (uint)(1555709133 << (int)num);
					num = 0x9F4494F ^ num;
					int num7;
					if (!(num6 > num2))
					{
						num %= 733896022;
						num7 = (int)(num - 219754821);
					}
					else
					{
						num7 = (int)num ^ -1873524403;
						num ^= 0x9D4D7802u;
					}
					num5 = num7;
					num += 356966131;
				}
				int _7A3475AA = num5;
				num = 0x31460DB4 ^ num;
				return new _50424ADC(_7A3475AA);
			}
			goto IL_0012;
			IL_0080:
			obj2 = _465245BA;
			goto IL_00a0;
			IL_0056:
			num &= 0x158A67F6;
			num4 = obj._40F966AC();
			num = 1231823460 / num;
			num = 23612920u >> (int)num;
			if (!_38FA6044)
			{
				goto IL_0080;
			}
			if (1958823700 * num == 0)
			{
				goto IL_0020;
			}
			obj2 = _465245BA._2ED37583();
			num += 0;
			goto IL_00a0;
			IL_0020:
			obj = _43484A0B;
			goto IL_0056;
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 442780075u;
			return new _77315431(_0A895AA3);
		}

		public override uint _76377E70()
		{
			uint num = 1512653105u;
			num = 0x192F580F | num;
			double num2 = _0A895AA3;
			num += 1334847093;
			return (uint)num2;
		}

		public override ushort _16D4371A()
		{
			double num = _0A895AA3;
			uint num2 = 1664169896u;
			return (ushort)num;
		}

		public override void _727F3897(object _26F11E39)
		{
			uint num = 1049655925u;
			_0A895AA3 = (double)_26F11E39;
		}

		public static _582960B3 _038D42A0(_582960B3 _13A829F5, _582960B3 _29F12D44, bool _75A05101)
		{
			uint num = 138111558u;
			num = 0x17148B2 ^ num;
			_582960B3 obj;
			if (_75A05101 || 965225887 >>> (int)num == 0)
			{
				num = 0x83E1D43 & num;
				if (1969764647 != num)
				{
					num = (uint)(1464630124 << (int)num);
					obj = _13A829F5._2ED37583();
					num += 2986190728u;
					goto IL_005b;
				}
			}
			obj = _13A829F5;
			goto IL_005b;
			IL_005b:
			num *= 1744993762;
			double num2 = obj._40F966AC();
			num = 487917698 + num;
			num *= 940319031;
			_582960B3 obj2;
			if (!_75A05101)
			{
				num = (uint)(217467479 << (int)num);
				obj2 = _29F12D44;
			}
			else
			{
				obj2 = _29F12D44._2ED37583();
				num ^= 0x66274886;
			}
			num >>= 31;
			double num3 = obj2._40F966AC();
			num <<= 29;
			double num4 = num3;
			num += 1687631006;
			num <<= 17;
			return new _77315431(num2 / num4);
		}

		public override Type _71C820E4()
		{
			uint num = 1762471621u;
			num = 411697928 / num;
			return typeof(double);
		}

		public override short _72435997()
		{
			uint num = 2107519224u;
			num = 1976441808 - num;
			double num2 = _0A895AA3;
			num = 0xFCE7BB1 & num;
			return (short)num2;
		}

		public static _582960B3 _09BD67D8(_582960B3 _5F315A93, _582960B3 _21CB5E7C, bool _760C7861, bool _40843C25)
		{
			double _5FD;
			while (true)
			{
				if (!_40843C25)
				{
					goto IL_0006;
				}
				_582960B3 obj = _5F315A93._2ED37583();
				goto IL_0012;
				IL_004c:
				uint num = num - 1395985743;
				_582960B3 obj2;
				double num2 = ((_582960B3)obj2)._40F966AC();
				if (num % 1302867688 == 0)
				{
					continue;
				}
				double num3;
				if (!_760C7861)
				{
					num >>= 9;
					num = 808145291 - num;
					num %= 580799304;
					_5FD = num3 + num2;
					break;
				}
				if (1245074565 <= num)
				{
					num = 1153834141 - num;
					num = 1110534350 % num;
					_5FD = num3 + num2;
					num += 3405908963u;
					break;
				}
				goto IL_0024;
				IL_0012:
				num3 = obj._40F966AC();
				num = 106443231u;
				if (!_40843C25)
				{
					goto IL_0024;
				}
				num |= 0xE2E7080;
				if (num - 1342252514 == 0)
				{
					goto IL_0006;
				}
				obj2 = _21CB5E7C._2ED37583();
				num += 4158242816u;
				goto IL_004c;
				IL_0024:
				obj2 = _21CB5E7C;
				goto IL_004c;
				IL_0006:
				obj = _5F315A93;
				goto IL_0012;
			}
			return new _77315431(_5FD);
		}

		public override TypeCode _09A801C9()
		{
			return TypeCode.Double;
		}

		public override long _3E0F495D()
		{
			uint num = 1780898619u;
			num &= 0x59E71B1F;
			double num2 = _0A895AA3;
			num |= 0x75773A92;
			return (long)num2;
		}

		public override UIntPtr _15842C84()
		{
			uint num = 40392403u;
			if (1625387139 >= num)
			{
				while (true)
				{
					int size = IntPtr.Size;
					num = 0x19F60D7 & num;
					uint num2 = num ^ 0x840D7;
					num |= 0x1AB75CE1;
					if (size == (int)num2)
					{
						break;
					}
					num ^= 0x722473EF;
					if (num > 2053010712)
					{
						continue;
					}
					goto IL_0045;
				}
			}
			num = 0xDF75700 & num;
			double num3 = _0A895AA3;
			num >>= 27;
			uint num4 = (uint)num3;
			num >>= 8;
			long value = num4;
			num ^= 0xAFE68545u;
			goto IL_0081;
			IL_0045:
			double num5 = _0A895AA3;
			num += 1196119593;
			value = (long)(ulong)num5;
			goto IL_0081;
			IL_0081:
			num |= 0x1FD628F7;
			return new UIntPtr((ulong)value);
		}

		public override double _40F966AC()
		{
			return _0A895AA3;
		}

		public override float _078008FE()
		{
			double num = _0A895AA3;
			uint num2 = 2115464202u;
			return (float)num;
		}

		public override ulong _5ECF32BD()
		{
			uint num = 454196927u;
			return (ulong)_0A895AA3;
		}

		public override object _7BBC17CC(Type _48D07114, bool _66AA6F31)
		{
			uint num;
			while (true)
			{
				num = 2117229680u;
				Type? typeFromHandle = typeof(IntPtr);
				num = 317807036u >> (int)num;
				bool num2 = _48D07114 == typeFromHandle;
				num *= 1745695041;
				if (num2)
				{
					num &= 0x3BB03049;
					goto IL_0039;
				}
				num |= 0x1F186C7A;
				if (num < 343237246)
				{
					continue;
				}
				num ^= 0x26A4157;
				num = 1459040563 - num;
				if (_48D07114 == typeof(UIntPtr))
				{
					num |= 0xA796590;
					double num3 = _0A895AA3;
					num = 24516292 - num;
					return new UIntPtr(checked((ulong)num3));
				}
				while ((num ^ 0x507E4246) != 0)
				{
					TypeCode typeCode = Type.GetTypeCode(_48D07114);
					num = 67059106 / num;
					TypeCode typeCode2 = typeCode;
					num <<= 25;
					uint num4 = num ^ 5;
					num &= 0x6FA904D3;
					switch ((int)typeCode2 - (int)num4)
					{
					case 0:
						goto IL_0136;
					case 2:
						goto IL_0189;
					case 4:
						goto IL_01ef;
					case 6:
						goto IL_0226;
					case 1:
						goto IL_024c;
					case 3:
					{
						num = 0x5C2976B3 | num;
						num %= 859403318;
						ushort num8 = checked((ushort)_0A895AA3);
						num |= 0x24722578;
						return num8;
					}
					case 5:
					{
						num &= 0x1E66223E;
						num = 1084820492 - num;
						double num7 = _0A895AA3;
						num ^= 0x23512610;
						return checked((uint)num7);
					}
					case 7:
					{
						num = 1862603515u >> (int)num;
						ulong num6 = checked((ulong)_0A895AA3);
						num = 1752061050 * num;
						return num6;
					}
					case 9:
					{
						num = 0x321C25DE ^ num;
						num &= 0x40C87E64;
						double num5 = _0A895AA3;
						num = 1527911719 / num;
						return num5;
					}
					case 8:
						goto IL_030b;
					}
					if (1025195822 < num)
					{
						continue;
					}
					num += 0;
					goto IL_030b;
					IL_0136:
					num /= 1068243383;
					int num9;
					if (!_66AA6F31)
					{
						if (num >= 1137384287)
						{
							break;
						}
						num9 = checked((sbyte)_0A895AA3);
					}
					else
					{
						num %= 815748383;
						num /= 1639143624;
						double num10 = _0A895AA3;
						num = 0x41F10F17 | num;
						num9 = checked((sbyte)(uint)num10);
						num += 3188650217u;
					}
					return (sbyte)num9;
					IL_0226:
					num = 1109943433u >> (int)num;
					if (num == 1687290576)
					{
						break;
					}
					return checked((long)_0A895AA3);
					IL_030b:
					num = (uint)(497696170 << (int)num);
					if (1941259273 << (int)num == 0)
					{
						break;
					}
					throw new ArgumentException();
				}
				continue;
				IL_0189:
				num = 216561505 * num;
				if (num != 960303208)
				{
					int num12;
					checked
					{
						if (!_66AA6F31)
						{
							if (num > 1812611591)
							{
								goto IL_0039;
							}
							num |= 0x730C29C0;
							double num11 = _0A895AA3;
							num ^= 0x7AB90A90;
							num12 = (short)num11;
						}
						else
						{
							uint num13 = (uint)_0A895AA3;
							num = unchecked(num * 1985444879);
							num12 = (short)num13;
							num ^= 0x9B52350;
						}
					}
					num = 258748670 * num;
					return (short)num12;
				}
				goto IL_0039;
				IL_024c:
				num = 26025395 - num;
				if (1766933449 >= num)
				{
					break;
				}
				goto IL_0039;
				IL_01ef:
				num = 350174732 - num;
				if (2044686733 * num != 0)
				{
					num <<= 22;
					double num14 = _0A895AA3;
					num = (uint)(1964080370 << (int)num);
					return checked((int)num14);
				}
				goto IL_0039;
				IL_0039:
				num = 288763193 - num;
				double num15 = _0A895AA3;
				num = 200437403 % num;
				IntPtr intPtr = new IntPtr(checked((long)num15));
				num = 577582362 % num;
				return intPtr;
			}
			byte num16 = checked((byte)_0A895AA3);
			num = (uint)(1230920574 << (int)num);
			return num16;
		}

		public override object _0936516D()
		{
			double num = _0A895AA3;
			uint num2 = 1855986572u;
			return num;
		}

		public override IntPtr _47C01150()
		{
			int size = IntPtr.Size;
			uint num = 12320927u;
			long value;
			if (size != (int)num + -12320923)
			{
				num = 0x7BC6646D | num;
				if (num >= 294136910)
				{
					value = (long)_0A895AA3;
					goto IL_0056;
				}
			}
			num = 0x14CB732D & num;
			num = 0x22F673EE & num;
			value = (int)_0A895AA3;
			num += 2071880947;
			goto IL_0056;
			IL_0056:
			return new IntPtr(value);
		}

		public static _582960B3 _31E76A87(_582960B3 _3C727820, _582960B3 _12F4704B, bool _48804229, bool _158544D8)
		{
			double _5FD;
			while (true)
			{
				if (!_158544D8)
				{
					goto IL_0006;
				}
				uint num = 1495296605u;
				_582960B3 obj = _3C727820._2ED37583();
				goto IL_0018;
				IL_0006:
				obj = _3C727820;
				goto IL_0018;
				IL_0018:
				num = 1960594590u;
				double num2 = obj._40F966AC();
				num -= 526343497;
				double num3 = num2;
				num <<= 15;
				_582960B3 obj2;
				if (!_158544D8)
				{
					if (1134698779 + num == 0)
					{
						goto IL_0006;
					}
					obj2 = _12F4704B;
				}
				else
				{
					if (2115112340 <= num)
					{
						continue;
					}
					obj2 = _12F4704B._2ED37583();
					num += 0;
				}
				double num4 = obj2._40F966AC();
				num ^= 0x713258F5;
				double num5 = num4;
				if (num != 1794264704)
				{
					if (!_48804229)
					{
						_5FD = num3 - num5;
						break;
					}
					num -= 325540850;
					if (num != 125122230)
					{
						num >>= 31;
						_5FD = num3 - num5;
						num += 110680308;
						break;
					}
					continue;
				}
				goto IL_0006;
			}
			return new _77315431(_5FD);
		}

		public static _582960B3 _706B32E9(_582960B3 _3B560868, _582960B3 _15C13D7F, bool _0E955B4F, bool _2A5E7DE9)
		{
			uint num = 1529887772u;
			double num3 = default(double);
			double _5FD;
			while (true)
			{
				num >>= 31;
				_582960B3 obj;
				if (!_2A5E7DE9)
				{
					if ((0x5E591226 ^ num) == 0)
					{
						goto IL_0061;
					}
					obj = _3B560868;
				}
				else
				{
					if (754519179 < num)
					{
						continue;
					}
					obj = _3B560868._2ED37583();
					num ^= 0;
				}
				double num2 = obj._40F966AC();
				num *= 210836179;
				num3 = num2;
				num *= 1174803244;
				if (495077911 - num == 0)
				{
					continue;
				}
				goto IL_0061;
				IL_0061:
				_582960B3 obj2;
				if (!_2A5E7DE9)
				{
					obj2 = _15C13D7F;
				}
				else
				{
					num = 1190210106 - num;
					obj2 = _15C13D7F._2ED37583();
					num += 3104757190u;
				}
				num = 0x3F7723D2 | num;
				double num4 = obj2._40F966AC();
				num = 1558119667 * num;
				double num5 = num4;
				if ((0x7D523321 ^ num) != 0)
				{
					if (!_0E955B4F)
					{
						double num6 = num3;
						num = 0x493442E1 ^ num;
						_5FD = num6 * num5;
						break;
					}
					if (501559801 - num != 0)
					{
						double num7 = num3;
						num &= 0x14696BFC;
						_5FD = num7 * num5;
						num ^= 0x8BA042E3u;
						break;
					}
				}
			}
			return new _77315431(_5FD);
		}

		public _77315431(double _5FD10870)
		{
			uint num = 977540449u;
			base._002Ector();
			do
			{
				num = 0x18702E38 & num;
				num <<= 0;
				_0A895AA3 = _5FD10870;
			}
			while (num + 708395530 == 0);
		}
	}

	private sealed class _0BD93DAD : _76587E10
	{
		private string _541505ED;

		public override Type _71C820E4()
		{
			uint num = 1625423963u;
			return typeof(string);
		}

		public override void _727F3897(object _37BE31C5)
		{
			uint num;
			do
			{
				num = 716468290u;
				object obj;
				if (_37BE31C5 == null)
				{
					num += 1734683186;
					obj = null;
				}
				else
				{
					num = 459147581 / num;
					num = 0x34763358 & num;
					obj = Convert.ToString(_37BE31C5);
					num ^= 0x92199A74u;
				}
				_541505ED = (string)obj;
			}
			while ((num ^ 0x134F0A94) == 0);
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1935048229u;
			string _618A179B = _541505ED;
			num = 0x6821181E ^ num;
			return new _0BD93DAD(_618A179B);
		}

		public override string ToString()
		{
			uint num = 778133006u;
			num >>= 1;
			return _541505ED;
		}

		public override TypeCode _09A801C9()
		{
			return TypeCode.Object;
		}

		public override bool _27B26B78()
		{
			string text = _541505ED;
			uint num = 1980059411u;
			return text != null;
		}

		public override object _0936516D()
		{
			uint num = 747135598u;
			num -= 349649592;
			return _541505ED;
		}

		public _0BD93DAD(string _618A179B)
		{
			uint num = 1208028780u;
			do
			{
				num = 1686984444 + num;
				num = 793773354 / num;
				_541505ED = _618A179B;
			}
			while (num > 1447249656);
		}
	}

	private sealed class _4F3F00F5 : _582960B3
	{
		private short _43864848;

		public override _582960B3 _5C7710FF()
		{
			uint num = 1353149654u;
			short _585E = _43864848;
			num *= 1122727385;
			return new _4F3F00F5(_585E);
		}

		public override uint _76377E70()
		{
			uint num = 1962231028u;
			num /= 1446794010;
			return (uint)_43864848;
		}

		public override int _6AAF062D()
		{
			return _43864848;
		}

		public override void _727F3897(object _087C1310)
		{
			uint num = 579350611u;
			short num2 = Convert.ToInt16(_087C1310);
			num -= 1337133221;
			_43864848 = num2;
		}

		public override Type _71C820E4()
		{
			uint num = 1120475876u;
			num &= 0x3D1B5A16;
			return typeof(short);
		}

		public override byte _70DF711E()
		{
			return (byte)_43864848;
		}

		public override ushort _16D4371A()
		{
			uint num = 1386158233u;
			short num2 = _43864848;
			num |= 0x35326C14;
			return (ushort)num2;
		}

		public override short _72435997()
		{
			return _43864848;
		}

		public override _76587E10 _689700D4()
		{
			int _7A3475AA = _6AAF062D();
			uint num = 268514748u;
			return new _50424ADC(_7A3475AA);
		}

		public override sbyte _22B70934()
		{
			uint num = 117967882u;
			num |= 0x3AA65F44;
			short num2 = _43864848;
			num = 571688947 * num;
			return (sbyte)num2;
		}

		public override object _0936516D()
		{
			return _43864848;
		}

		public _4F3F00F5(short _585E2346)
		{
			uint num = 26357223u;
			num += 1376916719;
			base._002Ector();
			do
			{
				num >>= 8;
				_43864848 = _585E2346;
			}
			while (num > 1606906714);
		}
	}

	private sealed class _05FE464D : _582960B3
	{
		private ushort _1C8B6698;

		public override byte _70DF711E()
		{
			uint num = 1815748369u;
			ushort num2 = _1C8B6698;
			num = 0x10C42D06 & num;
			return (byte)num2;
		}

		public override Type _71C820E4()
		{
			uint num = 119288554u;
			num = (uint)(101390420 << (int)num);
			return typeof(ushort);
		}

		public override _76587E10 _689700D4()
		{
			int _7A3475AA = _6AAF062D();
			uint num = 1208373192u;
			return new _50424ADC(_7A3475AA);
		}

		public override uint _76377E70()
		{
			uint num = 903953881u;
			return _1C8B6698;
		}

		public override object _0936516D()
		{
			uint num = 121905466u;
			num /= 348211677;
			return _1C8B6698;
		}

		public override ushort _16D4371A()
		{
			uint num = 2055477398u;
			num = 875252196 * num;
			return _1C8B6698;
		}

		public override int _6AAF062D()
		{
			uint num = 612124607u;
			return _1C8B6698;
		}

		public override sbyte _22B70934()
		{
			uint num = 1882732460u;
			ushort num2 = _1C8B6698;
			num /= 1685197868;
			return (sbyte)num2;
		}

		public override void _727F3897(object _54452593)
		{
			uint num = 641956745u;
			ushort num2 = Convert.ToUInt16(_54452593);
			num = 1441934059 * num;
			_1C8B6698 = num2;
		}

		public override short _72435997()
		{
			ushort num = _1C8B6698;
			uint num2 = 212492370u;
			return (short)num;
		}

		public override _582960B3 _5C7710FF()
		{
			return new _05FE464D(_1C8B6698);
		}

		public _05FE464D(ushort _787C1032)
		{
			uint num = 378563041u;
			if (num * 906514137 != 0)
			{
				do
				{
					num <<= 11;
					base._002Ector();
					_1C8B6698 = _787C1032;
				}
				while (num % 1588160833 == 0);
			}
		}
	}

	private sealed class _488D2F82 : _582960B3
	{
		private bool _28A263E4;

		public override _76587E10 _689700D4()
		{
			uint num = 946342339u;
			int _7A3475AA = _6AAF062D();
			num = 0x78705892 ^ num;
			return new _50424ADC(_7A3475AA);
		}

		public override int _6AAF062D()
		{
			uint num = 1359491638u;
			if (1558319182 << (int)num == 0 || !_28A263E4)
			{
				return (int)(num - 1359491638);
			}
			return (int)(num ^ 0x51083237);
		}

		public override void _727F3897(object _28E94BAD)
		{
			uint num = 582902733u;
			do
			{
				num = 12800789 % num;
				_28A263E4 = Convert.ToBoolean(_28E94BAD);
			}
			while (num > 535526177);
		}

		public override object _0936516D()
		{
			uint num = 1528575295u;
			return _28A263E4;
		}

		public override Type _71C820E4()
		{
			uint num = 1940880750u;
			num = 196639612 - num;
			return typeof(bool);
		}

		public override _582960B3 _5C7710FF()
		{
			return new _488D2F82(_28A263E4);
		}

		public _488D2F82(bool _375C684C)
		{
			uint num = 1977384382u;
			num = 454833996 + num;
			base._002Ector();
			if (800728991 < num)
			{
				_28A263E4 = _375C684C;
			}
		}
	}

	private sealed class _19B932DA : _582960B3
	{
		private char _482D4A99;

		public override object _0936516D()
		{
			uint num = 1373266888u;
			return _482D4A99;
		}

		public override ushort _16D4371A()
		{
			uint num = 549204408u;
			return _482D4A99;
		}

		public override void _727F3897(object _69B11852)
		{
			uint num = 430723240u;
			do
			{
				num >>= 25;
				num |= 0x2BA83DA8;
				_482D4A99 = Convert.ToChar(_69B11852);
			}
			while (417663406 > num);
		}

		public override _76587E10 _689700D4()
		{
			uint num = 235864135u;
			num += 774330558;
			int _7A3475AA = _6AAF062D();
			num = 1355890891 - num;
			return new _50424ADC(_7A3475AA);
		}

		public override short _72435997()
		{
			uint num = 1059010220u;
			return (short)_482D4A99;
		}

		public override uint _76377E70()
		{
			uint num = 1241060124u;
			return _482D4A99;
		}

		public override byte _70DF711E()
		{
			uint num = 1889667152u;
			return (byte)_482D4A99;
		}

		public override sbyte _22B70934()
		{
			uint num = 1049656729u;
			num = (uint)(1231946779 << (int)num);
			return (sbyte)_482D4A99;
		}

		public override int _6AAF062D()
		{
			uint num = 1194527235u;
			return _482D4A99;
		}

		public override Type _71C820E4()
		{
			uint num = 305072887u;
			return typeof(char);
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 2129856369u;
			num %= 1316576935;
			char _65AE5CD = _482D4A99;
			num /= 1680232599;
			return new _19B932DA(_65AE5CD);
		}

		public _19B932DA(char _65AE5CD2)
		{
			uint num = 1736839720u;
			if (num > 465858005)
			{
				do
				{
					base._002Ector();
					num += 1825732484;
				}
				while (438900307 % num == 0);
				do
				{
					num = 661203647 - num;
					_482D4A99 = _65AE5CD2;
				}
				while ((0x171B3DCB & num) == 0);
			}
		}
	}

	private sealed class _48772BCF : _582960B3
	{
		private byte _212E00CF;

		public override Type _71C820E4()
		{
			return typeof(byte);
		}

		public override byte _70DF711E()
		{
			uint num = 568548013u;
			num = 954428764 / num;
			return _212E00CF;
		}

		public override int _6AAF062D()
		{
			uint num = 1702244102u;
			return _212E00CF;
		}

		public override object _0936516D()
		{
			uint num = 831089968u;
			return _212E00CF;
		}

		public override _76587E10 _689700D4()
		{
			uint num = 806430996u;
			return new _50424ADC(_6AAF062D());
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 518794132u;
			byte _259033B = _212E00CF;
			num = 0x2ED02531 | num;
			return new _48772BCF(_259033B);
		}

		public override uint _76377E70()
		{
			uint num = 1969771372u;
			return _212E00CF;
		}

		public override void _727F3897(object _58F40254)
		{
			uint num = 1459844382u;
			num = 0x27721EFA & num;
			byte num2 = Convert.ToByte(_58F40254);
			num = 0x7E81658E ^ num;
			_212E00CF = num2;
		}

		public override ushort _16D4371A()
		{
			uint num = 551239947u;
			return _212E00CF;
		}

		public override sbyte _22B70934()
		{
			uint num = 755391207u;
			byte num2 = _212E00CF;
			num &= 0x6BE25BF8;
			return (sbyte)num2;
		}

		public override short _72435997()
		{
			uint num = 1098672528u;
			return _212E00CF;
		}

		public _48772BCF(byte _259033B6)
		{
			uint num;
			do
			{
				base._002Ector();
				num = 331424089u;
			}
			while (num + 2003772433 == 0);
			do
			{
				num >>= 20;
				_212E00CF = _259033B6;
			}
			while ((0x9FB2F7D & num) == 0);
		}
	}

	private sealed class _1CE22CD9 : _582960B3
	{
		private sbyte _00FC07B9;

		public override short _72435997()
		{
			uint num = 1666329725u;
			return _00FC07B9;
		}

		public override _582960B3 _5C7710FF()
		{
			sbyte _78492022 = _00FC07B9;
			uint num = 1905552724u;
			return new _1CE22CD9(_78492022);
		}

		public override sbyte _22B70934()
		{
			uint num = 443685406u;
			return _00FC07B9;
		}

		public override byte _70DF711E()
		{
			uint num = 1907583667u;
			sbyte num2 = _00FC07B9;
			num += 1730049255;
			return (byte)num2;
		}

		public override int _6AAF062D()
		{
			uint num = 755790889u;
			num = 39460936 / num;
			return _00FC07B9;
		}

		public override object _0936516D()
		{
			uint num = 10302795u;
			return _00FC07B9;
		}

		public override uint _76377E70()
		{
			return (uint)_00FC07B9;
		}

		public override Type _71C820E4()
		{
			uint num = 600400516u;
			return typeof(sbyte);
		}

		public override void _727F3897(object _5FE55CE1)
		{
			sbyte num = Convert.ToSByte(_5FE55CE1);
			uint num2 = 1336693312u;
			_00FC07B9 = num;
		}

		public override _76587E10 _689700D4()
		{
			uint num = 1512708987u;
			int _7A3475AA = _6AAF062D();
			num &= 0x637E1262;
			return new _50424ADC(_7A3475AA);
		}

		public override ushort _16D4371A()
		{
			uint num = 1065971783u;
			num = 0x56940092 ^ num;
			sbyte num2 = _00FC07B9;
			num <<= 28;
			return (ushort)num2;
		}

		public _1CE22CD9(sbyte _11032447)
		{
			uint num = 788791319u;
			base._002Ector();
			num = 2081578199 - num;
			_00FC07B9 = _11032447;
		}
	}

	private sealed class _39EC73F4 : _582960B3
	{
		private uint _706447B1;

		public override _76587E10 _689700D4()
		{
			uint num = 709507999u;
			return new _50424ADC(_6AAF062D());
		}

		public override int _6AAF062D()
		{
			uint num = 472337135u;
			return (int)_706447B1;
		}

		public override ushort _16D4371A()
		{
			uint num = 1047336617u;
			uint num2 = _706447B1;
			num += 1197893717;
			return (ushort)num2;
		}

		public override short _72435997()
		{
			uint num = _706447B1;
			uint num2 = 939415932u;
			return (short)num;
		}

		public override uint _76377E70()
		{
			uint num = 120270767u;
			num = 944125760 / num;
			return _706447B1;
		}

		public override byte _70DF711E()
		{
			uint num = _706447B1;
			uint num2 = 1740310001u;
			return (byte)num;
		}

		public override object _0936516D()
		{
			uint num = 237643007u;
			uint num2 = _706447B1;
			num ^= 0xAA40C4D;
			return num2;
		}

		public override Type _71C820E4()
		{
			uint num = 1248493490u;
			return typeof(uint);
		}

		public override void _727F3897(object _08AF394E)
		{
			uint num = 1849250789u;
			num = (uint)(1162693080 << (int)num);
			_706447B1 = Convert.ToUInt32(_08AF394E);
		}

		public override sbyte _22B70934()
		{
			uint num = 909451900u;
			uint num2 = _706447B1;
			num = 0x64017342 & num;
			return (sbyte)num2;
		}

		public override _582960B3 _5C7710FF()
		{
			return new _39EC73F4(_706447B1);
		}

		public _39EC73F4(uint _24A0670E)
		{
			uint num = 256319353u;
			num >>= 23;
			_706447B1 = _24A0670E;
		}
	}

	private sealed class _482E45FB : _582960B3
	{
		private ulong _36155577;

		public override object _0936516D()
		{
			uint num = 348331746u;
			return _36155577;
		}

		public override uint _76377E70()
		{
			ulong num = _36155577;
			uint num2 = 231416780u;
			return (uint)num;
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 955203463u;
			ulong _42877CF = _36155577;
			num &= 0x11F052CB;
			return new _482E45FB(_42877CF);
		}

		public override long _3E0F495D()
		{
			return (long)_36155577;
		}

		public override byte _70DF711E()
		{
			uint num = 1708656106u;
			ulong num2 = _36155577;
			num = 1775071218u >> (int)num;
			return (byte)num2;
		}

		public override Type _71C820E4()
		{
			uint num = 2009092408u;
			num = 0x624810D0 ^ num;
			return typeof(ulong);
		}

		public override sbyte _22B70934()
		{
			uint num = 1871452948u;
			num = 1538610372 / num;
			return (sbyte)_36155577;
		}

		public override ushort _16D4371A()
		{
			uint num = 1561070275u;
			num %= 25642605;
			ulong num2 = _36155577;
			num = 0x20DE2AA5 & num;
			return (ushort)num2;
		}

		public override short _72435997()
		{
			ulong num = _36155577;
			uint num2 = 364079277u;
			return (short)num;
		}

		public override void _727F3897(object _5EC41612)
		{
			_36155577 = Convert.ToUInt64(_5EC41612);
		}

		public override _76587E10 _689700D4()
		{
			uint num = 2045706249u;
			num = 0x54A83FDF & num;
			return new _66FF619D(_3E0F495D());
		}

		public override int _6AAF062D()
		{
			uint num = 1569152851u;
			num %= 474285270;
			return (int)_36155577;
		}

		public override ulong _5ECF32BD()
		{
			uint num = 109411865u;
			num += 563096998;
			return _36155577;
		}

		public _482E45FB(ulong _42877CF6)
		{
			_36155577 = _42877CF6;
		}
	}

	private sealed class _2CEE4B34 : _76587E10
	{
		private object _215442A1;

		public override TypeCode _09A801C9()
		{
			uint num = 1929595194u;
			return (TypeCode)(num - 1929595193);
		}

		public override Type _71C820E4()
		{
			uint num = 338130881u;
			num %= 689467528;
			return typeof(object);
		}

		public static _582960B3 _04A142D0(_582960B3 _29717F16, _582960B3 _619971B1)
		{
			object obj = _29717F16._0936516D();
			uint num = 68175695u;
			object obj2 = _619971B1._0936516D();
			num = 653811783 * num;
			object obj3 = obj2;
			num &= 0x3F8B2E49;
			int _7A3475AA;
			if (obj == obj3)
			{
				uint num2 = num - 159983173;
				num = (uint)(1499675091 << (int)num);
				_7A3475AA = (int)num2;
			}
			else
			{
				num = 1294942732 / num;
				int num3;
				if (obj3 != null)
				{
					num3 = (int)(num + 0);
				}
				else
				{
					num3 = (int)(num - 6);
					num ^= 0;
				}
				_7A3475AA = num3;
				num ^= 0xC673A608u;
			}
			num += 1680682609;
			return new _50424ADC(_7A3475AA);
		}

		public override void _727F3897(object _34B7032C)
		{
			uint num = 1166767593u;
			_215442A1 = _34B7032C;
		}

		public override object _0936516D()
		{
			uint num = 330851435u;
			return _215442A1;
		}

		public override bool _27B26B78()
		{
			uint num = 1305752105u;
			object obj = _215442A1;
			num = (uint)(1572801436 << (int)num);
			num += 721974339;
			return Unsafe.As<object, UIntPtr>(ref obj) > Unsafe.As<@null, UIntPtr>(ref null);
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1657539546u;
			object _3CE71D = _215442A1;
			num = (uint)(273634114 << (int)num);
			return new _2CEE4B34(_3CE71D);
		}

		public _2CEE4B34(object _3CE71D56)
		{
			uint num = 183583722u;
			if (num != 1068236873)
			{
				num /= 746011458;
				base._002Ector();
				if (num >= 296051518)
				{
					return;
				}
			}
			num -= 1044528996;
			_215442A1 = _3CE71D56;
		}
	}

	private sealed class _18D4487E : _76587E10
	{
		private _582960B3 _073D5A4D;

		private Type _6F20748E;

		private object _0EBE1E35;

		public override bool _27B26B78()
		{
			uint num = 2015240131u;
			object obj = _0EBE1E35;
			num = 1864918030 - num;
			return obj != null;
		}

		public override short _72435997()
		{
			uint num = 1184509079u;
			return _073D5A4D._72435997();
		}

		public override TypeCode _09A801C9()
		{
			int size = IntPtr.Size;
			uint num = 1846181024u;
			if (size != 4)
			{
				return (TypeCode)((int)num + -1846181012);
			}
			num *= 139216955;
			return (TypeCode)(num - 1324857558);
		}

		public override sbyte _22B70934()
		{
			_582960B3 obj = _073D5A4D;
			uint num = 1151886029u;
			return obj._22B70934();
		}

		public override byte _70DF711E()
		{
			return _073D5A4D._70DF711E();
		}

		public override int _6AAF062D()
		{
			_582960B3 obj = _073D5A4D;
			uint num = 24191341u;
			return obj._6AAF062D();
		}

		public override IntPtr _47C01150()
		{
			uint num = 1452891922u;
			_582960B3 obj = _073D5A4D;
			num = 0x1BAA7B95 | num;
			return obj._47C01150();
		}

		public override void _727F3897(object _1C5622DC)
		{
			uint num = 316089872u;
			num = 1757227229 / num;
			_0EBE1E35 = _1C5622DC;
			num = 481844001 - num;
			num = 0x36751CED & num;
			_073D5A4D = _316D6085(_1C5622DC);
		}

		private unsafe static _582960B3 _316D6085(object _1769294F)
		{
			uint num = 150609921u;
			IntPtr intPtr;
			while (true)
			{
				if (_1769294F != null)
				{
					num = 554922795 * num;
					if (204021596 - num != 0)
					{
						num ^= 0x7BD56D4F;
						void* value = Pointer.Unbox(_1769294F);
						num = 2060458038u >> (int)num;
						intPtr = new IntPtr(value);
						break;
					}
					continue;
				}
				intPtr = IntPtr.Zero;
				num ^= 0xF572182;
				break;
			}
			IntPtr intPtr2 = intPtr;
			num &= 0x3D604BF0;
			int size = IntPtr.Size;
			num = 0xD744C59 & num;
			if (size == (int)(num ^ 0x5200004))
			{
				num = 0x52023C86 | num;
				num += 1458720863;
				return new _50424ADC(intPtr2.ToInt32());
			}
			num = 0xBE30232 & num;
			return new _66FF619D(intPtr2.ToInt64());
		}

		public override ulong _5ECF32BD()
		{
			uint num = 1004108350u;
			num = (uint)(1142624109 << (int)num);
			_582960B3 obj = _073D5A4D;
			num /= 794447976;
			return obj._5ECF32BD();
		}

		public override float _078008FE()
		{
			_582960B3 obj = _073D5A4D;
			uint num = 458444064u;
			return obj._078008FE();
		}

		public override object _7BBC17CC(Type _4D2A1C67, bool _67F45C72)
		{
			_582960B3 obj = _073D5A4D;
			uint num = 1507655689u;
			return obj._7BBC17CC(_4D2A1C67, _67F45C72);
		}

		public override uint _76377E70()
		{
			return _073D5A4D._76377E70();
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1958753877u;
			num %= 1361017392;
			object _04F76BC = _0EBE1E35;
			num *= 1984442933;
			return new _18D4487E(_04F76BC, _6F20748E);
		}

		public unsafe override void* _1AF75EB9()
		{
			uint num = 1155350848u;
			num /= 1319125112;
			return Pointer.Unbox(_0EBE1E35);
		}

		public override long _3E0F495D()
		{
			uint num = 1209803292u;
			return _073D5A4D._3E0F495D();
		}

		public static _582960B3 _3F20099B(_582960B3 _30BA3906, _582960B3 _0166726E, bool _370F7F73)
		{
			int _7A3475AA;
			uint num;
			do
			{
				IL_0000:
				num = 644815818u;
				if (!(_30BA3906 is _18D4487E))
				{
					num = 0x57292C9C & num;
					if (num == 32590436)
					{
						goto IL_0000;
					}
					goto IL_0028;
				}
				goto IL_003d;
				IL_0028:
				num += 1713185196;
				object obj = (_18D4487E)_0166726E;
				goto IL_0059;
				IL_003d:
				if (283321134 < num)
				{
					obj = (_18D4487E)_30BA3906;
					num += 1171721834;
					goto IL_0059;
				}
				goto IL_007f;
				IL_007f:
				num |= 0x24225B16;
				if (_370F7F73)
				{
					num = 195589758 - num;
					uint num2 = _30BA3906._76377E70();
					num += 1326012991;
					uint num3 = _0166726E._76377E70();
					num = 2089561540 % num;
					if (num / 1417368233 == 0)
					{
						if (num2 == num3)
						{
							num = 494080061 / num;
							_7A3475AA = (int)(num + 3);
							continue;
						}
						num ^= 0x61A44442;
						int num4;
						if (num2 <= num3)
						{
							num4 = (int)(num ^ 0x6EC9C63C);
						}
						else
						{
							num = 176058266 % num;
							num4 = (int)(num ^ 0xA7E6F98);
							num += 1682658970;
						}
						num %= 875039937;
						_7A3475AA = num4;
						if (628753807 / num == 0)
						{
							goto IL_0000;
						}
						num ^= 0x679ACB3;
						continue;
					}
				}
				else
				{
					num = 383796026 - num;
					num = 0x12DB43DF & num;
					int num5 = _30BA3906._6AAF062D();
					if (num < 820265193)
					{
						num ^= 0x7A550F44;
						int num6 = _0166726E._6AAF062D();
						num >>= 20;
						int num7 = num6;
						num = (uint)(1625512661 << (int)num);
						if (1639605014 % num != 0)
						{
							num = 1027110924 * num;
							if (num5 == num7)
							{
								num |= 0x5FFC2278;
								_7A3475AA = (int)(num - 1610605172);
								num ^= 0x5FFFE279;
								continue;
							}
							num = 0x68F22865 ^ num;
							num = 1924597673 + num;
							int num8;
							if (num5 <= num7)
							{
								num8 = (int)num - -1675300858;
							}
							else
							{
								num = 0x2C9D0C35 | num;
								num8 = (int)(num + 1128399811);
								num ^= 0x20990C31;
							}
							_7A3475AA = num8;
							if (2043677686 == num)
							{
								goto IL_0000;
							}
							num ^= 0x9C24F00Fu;
							continue;
						}
					}
				}
				goto IL_0028;
				IL_0059:
				num &= 0x59966B5;
				TypeCode num9 = ((_582960B3)obj)._09A801C9();
				uint num10 = num ^ 0x400223E;
				num &= 0xBE270A;
				if (num9 == (TypeCode)num10)
				{
					goto IL_007f;
				}
				if (_370F7F73)
				{
					ulong num11 = _30BA3906._5ECF32BD();
					if (176035341 < num)
					{
						goto IL_0000;
					}
					num = 646649883 * num;
					ulong num12 = _0166726E._5ECF32BD();
					num ^= 0x164C559B;
					ulong num13 = num12;
					if (784219669 / num != 0)
					{
						goto IL_0028;
					}
					if (num11 == num13)
					{
						uint num14 = num - 1870644119;
						num -= 771699430;
						_7A3475AA = (int)num14;
						num ^= 0x418090B4;
						continue;
					}
					num >>= 23;
					int num15;
					if (num11 <= num13)
					{
						num = 447354133 % num;
						num15 = (int)(num - 149);
					}
					else
					{
						num = 0x11EB44CF | num;
						num15 = (int)(num - 300631261);
						num ^= 0x11EB4442;
					}
					_7A3475AA = num15;
					num += 4294967140u;
					continue;
				}
				long num16 = _30BA3906._3E0F495D();
				num = 530327529 % num;
				if (1333474073 <= num)
				{
					goto IL_0028;
				}
				long num17 = _0166726E._3E0F495D();
				num = 1786191900 - num;
				long num18 = num17;
				num = 382033550 * num;
				if (1080891398 >= num)
				{
					goto IL_0000;
				}
				num = 1450782724 / num;
				if (num16 == num18)
				{
					uint num19 = num ^ 5;
					num -= 1481389854;
					_7A3475AA = (int)num19;
					if (607354681 == num)
					{
						goto IL_003d;
					}
					num ^= 0xA7B3C8E2u;
					continue;
				}
				if (num > 648822069)
				{
					goto IL_0028;
				}
				num = 1887186354 % num;
				int num20;
				if (num16 <= num18)
				{
					num |= 0x51942C48;
					num20 = (int)(num ^ 0x51942C40);
				}
				else
				{
					num20 = (int)(num ^ 2);
					num ^= 0x51942C48;
				}
				num = 1962961823 * num;
				_7A3475AA = num20;
				num ^= 0x818998B9u;
			}
			while (2134719387 < num);
			return new _50424ADC(_7A3475AA);
		}

		public override object _0936516D()
		{
			return _0EBE1E35;
		}

		public override UIntPtr _15842C84()
		{
			_582960B3 obj = _073D5A4D;
			uint num = 92231877u;
			return obj._15842C84();
		}

		public override Type _71C820E4()
		{
			uint num = 238816678u;
			return _6F20748E;
		}

		public override double _40F966AC()
		{
			_582960B3 obj = _073D5A4D;
			uint num = 1845524337u;
			return obj._40F966AC();
		}

		public override ushort _16D4371A()
		{
			return _073D5A4D._16D4371A();
		}

		public unsafe static _582960B3 _3979755E(_582960B3 _0B240269, _582960B3 _32C26FAA, bool _5DC638E7, bool _3B592BF1)
		{
			_18D4487E _18D4487E2;
			IntPtr intPtr;
			uint num;
			while (true)
			{
				IL_0000:
				_18D4487E obj = _0B240269 as _18D4487E;
				num = 1419789928u;
				if (obj == null)
				{
					goto IL_0012;
				}
				goto IL_001d;
				IL_001d:
				num = 134574820 - num;
				object obj2 = (_18D4487E)_0B240269;
				num ^= 0xE7C56A14u;
				goto IL_0037;
				IL_0037:
				num &= 0x6183649E;
				_18D4487E2 = (_18D4487E)obj2;
				long num2;
				if (num <= 1116561073)
				{
					while (_18D4487E2._09A801C9() != (TypeCode)(num ^ 0x40804402))
					{
						num = 22303411 - num;
						if (_3B592BF1)
						{
							goto IL_022c;
						}
						num ^= 0x44A602A;
						num /= 2004045456;
						num2 = _0B240269._3E0F495D();
						num = 857961669 % num;
						if (1695091277 < num)
						{
							continue;
						}
						goto IL_032a;
					}
					while (true)
					{
						num = 0x70E9583E ^ num;
						if (_3B592BF1)
						{
							goto IL_0073;
						}
						num *= 408843673;
						int num3 = _0B240269._6AAF062D();
						num -= 1335892421;
						int num4 = _32C26FAA._6AAF062D();
						if ((0x54DB128F & num) == 0)
						{
							break;
						}
						num *= 924804407;
						int num5;
						if (!_5DC638E7)
						{
							num &= 0x676045C6;
							num &= 0x2770740D;
							num5 = num3 + num4;
						}
						else
						{
							if (1412586676 + num == 0)
							{
								goto IL_0000;
							}
							num5 = checked(num3 + num4);
							num += 2952785741u;
						}
						num = 0x5D6F0142 ^ num;
						int num6 = num5;
						num += 3934354585u;
						goto IL_0199;
						IL_0073:
						num /= 464746336;
						uint num7 = _0B240269._76377E70();
						num = (uint)(1915434596 << (int)num);
						if (911936274 > num)
						{
							continue;
						}
						num >>= 12;
						uint num8 = _32C26FAA._76377E70();
						num %= 504642525;
						int num9;
						if (!_5DC638E7)
						{
							if ((num ^ 0x16F738A5) == 0)
							{
								goto IL_001d;
							}
							num += 1216493689;
							num9 = (int)(num7 + num8);
						}
						else
						{
							num = 2026579444 * num;
							if ((0x3F0A74C0 ^ num) == 0)
							{
								break;
							}
							num9 = (int)checked(num7 + num8);
							num += 1393334951;
						}
						num6 = num9;
						goto IL_0199;
						IL_0199:
						if (num <= 737622064)
						{
							break;
						}
						int value = num6;
						num = 0xB2454D5 & num;
						intPtr = new IntPtr(value);
						num -= 1395086546;
						if (num > 1437150361)
						{
							void* ptr = intPtr.ToPointer();
							num = 809399484 + num;
							object _04F76BC = Pointer.Box(ptr, _18D4487E2._71C820E4());
							num = 1734815647u >> (int)num;
							num ^= 0x742F3618;
							Type _78492022 = _18D4487E2._71C820E4();
							num = 209126211 * num;
							return new _18D4487E(_04F76BC, _78492022);
						}
						goto IL_0073;
					}
					goto IL_0012;
				}
				goto IL_001d;
				IL_0012:
				obj2 = (_18D4487E)_32C26FAA;
				goto IL_0037;
				IL_03c9:
				num |= 0x71B9644E;
				long num10;
				if (1482771449 != num)
				{
					long value2 = num10;
					num = 668628040u >> (int)num;
					IntPtr intPtr2 = new IntPtr(value2);
					num += 798560910;
					intPtr = intPtr2;
					if (num * 283911927 != 0)
					{
						break;
					}
					continue;
				}
				goto IL_001d;
				IL_022c:
				num &= 0x3F0D2CE6;
				ulong num11 = _0B240269._5ECF32BD();
				num = 0x8AB4CC1 & num;
				ulong num12 = num11;
				num = 2133737664u >> (int)num;
				num = 0x51A03524 & num;
				ulong num13 = _32C26FAA._5ECF32BD();
				num = 1459968357 * num;
				ulong num14 = num13;
				if (308312584 > num)
				{
					goto IL_0012;
				}
				long num15;
				if (!_5DC638E7)
				{
					num ^= 0x588C6BE8;
					if (111959951 + num == 0)
					{
						goto IL_001d;
					}
					num <<= 7;
					num *= 780018039;
					num15 = (long)(num12 + num14);
				}
				else
				{
					num = 0x338E52C1 | num;
					num = 0x67733E8B ^ num;
					num &= 0x623F1FE9;
					num15 = (long)checked(num12 + num14);
					num += 2674614200u;
				}
				num |= 0x4D243017;
				num10 = num15;
				goto IL_03c9;
				IL_032a:
				num = 244601454 - num;
				long num16 = _32C26FAA._3E0F495D();
				num = (uint)(369177522 << (int)num);
				long num17 = num16;
				num = (uint)(1816357258 << (int)num);
				num &= 0x39E91ACC;
				long num18;
				if (!_5DC638E7)
				{
					if (num > 1573223033)
					{
						continue;
					}
					num = 605584899 / num;
					num = 42099064u >> (int)num;
					num18 = num2 + num17;
				}
				else
				{
					num = 0xC47746C & num;
					num18 = checked(num2 + num17);
					num ^= 0xAC36170;
				}
				num >>= 7;
				num10 = num18;
				num += 3752294229u;
				goto IL_03c9;
			}
			num = 833553641 % num;
			void* ptr2 = intPtr.ToPointer();
			num %= 932129466;
			num <<= 20;
			Type type = _18D4487E2._71C820E4();
			num = 687764043 % num;
			return new _18D4487E(Pointer.Box(ptr2, type), _18D4487E2._71C820E4());
		}

		public unsafe static _582960B3 _32DC6BCE(_582960B3 _181068EE, _582960B3 _09D43316, bool _00243868, bool _03820FF8)
		{
			uint num = 1388926916u;
			IntPtr intPtr2;
			_18D4487E _18D4487E2 = default(_18D4487E);
			while (true)
			{
				if (!(_181068EE is _18D4487E))
				{
					num = 759971623 + num;
					goto IL_0019;
				}
				goto IL_0024;
				IL_02f0:
				long num2 = _181068EE._3E0F495D();
				if (num > 451755613)
				{
					goto IL_0024;
				}
				num &= 0x2B680CF9;
				long num3 = _09D43316._3E0F495D();
				num %= 532487723;
				long num4 = num3;
				num |= 0x1669573F;
				if (num == 1661683859)
				{
					goto IL_0019;
				}
				long num5;
				if (!_00243868)
				{
					num5 = num2 - num4;
				}
				else
				{
					if (num == 457325837)
					{
						goto IL_0019;
					}
					num = (uint)(224145822 << (int)num);
					num5 = checked(num2 - num4);
					num += 392779583;
				}
				num += 1030694587;
				long num6 = num5;
				num ^= 0x54DE75EE;
				goto IL_0375;
				IL_0024:
				num = 809656319 * num;
				object obj;
				if (num > 270955401)
				{
					num = 0x79A558CC ^ num;
					obj = (_18D4487E)_181068EE;
					num ^= 0x7718E61B;
					goto IL_004d;
				}
				goto IL_0095;
				IL_0375:
				num = 938356030 / num;
				if (num < 509418378)
				{
					long value = num6;
					num = 732103131 % num;
					IntPtr intPtr = new IntPtr(value);
					num %= 356201872;
					intPtr2 = intPtr;
					num ^= 0x7F2445D5;
					if ((num ^ 0x1E226ADE) != 0)
					{
						break;
					}
				}
				continue;
				IL_0095:
				num &= 0x2D8B3D0E;
				int num11;
				if (_03820FF8)
				{
					if (num - 2118861030 == 0)
					{
						goto IL_0019;
					}
					num = 881204070 - num;
					uint num7 = _181068EE._76377E70();
					if (1710235849 <= num)
					{
						continue;
					}
					num = 344871676 % num;
					uint num8 = _09D43316._76377E70();
					num = 166075424 / num;
					uint num9 = num8;
					num = (uint)(1301635426 << (int)num);
					int num10;
					if (!_00243868)
					{
						num %= 1618572443;
						num10 = (int)(num7 - num9);
					}
					else
					{
						if (num <= 847652322)
						{
							goto IL_0019;
						}
						num10 = (int)checked(num7 - num9);
						num += 0;
					}
					num += 118324596;
					num11 = num10;
				}
				else
				{
					num = (uint)(453517762 << (int)num);
					int num12 = _181068EE._6AAF062D();
					if (54157397 >>> (int)num == 0)
					{
						goto IL_0019;
					}
					int num13 = _09D43316._6AAF062D();
					num = (uint)(1618693177 << (int)num);
					int num14 = num13;
					if (num == 1776713279)
					{
						continue;
					}
					int num15;
					if (!_00243868)
					{
						if (num == 528905128)
						{
							continue;
						}
						num = 1647786674 - num;
						num15 = num12 - num14;
					}
					else
					{
						num = 431254573 + num;
						num15 = checked(num12 - num14);
						num ^= 0x7B94561F;
					}
					num11 = num15;
					num ^= 0x551930AF;
				}
				num = 1598884967 % num;
				int value2 = num11;
				num |= 0x21B10803;
				IntPtr intPtr3 = new IntPtr(value2);
				num = 1065563926 - num;
				intPtr2 = intPtr3;
				if (num * 1088897697 != 0)
				{
					object _04F76BC = Pointer.Box(intPtr2.ToPointer(), _18D4487E2._71C820E4());
					num >>= 23;
					_18D4487E obj2 = _18D4487E2;
					num = 1754279790 + num;
					return new _18D4487E(_04F76BC, obj2._71C820E4());
				}
				goto IL_0019;
				IL_004d:
				num = 1955944371 - num;
				_18D4487E2 = (_18D4487E)obj;
				num /= 1681064761;
				while (true)
				{
					_18D4487E obj3 = _18D4487E2;
					num /= 623652322;
					TypeCode num16 = obj3._09A801C9();
					uint num17 = num + 10;
					num = 0x6BB0BB8 | num;
					if (num16 == (TypeCode)num17)
					{
						break;
					}
					num /= 982531113;
					num = 0x27EA1D4B & num;
					if (_03820FF8)
					{
						goto IL_022c;
					}
					num |= 0x71A1301;
					if (985732749 / num == 0)
					{
						continue;
					}
					goto IL_02f0;
				}
				num -= 52241403;
				if (num > 1556770381)
				{
					goto IL_0024;
				}
				goto IL_0095;
				IL_0019:
				obj = (_18D4487E)_09D43316;
				goto IL_004d;
				IL_022c:
				num %= 1811239595;
				ulong num18 = _181068EE._5ECF32BD();
				num = 0x7393339A | num;
				ulong num19 = num18;
				num |= 0x15C813A4;
				if (69939320 / num != 0)
				{
					goto IL_0019;
				}
				num = 1087113793 * num;
				ulong num20 = _09D43316._5ECF32BD();
				num = 1633496411 % num;
				ulong num21 = num20;
				if ((0x71141A65 & num) == 0)
				{
					continue;
				}
				long num22;
				if (!_00243868)
				{
					num *= 65235215;
					if (num + 468931637 == 0)
					{
						continue;
					}
					num >>= 11;
					num22 = (long)(num19 - num21);
				}
				else
				{
					num = 677318194 * num;
					num = 206386535 % num;
					num22 = (long)checked(num19 - num21);
					num ^= 0xC4BAD78;
				}
				num = 0x3D6E2FF4 & num;
				num6 = num22;
				if (1718045908 / num == 0)
				{
					continue;
				}
				goto IL_0375;
			}
			object _04F76BC2 = Pointer.Box(intPtr2.ToPointer(), _18D4487E2._71C820E4());
			_18D4487E obj4 = _18D4487E2;
			num = 0x58302F2A | num;
			Type _78492022 = obj4._71C820E4();
			num = 0x6FBA3641 | num;
			return new _18D4487E(_04F76BC2, _78492022);
		}

		public _18D4487E(object _04F76BC8, Type _67192248)
		{
			uint num;
			do
			{
				num = 2064864106u;
				num *= 427709484;
				_0EBE1E35 = _04F76BC8;
				num = 0x43494C83 ^ num;
				num /= 36009967;
				num = 1919029242 / num;
				_6F20748E = _67192248;
				num /= 1609977669;
				_073D5A4D = _316D6085(_04F76BC8);
			}
			while (num - 1023017114 == 0);
		}
	}

	private sealed class _49826529 : _76587E10
	{
		private object _7D6C7FDE;

		public override Type _71C820E4()
		{
			uint num = 1446079074u;
			num = 1221460495 + num;
			return typeof(ValueType);
		}

		public override object _0936516D()
		{
			uint num = 1699052664u;
			return _7D6C7FDE;
		}

		public override void _727F3897(object _740214F0)
		{
			if (_740214F0 == null || _740214F0 is ValueType)
			{
				uint num = 1156466780u;
				if (1232825278 >= num)
				{
					_7D6C7FDE = _740214F0;
					return;
				}
			}
			throw new ArgumentException();
		}

		public override _582960B3 _5C7710FF()
		{
			object obj2 = default(object);
			uint num;
			while (true)
			{
				IL_0000:
				num = 1077180963u;
				object obj = _7D6C7FDE;
				num = 1372734064 + num;
				if (obj == null)
				{
					num %= 52964344;
					if (472787575u >> (int)num != 0)
					{
						goto IL_0033;
					}
				}
				else
				{
					while (true)
					{
						IL_004e:
						num = 92481698 * num;
						Type type = _7D6C7FDE.GetType();
						num *= 1709013634;
						int bindingAttr = (int)num + -1886386392;
						num &= 0x487B20B0;
						FieldInfo[] fields = type.GetFields((BindingFlags)bindingAttr);
						num = 0x6635402C & num;
						FieldInfo[] array = fields;
						obj2 = Activator.CreateInstance(type);
						if (1698462544 < num)
						{
							break;
						}
						num |= 0x4A012EF3;
						FieldInfo[] array2 = array;
						int num2 = (int)num + -1243688691;
						if (num <= 951060638)
						{
							goto IL_0000;
						}
						while (num >> 6 != 0)
						{
							int num3 = num2;
							IntPtr intPtr = (nint)array2.LongLength;
							num >>= 30;
							if (num3 < (int)(nint)intPtr)
							{
								num = 973437868u;
								FieldInfo obj3 = array2[num2];
								num *= 2116421703;
								FieldInfo fieldInfo = obj3;
								num = 0x501D4584 | num;
								object obj4 = obj2;
								num = 0x3CA216C4 ^ num;
								object obj5 = _7D6C7FDE;
								num = (uint)(1178761159 << (int)num);
								object? value = fieldInfo.GetValue(obj5);
								num = 226366266 / num;
								fieldInfo.SetValue(obj4, value);
								if (699095509 < num)
								{
									goto IL_004e;
								}
								int num4 = num2;
								uint num5 = num ^ 1;
								num &= 0x6B1178CE;
								int num6 = num4 + (int)num5;
								num = (uint)(1410088866 << (int)num);
								num2 = num6;
								num += 4128567121u;
								continue;
							}
							goto IL_015d;
						}
						goto IL_0033;
						IL_015d:
						num ^= 0x603;
						break;
					}
				}
				goto IL_0165;
				IL_0165:
				if (num + 76612561 != 0)
				{
					break;
				}
				goto IL_0033;
				IL_0033:
				num = 0x39002F92 & num;
				obj2 = null;
				if (num / 976035492 != 0)
				{
					continue;
				}
				goto IL_0165;
			}
			object _78492022 = obj2;
			num ^= 0x6198482B;
			return new _49826529(_78492022);
		}

		public _49826529(object _50066491)
		{
			uint num;
			do
			{
				IL_0000:
				num = 400892252u;
				base._002Ector();
				num >>= 9;
				if (_50066491 != null)
				{
					num += 1405237406;
					if ((num & 0x2F822E83) == 0)
					{
						goto IL_0000;
					}
					ValueType obj = _50066491 as ValueType;
					num += 2889729890u;
					if (obj == null)
					{
						throw new ArgumentException();
					}
				}
				num = 1647318160 + num;
			}
			while (num < 490219077);
			num = 1970150197 % num;
			_7D6C7FDE = _50066491;
		}
	}

	private sealed class _28B24C0E : _76587E10
	{
		private Array _7D72066C;

		public override Type _71C820E4()
		{
			return typeof(Array);
		}

		public override bool _27B26B78()
		{
			Array array = _7D72066C;
			uint num = 1735787020u;
			return array != null;
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1521095189u;
			num = (uint)(913931209 << (int)num);
			return new _28B24C0E(_7D72066C);
		}

		public override void _727F3897(object _373A2952)
		{
			uint num = 1658009439u;
			do
			{
				num -= 1491094518;
				num -= 361445646;
				Array obj = (Array)_373A2952;
				num %= 2140029617;
				_7D72066C = obj;
			}
			while (627646020 > num);
		}

		public override object _0936516D()
		{
			return _7D72066C;
		}

		public _28B24C0E(Array _04025376)
		{
			_7D72066C = _04025376;
		}
	}

	private abstract class _5C8E334C : _76587E10
	{
		protected _5C8E334C()
		{
			uint num = 1962825773u;
			if (num % 1403667247 != 0)
			{
				num = 1286425023 % num;
				base._002Ector();
			}
		}

		public override bool _11EF2F40()
		{
			uint num = 2114270967u;
			return (byte)(num ^ 0x7E0536F6) != 0;
		}
	}

	private sealed class _2D9A5DA0 : _5C8E334C
	{
		private _582960B3 _75112056;

		public override bool _27B26B78()
		{
			uint num = 1967462169u;
			num = 0x332C2C48 ^ num;
			_582960B3 obj = _75112056;
			num /= 653810336;
			return Unsafe.As<_582960B3, UIntPtr>(ref obj) > Unsafe.As<@null, UIntPtr>(ref null);
		}

		public override void _727F3897(object _2F414356)
		{
			uint num = 990065628u;
			do
			{
				_582960B3 obj = _75112056;
				num <<= 9;
				obj._727F3897(_2F414356);
			}
			while (num >= 1164596763);
		}

		public override void _53112B56(FieldInfo _3EE65A3C, object _7DDE12FC)
		{
			uint num = 1193099134u;
			num = 0x1E7D38A3 | num;
			_582960B3 obj = _75112056;
			num %= 840648477;
			obj._53112B56(_3EE65A3C, _7DDE12FC);
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1311579084u;
			return new _2D9A5DA0(_75112056);
		}

		public override Type _71C820E4()
		{
			uint num = 1743923319u;
			return _75112056._71C820E4();
		}

		public override object _0936516D()
		{
			uint num = 1924946389u;
			return _75112056._0936516D();
		}

		public _2D9A5DA0(_582960B3 _70C06888)
		{
			uint num = 983660228u;
			num %= 943399949;
			base._002Ector();
			do
			{
				_75112056 = _70C06888;
			}
			while ((0x42C74F67 ^ num) == 0);
		}
	}

	private sealed class _12C661FB : _76587E10
	{
		private _582960B3 _3D1D3E76;

		public override ulong _5ECF32BD()
		{
			_582960B3 obj = _3D1D3E76;
			uint num = 1489970310u;
			ulong result = obj._5ECF32BD();
			num = 1824551071 * num;
			Thread.MemoryBarrier();
			return result;
		}

		public override uint _76377E70()
		{
			uint num = 1010335336u;
			_582960B3 obj = _3D1D3E76;
			num -= 102071025;
			uint result = obj._76377E70();
			Thread.MemoryBarrier();
			return result;
		}

		public override void _53112B56(FieldInfo _54AB41C3, object _22261569)
		{
			uint num = 484987281u;
			do
			{
				Thread.MemoryBarrier();
				num = (uint)(1476209862 << (int)num);
			}
			while (387457052 / num != 0);
			num <<= 23;
			_582960B3 obj = _3D1D3E76;
			num = (uint)(1207069422 << (int)num);
			num += 1105214683;
			obj._53112B56(_54AB41C3, _22261569);
		}

		public override TypeCode _09A801C9()
		{
			uint num = 302860327u;
			num += 418194568;
			_582960B3 obj = _3D1D3E76;
			num *= 779309751;
			return obj._09A801C9();
		}

		public override Type _71C820E4()
		{
			_582960B3 obj = _3D1D3E76;
			uint num = 2047632795u;
			return obj._71C820E4();
		}

		public override byte _70DF711E()
		{
			uint num = 866721056u;
			_582960B3 obj = _3D1D3E76;
			num = 190801952u >> (int)num;
			byte result = obj._70DF711E();
			num %= 261311244;
			Thread.MemoryBarrier();
			return result;
		}

		public override int _6AAF062D()
		{
			int result = _3D1D3E76._6AAF062D();
			uint num = 1560430146u;
			Thread.MemoryBarrier();
			return result;
		}

		public override short _72435997()
		{
			uint num = 780672050u;
			short result = _3D1D3E76._72435997();
			Thread.MemoryBarrier();
			return result;
		}

		public override _76587E10 _689700D4()
		{
			uint num = 1174306129u;
			return this;
		}

		public override _582960B3 _5C7710FF()
		{
			throw new InvalidOperationException();
		}

		public override bool _11EF2F40()
		{
			uint num = 1068577601u;
			num /= 1877948437;
			return _3D1D3E76._11EF2F40();
		}

		public override bool _27B26B78()
		{
			_582960B3 obj = _3D1D3E76;
			uint num = 671170698u;
			bool result = obj._27B26B78();
			num ^= 0x391301C1;
			Thread.MemoryBarrier();
			return result;
		}

		public override object _0936516D()
		{
			uint num = 1050285124u;
			_582960B3 obj = _3D1D3E76;
			num = 0x3BAB5E5B ^ num;
			object result = obj._0936516D();
			Thread.MemoryBarrier();
			return result;
		}

		public override void _727F3897(object _1C0D4DC9)
		{
			while (true)
			{
				Thread.MemoryBarrier();
				uint num = 1869830132u;
				if (num > 152311081)
				{
					_582960B3 obj = _3D1D3E76;
					num -= 590680930;
					obj._727F3897(_1C0D4DC9);
					if (num != 1492398521)
					{
						break;
					}
				}
			}
		}

		public override ushort _16D4371A()
		{
			uint num = 1531851260u;
			num = 0x17EC6A9E ^ num;
			ushort result = _3D1D3E76._16D4371A();
			Thread.MemoryBarrier();
			return result;
		}

		public override long _3E0F495D()
		{
			uint num = 967842183u;
			_582960B3 obj = _3D1D3E76;
			num = 0x65E93289 ^ num;
			long result = obj._3E0F495D();
			num |= 0x25653A15;
			Thread.MemoryBarrier();
			return result;
		}

		public override double _40F966AC()
		{
			double result = _3D1D3E76._40F966AC();
			Thread.MemoryBarrier();
			return result;
		}

		public override sbyte _22B70934()
		{
			sbyte result = _3D1D3E76._22B70934();
			Thread.MemoryBarrier();
			return result;
		}

		public override float _078008FE()
		{
			uint num = 1205213124u;
			float result = _3D1D3E76._078008FE();
			Thread.MemoryBarrier();
			return result;
		}

		public _12C661FB(_582960B3 _72CA7398)
		{
			uint num = 129330761u;
			base._002Ector();
			num |= 0x2C484B33;
			_3D1D3E76 = _72CA7398;
		}
	}

	private sealed class _47F23E32 : _5C8E334C
	{
		private _582960B3 _59117C3A;

		private _582960B3 _0CFF3262;

		public override void _727F3897(object _06692033)
		{
			uint num = 1399944547u;
			do
			{
				num |= 0x653B4271;
				_582960B3 obj = _0CFF3262;
				num &= 0x7C222BAC;
				obj._727F3897(_06692033);
				num %= 1022245590;
				_582960B3 obj2 = _59117C3A;
				num = 194707965 + num;
				object _63C = _0CFF3262._0936516D();
				num /= 1520770457;
				obj2._727F3897(_63C);
			}
			while (num / 1456935800 != 0);
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 124474535u;
			return new _47F23E32(_0CFF3262, _59117C3A);
		}

		public override Type _71C820E4()
		{
			uint num = 1179210857u;
			return _0CFF3262._71C820E4();
		}

		public override object _0936516D()
		{
			uint num = 405347357u;
			return _0CFF3262._0936516D();
		}

		public override bool _27B26B78()
		{
			uint num = 1001281136u;
			_582960B3 obj = _0CFF3262;
			num = 0x1DA512CD | num;
			num = 362244018u >> (int)num;
			return Unsafe.As<_582960B3, UIntPtr>(ref obj) > Unsafe.As<@null, UIntPtr>(ref null);
		}

		public _47F23E32(_582960B3 _664F7AFF, _582960B3 _639562CF)
		{
			uint num = 1192693424u;
			base._002Ector();
			num = (uint)(374476903 << (int)num);
			_0CFF3262 = _664F7AFF;
			num = 0x29326CB & num;
			num = 0x2926729 & num;
			_59117C3A = _639562CF;
		}
	}

	private sealed class _4287017A : _5C8E334C
	{
		private _582960B3 _27D010B5;

		private FieldInfo _4CAA7E4F;

		public override void _727F3897(object _735B2B79)
		{
			uint num = 1515718791u;
			do
			{
				num = 1501172365 + num;
				_582960B3 obj = _27D010B5;
				FieldInfo _552E = _4CAA7E4F;
				num |= 0x29F91C42;
				obj._53112B56(_552E, _735B2B79);
			}
			while (num < 1350515072);
		}

		public override object _0936516D()
		{
			uint num = 986213009u;
			if ((0x55686A56 ^ num) != 0)
			{
				goto IL_0012;
			}
			goto IL_00ab;
			IL_0012:
			while (true)
			{
				num &= 0x226466E4;
				Type type = _27D010B5._71C820E4();
				num = 0x18E256EF ^ num;
				if (!type.IsPointer)
				{
					break;
				}
				num /= 1655922300;
				if (469006095 < num)
				{
					continue;
				}
				goto IL_004a;
			}
			goto IL_0077;
			IL_00f1:
			object obj2;
			object obj = obj2;
			if (num + 1510494713 != 0)
			{
				num -= 1123050398;
				FieldInfo fieldInfo = _4CAA7E4F;
				num = 0x2AB51DDD ^ num;
				return fieldInfo.GetValue(obj);
			}
			goto IL_0012;
			IL_004a:
			num <<= 9;
			bool isValueType = _4CAA7E4F.DeclaringType.IsValueType;
			num = 345722660 + num;
			if (!isValueType)
			{
				num += 637986123;
				goto IL_0077;
			}
			goto IL_00ab;
			IL_00ab:
			if (num <= 239206463)
			{
				goto IL_0012;
			}
			num = 0x6D3B54F6 | num;
			IntPtr ptr = _27D010B5._47C01150();
			num = 1135751863 / num;
			FieldInfo fieldInfo2 = _4CAA7E4F;
			num /= 457843203;
			obj2 = Marshal.PtrToStructure(ptr, fieldInfo2.DeclaringType);
			num ^= 0x1FC20000;
			goto IL_00f1;
			IL_0077:
			num >>= 27;
			num = 945035510u >> (int)num;
			_582960B3 obj3 = _27D010B5;
			num = (uint)(209326049 << (int)num);
			obj2 = obj3._0936516D();
			goto IL_00f1;
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1181752350u;
			FieldInfo _488D58F = _4CAA7E4F;
			num += 257392346;
			_582960B3 _08EE4CD = _27D010B5;
			num = 1945830420 - num;
			return new _4287017A(_488D58F, _08EE4CD);
		}

		public override Type _71C820E4()
		{
			return _4CAA7E4F.FieldType;
		}

		public _4287017A(FieldInfo _488D58F8, _582960B3 _08EE4CD9)
		{
			uint num = 623339317u;
			base._002Ector();
			num += 1681920213;
			num = 755049565 % num;
			num = 0xF4647AF ^ num;
			_4CAA7E4F = _488D58F8;
			if (num <= 769226337)
			{
				num = (uint)(759521442 << (int)num);
				_27D010B5 = _08EE4CD9;
			}
		}
	}

	private sealed class _581261AF : _5C8E334C
	{
		private int _1C813D7A;

		private Array _6912772F;

		public override void _53112B56(FieldInfo _5F683FBB, object _7DF2702D)
		{
			uint num = 1435664246u;
			object obj = default(object);
			if (1374108069 < num)
			{
				obj = _0936516D();
				if (num == 349050690)
				{
					goto IL_0033;
				}
			}
			_5F683FBB.SetValue(obj, _7DF2702D);
			num &= 0x3ECF0F97;
			goto IL_0033;
			IL_0033:
			ValueType obj2 = obj as ValueType;
			num = 395323620 % num;
			if (obj2 != null && 162601349 >= num)
			{
				num |= 0x5CFB18A0;
				_727F3897(obj);
				num += 2735669216u;
			}
		}

		public override _582960B3 _5C7710FF()
		{
			Array _1F = _6912772F;
			uint num = 476471271u;
			int _0E1A074A = _1C813D7A;
			num &= 0x7A077F9;
			return new _581261AF(_1F, _0E1A074A);
		}

		public override void _727F3897(object _738A7938)
		{
			while (true)
			{
				uint num = 1915296165u;
				Array array = _6912772F;
				num = (uint)(1594892811 << (int)num);
				Type type = array.GetType();
				num = 1957500178 % num;
				Type? elementType = type.GetElementType();
				num |= 0x444F26D0;
				TypeCode typeCode = Type.GetTypeCode(elementType);
				if (num < 1610569335)
				{
					continue;
				}
				while (true)
				{
					num = 1782459643 + num;
					int num2 = (int)num - -550673207;
					num = 0x7A7426D8 & num;
					TypeCode num3 = typeCode - num2;
					num = (uint)(1813250174 << (int)num);
					switch (num3)
					{
					case TypeCode.Object:
					{
						if (1217099127 == num)
						{
							break;
						}
						object value4 = _738A7938;
						num &= 0x55D85104;
						sbyte num8 = Convert.ToSByte(value4);
						num -= 2092461476;
						object obj6 = num8;
						num = 1810699994 * num;
						_738A7938 = obj6;
						num ^= 0x17D6D458;
						goto default;
					}
					case TypeCode.DBNull:
					{
						num = 0x238D5B9C ^ num;
						if (num * 900878514 == 0)
						{
							break;
						}
						object value3 = _738A7938;
						num += 2092586725;
						object obj4 = Convert.ToByte(value3);
						num += 721576864;
						_738A7938 = obj4;
						if (num % 1171027338 == 0)
						{
							break;
						}
						num += 884383199;
						goto default;
					}
					case TypeCode.Empty:
					{
						object obj = Convert.ToChar(_738A7938);
						num = (uint)(1262683636 << (int)num);
						_738A7938 = obj;
						if ((num & 0x1E0538) == 0)
						{
							break;
						}
						num += 3367860236u;
						goto default;
					}
					case TypeCode.Boolean:
					{
						num = 513687990 / num;
						short num9 = Convert.ToInt16(_738A7938);
						num = 1633813287 * num;
						_738A7938 = num9;
						num += 2996730585u;
						goto default;
					}
					case TypeCode.Char:
					{
						if ((num ^ 0x3CF24E99) == 0)
						{
							continue;
						}
						ushort num7 = Convert.ToUInt16(_738A7938);
						num = 1447052746 * num;
						object obj5 = num7;
						num -= 10517117;
						_738A7938 = obj5;
						num ^= 0x7DB88F83;
						goto default;
					}
					case TypeCode.SByte:
					{
						if (num >= 1975861262)
						{
							break;
						}
						object obj3 = Convert.ToInt32(_738A7938);
						num = 220469541 % num;
						_738A7938 = obj3;
						num ^= 0x19246725;
						goto default;
					}
					case TypeCode.Byte:
					{
						uint num6 = Convert.ToUInt32(_738A7938);
						num = 1347438349 - num;
						_738A7938 = num6;
						if (num + 688723576 == 0)
						{
							break;
						}
						num += 3618682099u;
						goto default;
					}
					case TypeCode.Int16:
					{
						long num5 = Convert.ToInt64(_738A7938);
						num = 55201141 * num;
						object obj2 = num5;
						num %= 1478299389;
						_738A7938 = obj2;
						num ^= 0x11E50606;
						goto default;
					}
					case TypeCode.UInt16:
						num = (uint)(186127680 << (int)num);
						if (num <= 804867343)
						{
							object value = _738A7938;
							num <<= 11;
							ulong num4 = Convert.ToUInt64(value);
							num = 832843978 * num;
							_738A7938 = num4;
							num ^= 0xF2247E00u;
						}
						goto default;
					default:
						if (num >> 17 != 0)
						{
							num ^= 0x64395B63;
							Array array2 = _6912772F;
							object value2 = _738A7938;
							num *= 922320379;
							int index = _1C813D7A;
							num = 1242893249u >> (int)num;
							array2.SetValue(value2, index);
							if (1296766377u >> (int)num != 0)
							{
								return;
							}
						}
						break;
					}
					break;
				}
			}
		}

		public override object _0936516D()
		{
			uint num = 1996707936u;
			Array array = _6912772F;
			num ^= 0x72735D7A;
			return array.GetValue(_1C813D7A);
		}

		public override Type _71C820E4()
		{
			uint num = 48500232u;
			return _6912772F.GetType().GetElementType();
		}

		public _581261AF(Array _1F131644, int _0E1A074A)
		{
			uint num = 1316495535u;
			while (true)
			{
				num = 0x1550B5C & num;
				base._002Ector();
				if (599396892 != num)
				{
					num = 1564758950 / num;
					num = 0x22B5FE4 ^ num;
					_6912772F = _1F131644;
					num -= 2036694844;
					num += 347438883;
					_1C813D7A = _0E1A074A;
					if ((0x3E6B0B0E ^ num) != 0)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class _4C96047E : _76587E10
	{
		private MethodBase _24DE33AC;

		public override _582960B3 _5C7710FF()
		{
			uint num = 811036042u;
			MethodBase _36B7196A = _24DE33AC;
			num = 1442594301 - num;
			return new _4C96047E(_36B7196A);
		}

		public override void _727F3897(object _4ED01F6D)
		{
			uint num;
			do
			{
				num = 1083667165u;
				_24DE33AC = (MethodBase)_4ED01F6D;
			}
			while (num / 1942047184 != 0);
		}

		public override IntPtr _47C01150()
		{
			uint num = 691875265u;
			RuntimeMethodHandle runtimeMethodHandle = default(RuntimeMethodHandle);
			if (num <= 760508814)
			{
				RuntimeMethodHandle methodHandle = _24DE33AC.MethodHandle;
				num %= 580406253;
				runtimeMethodHandle = methodHandle;
			}
			num %= 1887136474;
			return runtimeMethodHandle.GetFunctionPointer();
		}

		public override object _0936516D()
		{
			uint num = 2052459419u;
			num = 0x71F0278E | num;
			return _24DE33AC;
		}

		public override Type _71C820E4()
		{
			uint num = 163979831u;
			return typeof(MethodBase);
		}

		public override bool _27B26B78()
		{
			uint num = 1530486464u;
			return _24DE33AC != null;
		}

		public _4C96047E(MethodBase _36B7196A)
		{
			uint num;
			do
			{
				base._002Ector();
				num = 1283811091u;
			}
			while (num < 299042821);
			do
			{
				num -= 68291088;
				num += 819482066;
				_24DE33AC = _36B7196A;
			}
			while (1632643774 == num);
		}
	}

	private sealed class _515B561F : _76587E10
	{
		private _582960B3 _1FE330CB;

		private IntPtr _5F1C4BFC;

		public override int _6AAF062D()
		{
			uint num = 1703025509u;
			return _1FE330CB._6AAF062D();
		}

		public override ushort _16D4371A()
		{
			uint num = 842931522u;
			num = 1205496925 / num;
			return _1FE330CB._16D4371A();
		}

		private static _582960B3 _5DE71D3B(IntPtr _6BD26882)
		{
			int size = IntPtr.Size;
			uint num = 742077361u;
			uint num2 = num ^ 0x2C3B33B5;
			num >>= 13;
			if (size == (int)num2)
			{
				num = (uint)(705904508 << (int)num);
				if (num >= 1916891748)
				{
					num *= 1739550999;
					return new _50424ADC(_6BD26882.ToInt32());
				}
			}
			num = 1120220440u >> (int)num;
			num &= 0x4B7F1348;
			long _52CC445F = _6BD26882.ToInt64();
			num = 0x7974582E ^ num;
			return new _66FF619D(_52CC445F);
		}

		public override UIntPtr _15842C84()
		{
			return _1FE330CB._15842C84();
		}

		public override float _078008FE()
		{
			uint num = 1369119249u;
			_582960B3 obj = _1FE330CB;
			num = (uint)(1711166955 << (int)num);
			return obj._078008FE();
		}

		public override uint _76377E70()
		{
			_582960B3 obj = _1FE330CB;
			uint num = 512511484u;
			return obj._76377E70();
		}

		public override short _72435997()
		{
			return _1FE330CB._72435997();
		}

		public override object _0936516D()
		{
			IntPtr intPtr = _5F1C4BFC;
			uint num = 2126867617u;
			return intPtr;
		}

		public override _582960B3 _5C7710FF()
		{
			return new _515B561F(_5F1C4BFC);
		}

		public override IntPtr _47C01150()
		{
			uint num = 1177910184u;
			num >>= 21;
			return _5F1C4BFC;
		}

		public override double _40F966AC()
		{
			uint num = 1356213560u;
			return _1FE330CB._40F966AC();
		}

		public override ulong _5ECF32BD()
		{
			return _1FE330CB._5ECF32BD();
		}

		public override bool _27B26B78()
		{
			uint num = 1922111037u;
			IntPtr intPtr = _5F1C4BFC;
			num = 0x9917A56 ^ num;
			IntPtr zero = IntPtr.Zero;
			num = 1964798033 % num;
			return intPtr != zero;
		}

		public override Type _71C820E4()
		{
			uint num = 1431008160u;
			num |= 0x408B3D9E;
			return typeof(IntPtr);
		}

		public override TypeCode _09A801C9()
		{
			_582960B3 obj = _1FE330CB;
			uint num = 724644206u;
			return obj._09A801C9();
		}

		public override object _7BBC17CC(Type _2C6631D0, bool _717D3925)
		{
			uint num = 1659463278u;
			_582960B3 obj = _1FE330CB;
			num = 941884798 - num;
			num = 10445333u >> (int)num;
			return obj._7BBC17CC(_2C6631D0, _717D3925);
		}

		public override sbyte _22B70934()
		{
			return _1FE330CB._22B70934();
		}

		public unsafe override void* _1AF75EB9()
		{
			uint num = 362424799u;
			num = (uint)(1051923800 << (int)num);
			return _5F1C4BFC.ToPointer();
		}

		public override void _727F3897(object _2ACF25DC)
		{
			uint num = 386690424u;
			do
			{
				num = 791765065 * num;
				IntPtr intPtr = (IntPtr)_2ACF25DC;
				num *= 1991000876;
				_5F1C4BFC = intPtr;
			}
			while (num < 139528900);
			num <<= 4;
			_582960B3 obj = _5DE71D3B(_5F1C4BFC);
			num = 0x751615CB | num;
			_1FE330CB = obj;
		}

		public override byte _70DF711E()
		{
			_582960B3 obj = _1FE330CB;
			uint num = 1858156721u;
			return obj._70DF711E();
		}

		public override long _3E0F495D()
		{
			uint num = 1692211632u;
			_582960B3 obj = _1FE330CB;
			num = 0x5EA77413 | num;
			return obj._3E0F495D();
		}

		public _515B561F(IntPtr _06C6674A)
		{
			uint num = 2134528152u;
			base._002Ector();
			do
			{
				num -= 808472478;
				_5F1C4BFC = _06C6674A;
			}
			while (184433699 >= num);
			num = 1239820141 / num;
			num -= 1743920293;
			IntPtr _6BD = _5F1C4BFC;
			num = 0x5E885821 | num;
			_1FE330CB = _5DE71D3B(_6BD);
		}
	}

	private sealed class _51773792 : _76587E10
	{
		private _582960B3 _0D172508;

		private UIntPtr _341E0811;

		public override float _078008FE()
		{
			uint num = 1039013573u;
			_582960B3 obj = _0D172508;
			num -= 1370046425;
			return obj._078008FE();
		}

		public override object _7BBC17CC(Type _0FAA7DB5, bool _6F4453F6)
		{
			_582960B3 obj = _0D172508;
			uint num = 450064441u;
			return obj._7BBC17CC(_0FAA7DB5, _6F4453F6);
		}

		public override TypeCode _09A801C9()
		{
			_582960B3 obj = _0D172508;
			uint num = 77619548u;
			return obj._09A801C9();
		}

		public override void _727F3897(object _74747730)
		{
			uint num = 1714506841u;
			do
			{
				num = 79377722 % num;
				_341E0811 = (UIntPtr)_74747730;
			}
			while (1485310820 < num);
			do
			{
				num /= 717578909;
				_0D172508 = _19144800(_341E0811);
			}
			while (184825642 == num);
		}

		public override UIntPtr _15842C84()
		{
			return _341E0811;
		}

		public override IntPtr _47C01150()
		{
			uint num = 487419741u;
			num = 581527270 / num;
			return _0D172508._47C01150();
		}

		public override long _3E0F495D()
		{
			_582960B3 obj = _0D172508;
			uint num = 1840524576u;
			return obj._3E0F495D();
		}

		public override short _72435997()
		{
			_582960B3 obj = _0D172508;
			uint num = 1814325634u;
			return obj._72435997();
		}

		public override Type _71C820E4()
		{
			uint num = 1622622106u;
			num += 925847565;
			return typeof(UIntPtr);
		}

		private static _582960B3 _19144800(UIntPtr _12892545)
		{
			uint num = 1805004604u;
			do
			{
				int size = IntPtr.Size;
				num ^= 0x409E665D;
				if (size == (int)(num - 721963357))
				{
					num = 0x28F514D2 ^ num;
					if (num < 1788032365)
					{
						uint _7A3475AA = _12892545.ToUInt32();
						num &= 0x92E1AF2;
						return new _50424ADC((int)_7A3475AA);
					}
				}
				num *= 658524769;
			}
			while (399639374 - num == 0);
			return new _66FF619D((long)_12892545.ToUInt64());
		}

		public override _582960B3 _5C7710FF()
		{
			return new _51773792(_341E0811);
		}

		public unsafe override void* _1AF75EB9()
		{
			uint num = 1228435354u;
			return _341E0811.ToPointer();
		}

		public override ulong _5ECF32BD()
		{
			uint num = 1285771868u;
			_582960B3 obj = _0D172508;
			num <<= 27;
			return obj._5ECF32BD();
		}

		public override int _6AAF062D()
		{
			return _0D172508._6AAF062D();
		}

		public override sbyte _22B70934()
		{
			uint num = 23227963u;
			return _0D172508._22B70934();
		}

		public override uint _76377E70()
		{
			uint num = 2143890633u;
			num |= 0x1A8A107A;
			_582960B3 obj = _0D172508;
			num = 0x37337EB2 & num;
			return obj._76377E70();
		}

		public override byte _70DF711E()
		{
			uint num = 15866720u;
			_582960B3 obj = _0D172508;
			num = 1228098142 * num;
			return obj._70DF711E();
		}

		public override double _40F966AC()
		{
			uint num = 1379212189u;
			num = 0x11BE0AD3 | num;
			_582960B3 obj = _0D172508;
			num = 2079227843 % num;
			return obj._40F966AC();
		}

		public override bool _27B26B78()
		{
			uint num = 251463137u;
			num &= 0x7CF07B4E;
			UIntPtr intPtr = _341E0811;
			num >>= 17;
			UIntPtr zero = UIntPtr.Zero;
			num -= 945572862;
			return intPtr != zero;
		}

		public override object _0936516D()
		{
			uint num = 1003847599u;
			num = 1407018645u >> (int)num;
			UIntPtr intPtr = _341E0811;
			num = 1221724693 + num;
			return intPtr;
		}

		public override ushort _16D4371A()
		{
			uint num = 1261838198u;
			return _0D172508._16D4371A();
		}

		public _51773792(UIntPtr _10662FF3)
		{
			uint num = 2057635609u;
			if (num != 451951293)
			{
				goto IL_0011;
			}
			goto IL_002a;
			IL_0011:
			base._002Ector();
			num <<= 24;
			if (258611261 > num)
			{
				return;
			}
			goto IL_002a;
			IL_002a:
			_341E0811 = _10662FF3;
			num = 244719964 / num;
			if (2071271557 > num)
			{
				UIntPtr _78492022 = _341E0811;
				num <<= 7;
				_582960B3 obj = _19144800(_78492022);
				num = (uint)(1457930265 << (int)num);
				_0D172508 = obj;
				if (1160188588 <= num)
				{
					return;
				}
				goto IL_0011;
			}
		}
	}

	private sealed class _3DD06737 : _76587E10
	{
		private _582960B3 _36C76068;

		private Enum _61E9432C;

		public override double _40F966AC()
		{
			uint num = 704661448u;
			return _36C76068._40F966AC();
		}

		public override UIntPtr _15842C84()
		{
			uint num = 127797252u;
			if (1486322668 > num)
			{
				while (IntPtr.Size != (int)num + -127797248)
				{
					num >>= 18;
					if (num == 2128237185)
					{
						continue;
					}
					goto IL_0035;
				}
			}
			num = 295117297 / num;
			if ((0x1EB938AA & num) == 0)
			{
				goto IL_0035;
			}
			long value = _76377E70();
			num ^= 0x146;
			goto IL_006b;
			IL_006b:
			return new UIntPtr((ulong)value);
			IL_0035:
			num &= 0x672C6544;
			value = (long)_5ECF32BD();
			goto IL_006b;
		}

		public override ushort _16D4371A()
		{
			uint num = 1666926564u;
			_582960B3 obj = _36C76068;
			num -= 651190414;
			return obj._16D4371A();
		}

		public override _582960B3 _5C7710FF()
		{
			uint num = 1370387190u;
			num = 0x1084630A ^ num;
			Enum _1D1B43E = _61E9432C;
			num = 105269212 % num;
			return new _3DD06737(_1D1B43E);
		}

		private static _582960B3 _240824F8(Enum _0DB261B2)
		{
			uint num = 1920680296u;
			if (num > 24271699)
			{
				while (true)
				{
					num = 1389186754 - num;
					TypeCode typeCode = _0DB261B2.GetTypeCode();
					num = 0x3BF904E4 ^ num;
					TypeCode typeCode2 = typeCode;
					num &= 0x14D5EB3;
					if (num % 5070368 == 0)
					{
						continue;
					}
					while (true)
					{
						num = 578245718 / num;
						int num2 = (int)num + -28;
						num = 2011983529 - num;
						switch (typeCode2 - num2)
						{
						case TypeCode.Object:
						case TypeCode.Boolean:
						case TypeCode.SByte:
						{
							num = 0x7B873CF5 & num;
							if (344461041 == num)
							{
								continue;
							}
							num /= 1296962261;
							uint _7A3475AA = Convert.ToUInt32(_0DB261B2);
							num *= 374431678;
							return new _50424ADC((int)_7A3475AA);
						}
						case TypeCode.Empty:
						case TypeCode.DBNull:
						case TypeCode.Char:
						{
							num -= 412103644;
							int _7A3475AA2 = Convert.ToInt32(_0DB261B2);
							num &= 0x1B485250;
							return new _50424ADC(_7A3475AA2);
						}
						case TypeCode.Int16:
						{
							num = 1964976603 % num;
							if (43678618 == num)
							{
								continue;
							}
							ulong _52CC445F = Convert.ToUInt64(_0DB261B2);
							num = 0x69FD54A3 & num;
							return new _66FF619D((long)_52CC445F);
						}
						case TypeCode.Byte:
							goto end_IL_003c;
						}
						goto end_IL_0011;
						continue;
						end_IL_003c:
						break;
					}
					if (1296786024u >> (int)num != 0)
					{
						long _52CC445F2 = Convert.ToInt64(_0DB261B2);
						num ^= 0x69C50D11;
						return new _66FF619D(_52CC445F2);
					}
					continue;
					end_IL_0011:
					break;
				}
			}
			throw new InvalidOperationException();
		}

		public override int _6AAF062D()
		{
			uint num = 647641243u;
			return _36C76068._6AAF062D();
		}

		public override long _3E0F495D()
		{
			uint num = 1015818501u;
			num %= 1470963849;
			return _36C76068._3E0F495D();
		}

		public override TypeCode _09A801C9()
		{
			return _36C76068._09A801C9();
		}

		public override uint _76377E70()
		{
			uint num = 1950446374u;
			num /= 1628989362;
			return _36C76068._76377E70();
		}

		public override object _0936516D()
		{
			uint num = 1533679498u;
			return _61E9432C;
		}

		public override _582960B3 _2ED37583()
		{
			return _36C76068._2ED37583();
		}

		public override Type _71C820E4()
		{
			return _61E9432C.GetType();
		}

		public override void _727F3897(object _76A73ADA)
		{
			uint num = 1146627314u;
			if (num != 893549546)
			{
				while (_76A73ADA != null)
				{
					num /= 151523715;
					if ((0x2105169B ^ num) != 0)
					{
						num = 1674409198 * num;
						_61E9432C = (Enum)_76A73ADA;
						_582960B3 obj = _240824F8(_61E9432C);
						num *= 429031008;
						_36C76068 = obj;
						return;
					}
				}
			}
			throw new ArgumentException();
		}

		public override short _72435997()
		{
			uint num = 1637812435u;
			return _36C76068._72435997();
		}

		public override IntPtr _47C01150()
		{
			uint num = 1906794867u;
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num2 = num - 1906794863;
				num >>= 20;
				if (size != (int)num2)
				{
					if ((num & 0x6B517E27) != 0)
					{
						num <<= 27;
						value = _3E0F495D();
						break;
					}
					continue;
				}
				num = 0x300E4413 ^ num;
				int num3 = _6AAF062D();
				num = 0x5EEA3FD1 & num;
				value = num3;
				num ^= 0xC00A0301u;
				break;
			}
			num <<= 20;
			return new IntPtr(value);
		}

		public override object _7BBC17CC(Type _033D5093, bool _04C12499)
		{
			_582960B3 obj = _36C76068;
			uint num = 1847875600u;
			return obj._7BBC17CC(_033D5093, _04C12499);
		}

		public override byte _70DF711E()
		{
			uint num = 1248556748u;
			return _36C76068._70DF711E();
		}

		public override sbyte _22B70934()
		{
			return _36C76068._22B70934();
		}

		public override float _078008FE()
		{
			uint num = 1575687387u;
			_582960B3 obj = _36C76068;
			num |= 0x335E0D52;
			return obj._078008FE();
		}

		public override ulong _5ECF32BD()
		{
			uint num = 1865447024u;
			return _36C76068._5ECF32BD();
		}

		public _3DD06737(Enum _1D1B43E3)
		{
			uint num = 1913863939u;
			base._002Ector();
			num = 1518954392 * num;
			if (104209541 < num)
			{
				while (true)
				{
					if (_1D1B43E3 == null)
					{
						num = 0x22C90B15 ^ num;
						if (1193083336 < num)
						{
							break;
						}
					}
					else if (893733075 <= num)
					{
						num = 1001787894 % num;
						_61E9432C = _1D1B43E3;
						_36C76068 = _240824F8(_61E9432C);
						return;
					}
				}
			}
			throw new ArgumentException();
		}
	}

	private sealed class _443828F0 : _5C8E334C
	{
		private Type _0B4157D3;

		private IntPtr _0A58560C;

		public override sbyte _22B70934()
		{
			uint num = 541272650u;
			num *= 1991010405;
			return (sbyte)Marshal.ReadByte(_0A58560C);
		}

		public override char _52B43B98()
		{
			uint num = 373779648u;
			IntPtr ptr = _0A58560C;
			num /= 1185899307;
			return (char)Marshal.ReadInt16(ptr);
		}

		public override object _0936516D()
		{
			uint num = 969820873u;
			if (834800436 != num)
			{
				if (!_0B4157D3.IsValueType)
				{
					num = 782565889 * num;
					throw new InvalidOperationException();
				}
				num = 443109806 / num;
			}
			num >>= 25;
			IntPtr ptr = _0A58560C;
			num = 0xA876D3 | num;
			Type structureType = _0B4157D3;
			num = 0x6C441B3B ^ num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override IntPtr _47C01150()
		{
			uint num = 435162782u;
			if (1045306777 >= num)
			{
				while (true)
				{
					int size = IntPtr.Size;
					uint num2 = num ^ 0x19F00E9A;
					num = 1780030658 * num;
					if (size == (int)num2)
					{
						break;
					}
					num |= 0xA074DC4;
					if (num - 372340328 == 0)
					{
						continue;
					}
					goto IL_003e;
				}
			}
			num = 0x4F954097 ^ num;
			if (num < 1210803761)
			{
				goto IL_003e;
			}
			num *= 2072512406;
			IntPtr ptr = _0A58560C;
			num /= 452425793;
			int num3 = Marshal.ReadInt32(ptr);
			num = 0x13B22A6B | num;
			long value = num3;
			num += 454859838;
			goto IL_009d;
			IL_009d:
			return new IntPtr(value);
			IL_003e:
			num = 0x7A49080C ^ num;
			IntPtr ptr2 = _0A58560C;
			num += 2115006141;
			value = Marshal.ReadInt64(ptr2);
			goto IL_009d;
		}

		public override short _72435997()
		{
			uint num = 714695884u;
			num -= 108008226;
			IntPtr ptr = _0A58560C;
			num = (uint)(1637622414 << (int)num);
			return Marshal.ReadInt16(ptr);
		}

		public override byte _70DF711E()
		{
			IntPtr ptr = _0A58560C;
			uint num = 1906840515u;
			return Marshal.ReadByte(ptr);
		}

		public override float _078008FE()
		{
			uint num = 1310463038u;
			IntPtr ptr = _0A58560C;
			num = 1576149077u >> (int)num;
			int value = Marshal.ReadInt32(ptr);
			num = 1340687439 / num;
			byte[] bytes = BitConverter.GetBytes(value);
			num /= 1632900785;
			uint startIndex = num ^ 0;
			num = 1695104376u >> (int)num;
			return BitConverter.ToSingle(bytes, (int)startIndex);
		}

		public override uint _76377E70()
		{
			IntPtr ptr = _0A58560C;
			uint num = 488655179u;
			return (uint)Marshal.ReadInt32(ptr);
		}

		public override Type _71C820E4()
		{
			uint num = 784089109u;
			return typeof(Pointer);
		}

		public override ulong _5ECF32BD()
		{
			IntPtr ptr = _0A58560C;
			uint num = 441457855u;
			return (ulong)Marshal.ReadInt64(ptr);
		}

		public override UIntPtr _15842C84()
		{
			long value;
			while (true)
			{
				uint num;
				if (IntPtr.Size != 4)
				{
					num = 1805861246u;
					value = Marshal.ReadInt64(_0A58560C);
					break;
				}
				num = 1178677656u;
				if (2138248651 % num != 0)
				{
					num = 988807789 + num;
					int num2 = Marshal.ReadInt32(_0A58560C);
					num >>= 22;
					value = (uint)num2;
					num += 1805860730;
					break;
				}
			}
			return new UIntPtr((ulong)value);
		}

		public override int _6AAF062D()
		{
			uint num = 86120993u;
			num = 1853373145 + num;
			IntPtr ptr = _0A58560C;
			num += 1508071300;
			return Marshal.ReadInt32(ptr);
		}

		public override _582960B3 _5C7710FF()
		{
			IntPtr _75062F = _0A58560C;
			uint num = 86846594u;
			Type _4B042F4B = _0B4157D3;
			num = 1503138282 % num;
			return new _443828F0(_75062F, _4B042F4B);
		}

		public override TypeCode _09A801C9()
		{
			uint num = 1399020421u;
			return (TypeCode)(num ^ 0x53635B85);
		}

		public override long _3E0F495D()
		{
			IntPtr ptr = _0A58560C;
			uint num = 367726837u;
			return Marshal.ReadInt64(ptr);
		}

		public override double _40F966AC()
		{
			uint num = 915752170u;
			num = 668673178 * num;
			IntPtr ptr = _0A58560C;
			num &= 0x455856D6;
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(ptr)), (int)(num ^ 0x450854C4));
		}

		public override void _727F3897(object _15522BA3)
		{
			while (true)
			{
				uint num = 1942910601u;
				if (_15522BA3 == null)
				{
					if (580996035 == num)
					{
						break;
					}
					goto IL_0017;
				}
				while (true)
				{
					num = (uint)(371534820 << (int)num);
					if (_0B4157D3.IsValueType)
					{
						if (num < 261364985)
						{
							continue;
						}
						goto IL_0046;
					}
					if (num >= 1293121449)
					{
						break;
					}
					num %= 538907866;
					TypeCode typeCode = Type.GetTypeCode(_15522BA3.GetType());
					num /= 1897298840;
					TypeCode typeCode2 = typeCode;
					switch (typeCode2 - ((int)num - -4))
					{
					case TypeCode.Object:
					{
						IntPtr ptr5 = _0A58560C;
						num = (uint)(852506805 << (int)num);
						sbyte num3 = Convert.ToSByte(_15522BA3);
						num = 0x580E5137 & num;
						Marshal.WriteByte(ptr5, (byte)num3);
						return;
					}
					case TypeCode.DBNull:
						goto IL_0105;
					case TypeCode.Empty:
						goto IL_0132;
					case TypeCode.Boolean:
					{
						num = (uint)(2138578328 << (int)num);
						IntPtr ptr4 = _0A58560C;
						num %= 1740527518;
						short val3 = Convert.ToInt16(_15522BA3);
						num = 704513121u >> (int)num;
						Marshal.WriteInt16(ptr4, val3);
						if (num == 795628945)
						{
						}
						return;
					}
					case TypeCode.Char:
					{
						num -= 679689742;
						IntPtr ptr3 = _0A58560C;
						num >>= 0;
						ushort num2 = Convert.ToUInt16(_15522BA3);
						num *= 624326176;
						short val2 = (short)num2;
						num /= 679307533;
						Marshal.WriteInt16(ptr3, val2);
						return;
					}
					case TypeCode.SByte:
						goto IL_01d4;
					case TypeCode.Byte:
						goto IL_0202;
					case TypeCode.Int16:
						goto IL_0242;
					case TypeCode.UInt16:
						goto IL_027f;
					case TypeCode.Int32:
					{
						num = 830631240 * num;
						IntPtr ptr2 = _0A58560C;
						float value2 = Convert.ToSingle(_15522BA3);
						num = 233521742u >> (int)num;
						Marshal.WriteInt32(ptr2, BitConverter.ToInt32(BitConverter.GetBytes(value2), (int)(num ^ 0xDEB424E)));
						return;
					}
					case TypeCode.UInt32:
					{
						IntPtr ptr = _0A58560C;
						double value = Convert.ToDouble(_15522BA3);
						num = 0x77A30835 ^ num;
						byte[] bytes = BitConverter.GetBytes(value);
						uint startIndex = num ^ 0x77A30835;
						num = (uint)(1243422536 << (int)num);
						long val = BitConverter.ToInt64(bytes, (int)startIndex);
						num /= 406284500;
						Marshal.WriteInt64(ptr, val);
						return;
					}
					}
					if (num + 1684941862 != 0)
					{
						num -= 1809992882;
						if (662770728 >= num)
						{
							break;
						}
						throw new ArgumentException();
					}
					continue;
					IL_0242:
					num += 2060219051;
					num %= 1621584651;
					IntPtr ptr6 = _0A58560C;
					num = 438138335 * num;
					long val4 = Convert.ToInt64(_15522BA3);
					num *= 1052529445;
					Marshal.WriteInt64(ptr6, val4);
					if (num == 1667450396)
					{
						break;
					}
					return;
					IL_0202:
					if (87376750 >>> (int)num == 0)
					{
						break;
					}
					IntPtr ptr7 = _0A58560C;
					num = 0x6C140F93 | num;
					uint val5 = Convert.ToUInt32(_15522BA3);
					num >>= 0;
					Marshal.WriteInt32(ptr7, (int)val5);
					if (1556614913 + num == 0)
					{
						break;
					}
					return;
					IL_0132:
					num <<= 2;
					IntPtr ptr8 = _0A58560C;
					char val6 = Convert.ToChar(_15522BA3);
					num *= 208738758;
					Marshal.WriteInt16(ptr8, val6);
					if ((num ^ 0x3DD3437) == 0)
					{
						break;
					}
					return;
					IL_027f:
					if (num * 1688758356 == 0)
					{
						num = 72972534 - num;
						IntPtr ptr9 = _0A58560C;
						num = 0x7D692782 ^ num;
						ulong val7 = Convert.ToUInt64(_15522BA3);
						num = 204153168 - num;
						Marshal.WriteInt64(ptr9, (long)val7);
						if (1427194711 == num)
						{
							break;
						}
						return;
					}
					goto IL_0046;
					IL_0105:
					IntPtr ptr10 = _0A58560C;
					num ^= 0x1ABA092C;
					num = 1404459620 % num;
					Marshal.WriteByte(ptr10, Convert.ToByte(_15522BA3));
					if (num == 508253919)
					{
						break;
					}
					return;
					IL_0046:
					num = 0x41C9712A ^ num;
					IntPtr ptr11 = _0A58560C;
					uint fDeleteOld = num - 194951466;
					num = 0x69E70E6B | num;
					Marshal.StructureToPtr(_15522BA3, ptr11, (byte)fDeleteOld != 0);
					return;
				}
				continue;
				IL_01d4:
				num %= 538655739;
				IntPtr ptr12 = _0A58560C;
				num = 859781906 * num;
				Marshal.WriteInt32(ptr12, Convert.ToInt32(_15522BA3));
				if ((num & 0x3F5F2F70) == 0)
				{
					break;
				}
				goto IL_0017;
				IL_0017:
				throw new ArgumentException();
			}
		}

		public override ushort _16D4371A()
		{
			uint num = 964900031u;
			num = 1232348797 + num;
			return (ushort)Marshal.ReadInt16(_0A58560C);
		}

		public _443828F0(IntPtr _75062F44, Type _4B042F4B)
		{
			uint num = 530519115u;
			if (num - 699341218 != 0)
			{
				num = 1426411480 * num;
				_0A58560C = _75062F44;
				do
				{
					num ^= 0x31262E;
					_0B4157D3 = _4B042F4B;
				}
				while (462450727 <= num);
			}
		}
	}

	private sealed class _5C0E71F4
	{
		private int _055C4B98;

		private int _1A10320F;

		private byte _6B085BAF;

		public int _34C01896()
		{
			uint num = 2092053196u;
			return _1A10320F;
		}

		public int _12B955CD()
		{
			uint num = 1250499996u;
			return _055C4B98;
		}

		public byte _50C7492B()
		{
			uint num = 1312051947u;
			return _6B085BAF;
		}

		public _5C0E71F4(byte _57153044, int _07BE1A29, int _128E6BE0)
		{
			while (true)
			{
				uint num = 1434390987u;
				base._002Ector();
				if (num == 337269227)
				{
					continue;
				}
				num |= 0x5582137A;
				_6B085BAF = _57153044;
				num = 509500274 % num;
				if (num - 1398938261 != 0)
				{
					num %= 1306942984;
					num = 1728082393 - num;
					_055C4B98 = _07BE1A29;
					num = 0x10E144E8 | num;
					num = 2067098942 + num;
					_1A10320F = _128E6BE0;
					if ((num ^ 0x1E803EF8) != 0)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class _58BB531E
	{
		private int _1BB7379B;

		private List<_5C0E71F4> _5A293141;

		private int _4B614BBC;

		public int _423815D3()
		{
			uint num = 1406418382u;
			num = 356137481 / num;
			return _1BB7379B;
		}

		public int _6E727B36(_58BB531E _641C4BC0)
		{
			if (_641C4BC0 != null)
			{
				int num2;
				uint num;
				while (true)
				{
					num = 1682916869u;
					num &= 0x4CBD69F9;
					ref int reference = ref _4B614BBC;
					num >>= 22;
					num = 888234902 / num;
					num2 = reference.CompareTo(_641C4BC0._0E2D7401());
					if (1274156507 != num)
					{
						int num3 = num2;
						num = 0x792C5340 ^ num;
						if (num3 != 0)
						{
							break;
						}
						num |= 0x1B10489D;
					}
					num <<= 22;
					int num4 = _641C4BC0._423815D3();
					num >>= 6;
					if (1851928750 >= num)
					{
						num %= 1759075004;
						num2 = num4.CompareTo(_1BB7379B);
						num += 1965066081;
						break;
					}
				}
				num >>= 25;
				if (num + 907092658 != 0)
				{
					return num2;
				}
			}
			return 1;
		}

		public void _1E3671C3(byte _4CFB6547, int _3B1D455D, int _0B8031E0)
		{
			uint num = 1576745616u;
			num <<= 20;
			List<_5C0E71F4> list = _5A293141;
			num = 2120705104 - num;
			num |= 0x1D006CC5;
			_5C0E71F4 item = new _5C0E71F4(_4CFB6547, _3B1D455D, _0B8031E0);
			num = 0x674963F0 ^ num;
			list.Add(item);
		}

		public List<_5C0E71F4> _38207DE6()
		{
			uint num = 717757698u;
			return _5A293141;
		}

		public int _0E2D7401()
		{
			uint num = 570181588u;
			return _4B614BBC;
		}

		public _58BB531E(int _1E1C1E42, int _666B2E8D)
		{
			while (true)
			{
				List<_5C0E71F4> list = new List<_5C0E71F4>();
				uint num = 766856746u;
				_5A293141 = list;
				num = 1981509540 + num;
				if (1673346083 + num == 0)
				{
					continue;
				}
				num = 1816793234 % num;
				base._002Ector();
				if ((0x65F828B0 & num) == 0)
				{
					continue;
				}
				num = 1918174150 + num;
				_4B614BBC = _1E1C1E42;
				num = 17132624 % num;
				if (1840144633 % num != 0)
				{
					_1BB7379B = _666B2E8D;
					if (1580275401 >= num)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class _3C2B59A3 : _5C8E334C
	{
		private object _17A66169;

		private FieldInfo _7E4B710E;

		public override _582960B3 _5C7710FF()
		{
			uint num = 1322142560u;
			FieldInfo _1B0D1A = _7E4B710E;
			num ^= 0x40D8155E;
			object _4EB = _17A66169;
			num <<= 7;
			return new _3C2B59A3(_1B0D1A, _4EB);
		}

		public override Type _71C820E4()
		{
			return typeof(int);
		}

		public override void _727F3897(object _45020304)
		{
			uint num;
			do
			{
				FieldInfo fieldInfo = _7E4B710E;
				num = 2077781699u;
				num = 1389036725 / num;
				object? value = fieldInfo.GetValue(_17A66169);
				num = 408304329 * num;
				((_6E261D0C)value)._0C3C7D51((int)_45020304);
			}
			while (760303058 * num != 0);
		}

		public override object _0936516D()
		{
			FieldInfo fieldInfo = _7E4B710E;
			uint num = 545932449u;
			num *= 2024749941;
			object obj = _17A66169;
			num = 0x21A32FD6 & num;
			object? value = fieldInfo.GetValue(obj);
			num <<= 1;
			int num2 = ((_6E261D0C)value)._77F36CDA();
			num = 308617189u >> (int)num;
			return num2;
		}

		public _3C2B59A3(FieldInfo _1B0D1A32, object _4EB94432)
		{
			while (true)
			{
				base._002Ector();
				uint num = 1638336018u;
				if (917121603 <= num)
				{
					_7E4B710E = _1B0D1A32;
					num <<= 5;
					if (378013044 <= num)
					{
						break;
					}
				}
			}
			_17A66169 = _4EB94432;
		}
	}

	private abstract class _6E261D0C
	{
		protected _6E261D0C()
		{
			uint num = 1067143918u;
			if (1491094578 > num)
			{
				num = 0x4BFB46DC & num;
				base._002Ector();
			}
		}

		public abstract void _0C3C7D51(int _6FC93971);

		public abstract int _77F36CDA();
	}

	private sealed class _38797DE2 : _6E261D0C
	{
		private Stack<int> _54BC6D3D;

		private List<_58BB531E> _32CC67DE;

		public override int _77F36CDA()
		{
			return 0;
		}

		public int _346D2CCE()
		{
			uint num = 495796560u;
			num = 159601437 % num;
			return _54BC6D3D.Count;
		}

		public _58BB531E _5090100A()
		{
			List<_58BB531E> list = _32CC67DE;
			uint num = 914627323u;
			num = 1465658922 - num;
			Stack<int> stack = _54BC6D3D;
			num |= 0x62EC1205;
			return list[stack.Peek()];
		}

		public _38797DE2()
		{
			uint num = 660487782u;
			_32CC67DE = new List<_58BB531E>();
			if (1405310613 > num)
			{
				num = 776824761 - num;
				_54BC6D3D = new Stack<int>();
				if (469127699 * (0x55E47D34 & num) != 0)
				{
					base._002Ector();
				}
			}
		}

		public _58BB531E _1D0C709F()
		{
			List<_58BB531E> list = _32CC67DE;
			uint num = 1396577287u;
			num = 681986800 % num;
			Stack<int> stack = _54BC6D3D;
			num = 1163271382u >> (int)num;
			return list[stack.Pop()];
		}

		public override void _0C3C7D51(int _65E43837)
		{
			while (true)
			{
				int num = 0;
				while (true)
				{
					int num2 = num;
					uint num3 = 971181620u;
					List<_58BB531E> list = _32CC67DE;
					num3 <<= 22;
					int count = list.Count;
					num3 = 139870717 / num3;
					if (num2 >= count)
					{
						if (num3 == 342316941)
						{
							continue;
						}
						return;
					}
					num3 = 809442640u;
					if (74651871 < num3)
					{
						num3 = 1593907028 + num3;
						List<_58BB531E> list2 = _32CC67DE;
						num3 = 517497436 + num3;
						int index = num;
						num3 -= 1051673831;
						_58BB531E obj = list2[index];
						num3 = 1524170875 - num3;
						int num4 = obj._0E2D7401();
						num3 |= 0x328F7DF2;
						if (num4 != _65E43837)
						{
							goto IL_0086;
						}
						if (num3 <= 1063855290)
						{
							return;
						}
					}
					Stack<int> stack = _54BC6D3D;
					num3 = 0x3CA0559D & num3;
					int item = num;
					num3 = 1438259371 + num3;
					stack.Push(item);
					num3 += 1838518711;
					goto IL_0086;
					IL_0086:
					if (num3 - 2040799003 == 0)
					{
						break;
					}
					int num5 = num;
					num3 = 0x76C65ED9 | num3;
					int num6 = (int)num3 ^ -1048582;
					num3 /= 1050233404;
					int num7 = num5 + num6;
					num3 ^= 0x33222F5F;
					num = num7;
				}
			}
		}

		public void _2F4D0B82(int _1E6A67B8, int _1DCD7482, byte _38B9397E, int _1B9E21E4, int _3B5013C9)
		{
			_58BB531E _58BB531E3 = default(_58BB531E);
			while (true)
			{
				_58BB531E _58BB531E2 = null;
				while (true)
				{
					uint num = 1785417189u;
					int num2 = 0;
					if ((0x1ADA46D8 & num) == 0)
					{
						goto IL_00a2;
					}
					goto IL_00f6;
					IL_00a2:
					_58BB531E2 = _58BB531E3;
					if (num - 1183653690 == 0)
					{
						continue;
					}
					goto IL_013c;
					IL_013c:
					num <<= 16;
					if (939197372 * num == 0)
					{
						goto IL_00f6;
					}
					bool flag;
					int num3;
					if (_58BB531E2 == null)
					{
						flag = (byte)(num + 4116971520u) != 0;
						num = 0x5AAD36CF | num;
						num |= 0x7E4345BF;
						_58BB531E obj = new _58BB531E(_1E6A67B8, _1DCD7482);
						num = 427428893 + num;
						_58BB531E2 = obj;
						num -= 519858442;
						num3 = (int)(num ^ 0x797D1B12);
						while (192812193 < num)
						{
							int num4 = num3;
							List<_58BB531E> list = _32CC67DE;
							num = 2004972316 / num;
							if (num4 < list.Count)
							{
								num = 941699053u;
								num = 0x5BA362B1 & num;
								List<_58BB531E> list2 = _32CC67DE;
								num <<= 6;
								_58BB531E _641C4BC = list2[num3];
								_58BB531E obj2 = _58BB531E2;
								num *= 360864119;
								int num5 = obj2._6E727B36(_641C4BC);
								int num6 = (int)num ^ -859540032;
								num |= 0x74A02DB8;
								if (num5 >= num6)
								{
									num = 1152977699 - num;
									if (num * 1504453445 != 0)
									{
										int num7 = num3;
										int num8 = (int)num + -1205112106;
										num = 0x6F0D3431 & num;
										num3 = num7 + num8;
										num ^= 0x3E791F33;
										continue;
									}
									goto IL_00a2;
								}
								goto IL_01f3;
							}
							goto IL_02aa;
						}
						break;
					}
					goto IL_0321;
					IL_00f6:
					while (num * 1903955107 != 0)
					{
						int num9 = num2;
						num >>= 13;
						List<_58BB531E> list3 = _32CC67DE;
						num ^= 0x4E8A7FDB;
						int count = list3.Count;
						num = 690188710 - num;
						if (num9 < count)
						{
							List<_58BB531E> list4 = _32CC67DE;
							num = 1964059978u;
							int index = num2;
							num <<= 10;
							_58BB531E3 = list4[index];
							if (num / 297540356 == 0)
							{
								goto end_IL_0002;
							}
							_58BB531E obj3 = _58BB531E3;
							num ^= 0x50178B9;
							int num10 = obj3._0E2D7401();
							num = (uint)(867979048 << (int)num);
							if (num10 == _1E6A67B8)
							{
								int num11 = _58BB531E3._423815D3();
								num %= 441585476;
								num /= 1219450748;
								num ^= 0x50000000;
								if (num11 == _1DCD7482)
								{
									goto IL_0098;
								}
							}
							if (num << 19 != 0)
							{
								break;
							}
							int num12 = num2;
							num %= 894389442;
							uint num13 = num ^ 0x1AB0B33F;
							num %= 254376103;
							int num14 = num12 + (int)num13;
							num = 0x4F1D45F3 ^ num;
							num2 = num14;
							num ^= 0x2EF13281;
							continue;
						}
						goto IL_0132;
					}
					continue;
					IL_0132:
					num ^= 0x89E84FB9u;
					goto IL_013c;
					IL_0098:
					num = 57805468 + num;
					goto IL_00a2;
					IL_02aa:
					num ^= 0x1656FFB;
					goto IL_02b4;
					IL_01f3:
					num = 1639214006 % num;
					if (num < 679902689)
					{
						goto IL_00f6;
					}
					List<_58BB531E> list5 = _32CC67DE;
					num = 361459028 - num;
					int index2 = num3;
					num = 1950956834u >> (int)num;
					list5.Insert(index2, _58BB531E2);
					uint num15 = num ^ 0;
					num *= 23425019;
					flag = (byte)num15 != 0;
					goto IL_02b4;
					IL_0321:
					_58BB531E obj4 = _58BB531E2;
					num = 0x63C550B9 ^ num;
					num = (uint)(1569809692 << (int)num);
					obj4._1E3671C3(_38B9397E, _1B9E21E4, _3B5013C9);
					return;
					IL_02b4:
					num = 399277755 * num;
					if (num == 1545417953)
					{
						goto IL_00f6;
					}
					bool num16 = flag;
					num ^= 0xB1A65659u;
					if (!num16)
					{
						num = 1929984959u >> (int)num;
						if (446637407 == num)
						{
							break;
						}
						List<_58BB531E> list6 = _32CC67DE;
						num /= 1049450125;
						_58BB531E item = _58BB531E2;
						num /= 1676368728;
						list6.Add(item);
						num ^= 0xA9C0000;
					}
					goto IL_0321;
					continue;
					end_IL_0002:
					break;
				}
			}
		}
	}

	private sealed class _1AF96773 : _6E261D0C
	{
		private int _5E990308;

		private List<_582960B3> _5C88198C;

		public void _20DB4AD4(_582960B3 _5FD57039)
		{
			uint num;
			do
			{
				num = 1272785954u;
				List<_582960B3> list = _5C88198C;
				num = (uint)(1761283977 << (int)num);
				num = 1712594870 % num;
				list.Add(_5FD57039._689700D4());
			}
			while (num - 1837462976 == 0);
		}

		public _582960B3 _170D7B68()
		{
			uint num = 1882406993u;
			int count = _5C88198C.Count;
			num = 306382731 + num;
			int index = count - (int)(num + 2106177573);
			num >>= 9;
			List<_582960B3> list = _5C88198C;
			num %= 2004109261;
			_582960B3 result = list[index];
			num = 1083274794 + num;
			_5C88198C.RemoveAt(index);
			return result;
		}

		public _582960B3 _3CF40F6B(int _42A95CF4, _582960B3 _43F26D4A)
		{
			uint num = 191980357u;
			if (978066256u >> (int)num != 0)
			{
				goto IL_0018;
			}
			goto IL_002d;
			IL_0018:
			int num2 = _42A95CF4;
			int num3 = (int)num + -191980357;
			num &= 0x35EC1D87;
			if (num2 < num3)
			{
				goto IL_002d;
			}
			goto IL_0074;
			IL_002d:
			int num4 = _42A95CF4;
			num = 1533041056 - num;
			num >>= 20;
			List<_582960B3> list = _5C88198C;
			num &= 0x99E48BC;
			int count = list.Count;
			num = 471873503 - num;
			int num5 = count - ((int)num + -471873342);
			num = 1148855157 - num;
			_42A95CF4 = num4 + num5;
			num ^= 0x2939ED33;
			goto IL_0074;
			IL_0074:
			num ^= 0x187A34B2;
			if (num << 7 != 0)
			{
				num >>= 22;
				List<_582960B3> list2 = _5C88198C;
				int index = _42A95CF4;
				num |= 0x1629419F;
				_582960B3 result = (list2[index] = _43F26D4A);
				if ((0x106E073B ^ num) != 0)
				{
					return result;
				}
			}
			goto IL_0018;
		}

		public _582960B3 _69E05F5E()
		{
			uint num = 24527463u;
			List<_582960B3> list = _5C88198C;
			num ^= 0x4A91532E;
			int count = list.Count;
			num = 0x24C75644 | num;
			int num2 = (int)num + -1877432140;
			num %= 859120962;
			int index = count - num2;
			List<_582960B3> list2 = _5C88198C;
			num = 0x2E645B7C | num;
			return list2[index];
		}

		public _582960B3 _40FF23BC(int _167A2AAF)
		{
			uint num = 2120175886u;
			while (true)
			{
				int num2 = _167A2AAF;
				num = 1233665804 / num;
				if (num2 >= (int)(num ^ 0))
				{
					break;
				}
				num = 0x7CFA3BEC ^ num;
				if (1167458342 / num == 0)
				{
					int num3 = _167A2AAF;
					num <<= 30;
					num += 340746199;
					int num4 = _5C88198C.Count - (int)(num ^ 0x144F5FD6);
					num = 0x1CAA62E3 | num;
					_167A2AAF = num3 + num4;
					num ^= 0x1CEF7FF7;
					break;
				}
			}
			List<_582960B3> list = _5C88198C;
			num = 1356091988 * num;
			int index = _167A2AAF;
			num = 0x52853424 ^ num;
			return list[index];
		}

		public _1AF96773()
		{
			uint num = 1810108687u;
			num = 291534109 + num;
			List<_582960B3> list = new List<_582960B3>();
			num ^= 0x215186C;
			_5C88198C = list;
			num += 656495192;
			base._002Ector();
		}

		public override void _0C3C7D51(int _007242F2)
		{
			uint num = 1075262580u;
			while (true)
			{
				num /= 1704158378;
				_5E990308 = _007242F2;
				int num2 = (int)(num + 0);
				if (num + 850614585 == 0)
				{
					continue;
				}
				while (true)
				{
					num = 1221665800 + num;
					if (num % 2014862118 == 0)
					{
						break;
					}
					int num3 = num2;
					num *= 1875187220;
					num %= 1668167899;
					int num4 = _5E990308;
					num = 684130982 / num;
					if (num3 < num4)
					{
						num = 1675918800u;
						num ^= 0x2AE24D75;
						List<_582960B3> list = _5C88198C;
						uint index = num - 1225142437;
						num = 1020932630 * num;
						list.Insert((int)index, null);
						int num5 = num2;
						num = 625548975 * num;
						int num6 = (int)num + -502307697;
						num = 0x407C56F9 ^ num;
						int num7 = num5 + num6;
						num = 0x502B2513 | num;
						num2 = num7;
						num ^= 0x5DAFED9B;
						continue;
					}
					if (1600609043 == num)
					{
						break;
					}
					return;
				}
			}
		}

		public void _3AD67507()
		{
			while (true)
			{
				uint num = 744316051u;
				List<_582960B3> list = _5C88198C;
				num = 0x4D6969BB ^ num;
				int count = list.Count;
				num ^= 0x3BD943B3;
				if (count > _5E990308)
				{
					num = 1905656356u;
					if (num != 7603869)
					{
						List<_582960B3> list2 = _5C88198C;
						num = 1420384617 - num;
						list2.RemoveAt(_5E990308);
						continue;
					}
					break;
				}
				break;
			}
		}

		public override int _77F36CDA()
		{
			uint num = 1226648147u;
			return _5C88198C.Count;
		}
	}

	private sealed class _6D2115ED : _6E261D0C
	{
		private Stack<int> _6C2664DA;

		private int _40E75333;

		private static long _7E241843;

		static _6D2115ED()
		{
			uint num = 1396787000u;
			if (52317008 % num != 0)
			{
				goto IL_0012;
			}
			goto IL_003f;
			IL_0012:
			num = 1747322608 - num;
			Module module = typeof(_78492021).Module;
			num = 686696102 / num;
			IntPtr hINSTANCE = Marshal.GetHINSTANCE(module);
			num |= 0x12B23BFC;
			goto IL_003f;
			IL_003f:
			long num2 = hINSTANCE.ToInt64();
			num *= 1595833787;
			_7E241843 = num2;
			if ((0x5D1A7E7A & num) != 0)
			{
				return;
			}
			goto IL_0012;
		}

		public _6D2115ED()
		{
			uint num = 1347769541u;
			do
			{
				Stack<int> stack = new Stack<int>();
				num = 19548274 + num;
				_6C2664DA = stack;
				num |= 0x749A6B5A;
				if (1267293431 != num)
				{
					base._002Ector();
					continue;
				}
				break;
			}
			while (1266383184u >> (int)num != 0);
		}

		public float _4FA84D15()
		{
			uint num = 1795304620u;
			int value = _435152A1();
			num |= 0x3BD436A3;
			byte[] bytes = BitConverter.GetBytes(value);
			num /= 1565663304;
			int startIndex = (int)num + -1;
			num = 0x9EB46ED ^ num;
			return BitConverter.ToSingle(bytes, startIndex);
		}

		public unsafe long _72111BC7()
		{
			uint num = 620062844u;
			long num2 = _7E241843;
			num = 1721042984u >> (int)num;
			long num3 = _40E75333;
			num = 1902672179 * num;
			long num4 = num2 + num3;
			num = 1061894417 / num;
			nint num5 = (nint)num4;
			num ^= 0x4B360958;
			long result = *(long*)num5;
			num *= 1236681446;
			int num6 = _40E75333;
			num %= 254936266;
			uint num7 = num ^ 0xBD01E0;
			num ^= 0x69667A6B;
			int num8 = num6 + (int)num7;
			num *= 1760508911;
			_40E75333 = num8;
			return result;
		}

		public unsafe int _435152A1()
		{
			uint num = 592775827u;
			long num2 = _7E241843;
			num /= 2090212496;
			num /= 205147704;
			int num3 = _40E75333;
			num *= 669649358;
			long num4 = num3;
			num |= 0x27FD06D1;
			long num5 = num2 + num4;
			num = 1472033761 - num;
			int result = *(int*)num5;
			num = 0x52D52119 & num;
			int num6 = _40E75333;
			num -= 626132187;
			_40E75333 = num6 + (int)(num + 579986383);
			return result;
		}

		public override void _0C3C7D51(int _7F451147)
		{
			uint num = 345272272u;
			if ((num & 0xDB269E8) != 0)
			{
				do
				{
					num >>= 25;
					num = 1036584754 + num;
					_40E75333 = _7F451147;
				}
				while ((0x36683504 ^ num) == 0);
			}
		}

		public void _771E25CB(int _4F012080)
		{
			uint num;
			do
			{
				Stack<int> stack = _6C2664DA;
				num = 50414831u;
				stack.Push(_4F012080);
			}
			while (num == 424889433);
		}

		public unsafe short _4B03768E()
		{
			long num = _7E241843;
			uint num2 = 663620058u;
			int num3 = _40E75333;
			num2 /= 1248160506;
			nint num4 = (nint)(num + num3);
			num2 = 1495559942u >> (int)num2;
			short result = *(short*)num4;
			num2 = 1554806544 - num2;
			num2 = 0x2CBC0B25 | num2;
			int num5 = _40E75333 + (int)(num2 ^ 0x2FBC0B2D);
			num2 = 65035722 / num2;
			_40E75333 = num5;
			return result;
		}

		public void _55863A4A()
		{
			uint num = 1180111646u;
			num = 847255468 + num;
			num %= 407518240;
			Stack<int> stack = _6C2664DA;
			num = 620849218u >> (int)num;
			int num2 = stack.Pop();
			num = 1851881307 / num;
			_40E75333 = num2;
		}

		public double _53AB0A6E()
		{
			long value = _72111BC7();
			uint num = 1916013328u;
			byte[] bytes = BitConverter.GetBytes(value);
			num %= 1992442062;
			uint startIndex = num - 1916013328;
			num = 0x5EB42BD0 ^ num;
			return BitConverter.ToDouble(bytes, (int)startIndex);
		}

		public unsafe byte _0F9F2D0A()
		{
			uint num = 157028656u;
			long num2 = _7E241843;
			num = 87311554 + num;
			long num3 = _40E75333;
			num = 1056638465 % num;
			byte result = *(byte*)(num2 + num3);
			num >>= 2;
			int num4 = _40E75333;
			num = 0x6BCB246C | num;
			_40E75333 = num4 + ((int)num + -1810853869);
			return result;
		}

		public int _118322DE()
		{
			uint num = 910510864u;
			Stack<int> stack = _6C2664DA;
			num %= 321676114;
			return stack.Count;
		}

		public void _13A86F25()
		{
			uint num = 1720788012u;
			Stack<int> stack = _6C2664DA;
			num |= 0x5F291CBE;
			stack.Clear();
			num = 1166223086 * num;
			if ((num ^ 0x4E7D3956) != 0)
			{
				_40E75333 = (int)(num + 2005619548);
			}
		}

		public override int _77F36CDA()
		{
			uint num = 289435553u;
			num = 0x7A9E17FB | num;
			return _40E75333;
		}
	}

	internal delegate void _19C46BFE();

	private _1AF96773 _40B8698E;

	private static readonly Dictionary<int, object> _000A3090;

	private List<IntPtr> _0E4305CB;

	private static readonly Dictionary<object, DynamicMethod> _11FE66F3;

	private Exception _459D7272;

	private _38797DE2 _2D282653;

	private _6D2115ED _381D5F4F;

	private static readonly Module _16B6617B;

	private _5C0E71F4 _06733F26;

	private readonly Dictionary<uint, _19C46BFE> _37ED57E7;

	private void _78760B02()
	{
		short _167A2AAF;
		uint num;
		do
		{
			num = 456073633u;
			short num2 = _381D5F4F._4B03768E();
			num = 857147508 - num;
			_167A2AAF = num2;
		}
		while (1632519548 == num);
		_1AF96773 obj = _40B8698E;
		num = 1347189862u >> (int)num;
		_582960B3 obj2 = obj._40FF23BC(_167A2AAF);
		num = 379615452 - num;
		_582960B3 _582960B4 = obj2;
		num >>= 9;
		if (1928940767 != num)
		{
			num = 751786490 * num;
			_1AF96773 obj3 = _40B8698E;
			num *= 1464092378;
			_582960B3 _5FD = _582960B4._5C7710FF();
			num = 1974032916 + num;
			obj3._20DB4AD4(_5FD);
		}
	}

	private void _06A60CD1()
	{
		_0D4C6B37 _0D4C6B38;
		BindingFlags invokeAttr;
		Type[] array;
		Type[] array3;
		object[] array4;
		Dictionary<int, _582960B3> dictionary2;
		uint num;
		while (true)
		{
			num = 1002704004u;
			num %= 1571684668;
			_6D2115ED obj = _381D5F4F;
			num <<= 26;
			_0D4C6B38 = _46C53560(obj._435152A1());
			if (1566246985 == num)
			{
				continue;
			}
			do
			{
				if (!_0D4C6B38._27023992 && 380374500 >= num)
				{
					throw new ArgumentException();
				}
				uint num2 = num ^ 0x10000000;
				num = 0x64706DF8 & num;
				invokeAttr = (BindingFlags)num2;
				num = 2066100167 * num;
				num = 0x3A9F7ADE | num;
				array = _0D4C6B38._181E08D4();
				num >>= 20;
			}
			while ((num & 0x273724AE) == 0);
			num += 2144280536;
			IntPtr intPtr = (nint)array.LongLength;
			num = 340863679u >> (int)num;
			int num3 = (int)(nint)intPtr;
			num >>= 19;
			Type[] array2 = new Type[num3 + (int)(num ^ 0x144)];
			num += 459688272;
			array3 = array2;
			num = 1167721174 % num;
			num %= 1218196872;
			array.CopyTo(array3, (int)num + -248343980);
			num /= 1994940435;
			if (num >= 1358443844)
			{
				continue;
			}
			int num4 = array.Length;
			num = 0xEDC323B ^ num;
			array3[num4] = typeof(IntPtr);
			num = (uint)(398935510 << (int)num);
			IntPtr intPtr2 = (nint)array3.LongLength;
			num |= 0x28E66933;
			int num5 = (int)(nint)intPtr2;
			num %= 833946719;
			array4 = new object[num5];
			if (1211777744 * num != 0)
			{
				Dictionary<int, _582960B3> dictionary = new Dictionary<int, _582960B3>();
				num = 1701577167 + num;
				dictionary2 = dictionary;
				if ((num ^ 0x6A7861DC) != 0)
				{
					break;
				}
			}
		}
		_4E2E44B6 obj2 = new _4E2E44B6();
		num = 0x33B82DA9 ^ num;
		_4E2E44B6 _4E2E44B7 = obj2;
		try
		{
			num += 2067755964;
			object obj8 = default(object);
			KeyValuePair<int, _582960B3> current = default(KeyValuePair<int, _582960B3>);
			while (true)
			{
				num <<= 9;
				int num6 = array4.Length;
				num >>= 25;
				uint num7 = num ^ 0x4B;
				num &= 0x531F1FEF;
				int num8 = num6 - (int)num7;
				num = 2139570521 * num;
				int num9 = num8;
				while (true)
				{
					int num10 = num9;
					num <<= 20;
					if (num10 >= (int)num + -1000341504)
					{
						num = 1509507877u;
						Type type = array3[num9];
						num = 685669150 + num;
						if (1393639817 == num)
						{
							break;
						}
						num ^= 0x7DDE3A58;
						_1AF96773 obj3 = _40B8698E;
						num = 1707237819 % num;
						_582960B3 _582960B4 = obj3._170D7B68();
						if ((num & 0x7B311191) == 0)
						{
							break;
						}
						bool num11 = _582960B4._11EF2F40();
						num *= 1403270536;
						if (num11)
						{
							num = 0x2EFE711C & num;
							bool isByRef = type.IsByRef;
							num += 2049073640;
							if (!isByRef)
							{
								if (num == 1072392582)
								{
									break;
								}
								int num12 = num9;
								num = 0x57A5A5C ^ num;
								object obj4 = _4E2E44B7._33CD5A83(_582960B4._0936516D());
								num += 525860899;
								array4[num12] = obj4;
								if (1822102482 >= num)
								{
									continue;
								}
								goto IL_0305;
							}
							dictionary2[num9] = _582960B4;
							num += 98508888;
						}
						if (num == 645401944)
						{
							break;
						}
						int num13 = num9;
						num >>= 9;
						object obj5 = _318778F9(_582960B4, type)._0936516D();
						num ^= 0x5264003C;
						array4[num13] = obj5;
						num += 1313714834;
						goto IL_0305;
					}
					if (num << 27 != 0)
					{
						break;
					}
					Dictionary<object, DynamicMethod> dictionary3 = _11FE66F3;
					num %= 1693670218;
					Dictionary<object, DynamicMethod> obj6 = dictionary3;
					num = 544885838 / num;
					bool lockTaken = (byte)(num + 0) != 0;
					DynamicMethod value;
					try
					{
						if ((0x19EB1CE5 ^ num) != 0)
						{
							do
							{
								num |= 0x4D0368B4;
								Monitor.Enter(obj6, ref lockTaken);
							}
							while (1921596405 == num);
							goto IL_03a7;
						}
						goto IL_03d1;
						IL_03d1:
						num = 1615205891u >> (int)num;
						num ^= 0x496B1BC8;
						Type type2 = _0D4C6B38._16871E65;
						Type? typeFromHandle = typeof(void);
						num = 1416565163 % num;
						bool num14 = type2 != typeFromHandle;
						num /= 41034730;
						object returnType;
						if (!num14)
						{
							returnType = null;
						}
						else
						{
							num = 1416391960 * num;
							num = 1300380916 / num;
							returnType = _0D4C6B38._16871E65;
							num ^= 4;
						}
						num /= 101848232;
						num = 1085242843 - num;
						num = 715146185 / num;
						Module module = typeof(_78492021).Module;
						num >>= 20;
						uint skipVisibility = num + 1;
						num = 0x45FF33FE & num;
						DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType, array3, module, (byte)skipVisibility != 0);
						num >>= 4;
						value = dynamicMethod;
						if (num >= 271063944)
						{
							goto IL_03a7;
						}
						DynamicMethod dynamicMethod2 = value;
						num = 1404269650 - num;
						ILGenerator iLGenerator = dynamicMethod2.GetILGenerator();
						num = 0xFB60AB | num;
						int num15 = (int)(num - 1408988411);
						while (true)
						{
							num = 844839762 / num;
							int num16 = num15;
							IntPtr intPtr3 = (nint)array3.LongLength;
							num += 377825781;
							int num17 = (int)(nint)intPtr3;
							num = 0x23F42C77 & num;
							if (num16 >= num17)
							{
								num = 823417116 - num;
								if (num + 1849783994 != 0)
								{
									break;
								}
							}
							num = 2015965712u;
							num /= 2032222193;
							OpCode opcode;
							if (!dictionary2.ContainsKey(num15))
							{
								opcode = OpCodes.Ldarg;
							}
							else
							{
								num *= 1904704401;
								opcode = OpCodes.Ldarga;
								num += 0;
							}
							int arg = num15;
							num = 828928318 * num;
							iLGenerator.Emit(opcode, arg);
							int num18 = num15;
							num ^= 0x164D3C2B;
							int num19 = num18 + (int)(num ^ 0x164D3C2A);
							num &= 0x148206FE;
							num15 = num19;
							num ^= 0x47FB70D1;
						}
						OpCode calli = OpCodes.Calli;
						num /= 661000940;
						CallingConvention unmanagedCallConv = _0D4C6B38._347C390F;
						num ^= 0x7EF615F8;
						iLGenerator.EmitCalli(calli, unmanagedCallConv, _0D4C6B38._16871E65, array);
						if ((0x2A637AC7 & num) == 0)
						{
							goto IL_03a7;
						}
						num = 0x9352A4D ^ num;
						iLGenerator.Emit(OpCodes.Ret);
						Dictionary<object, DynamicMethod> dictionary4 = _11FE66F3;
						num *= 71311126;
						num += 1059936264;
						DynamicMethod value2 = value;
						num *= 1124414778;
						dictionary4.Add(_0D4C6B38, value2);
						num ^= 0x126A52B6;
						goto end_IL_037b;
						IL_03a7:
						while (true)
						{
							bool num20 = _11FE66F3.TryGetValue(_0D4C6B38, out value);
							num = 0x60957DB6 | num;
							if (!num20)
							{
								if (1401112955 + num == 0)
								{
									continue;
								}
								goto IL_03d1;
							}
							break;
						}
						end_IL_037b:;
					}
					finally
					{
						num = 777203004u;
						bool num21 = lockTaken;
						num = 330854563 % num;
						if (num21)
						{
							Monitor.Exit(obj6);
							num += 0;
						}
					}
					num = 57946414u;
					if (169029755 / num != 0)
					{
						DynamicMethod dynamicMethod3 = value;
						num /= 345967706;
						num <<= 20;
						num <<= 8;
						object? obj7 = dynamicMethod3.Invoke(null, invokeAttr, null, array4, null);
						num |= 0x4B52CB7;
						obj8 = obj7;
						num = 768505675 % num;
					}
					Dictionary<int, _582960B3>.Enumerator enumerator = dictionary2.GetEnumerator();
					num -= 1972975964;
					Dictionary<int, _582960B3>.Enumerator enumerator2 = enumerator;
					try
					{
						while (true)
						{
							if (num < 2103979545 || enumerator2.MoveNext())
							{
								num = 885533677u;
								current = enumerator2.Current;
							}
							else if ((0xCB53ABB ^ num) != 0)
							{
								break;
							}
							num = 0x6E2F4086 ^ num;
							_582960B3 value3 = current.Value;
							object _63C = array4[current.Key];
							num |= 0x20F7180;
							value3._727F3897(_63C);
							num += 854011797;
						}
					}
					finally
					{
						do
						{
							num = 1350972490u;
							((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
						}
						while ((0x5A53051A & num) == 0);
					}
					num = 1323245579u;
					Type type3 = _0D4C6B38._16871E65;
					num = 1541888658 % num;
					num = 1016530155 / num;
					if (type3 != typeof(void))
					{
						num ^= 0x575E136B;
						goto IL_0792;
					}
					goto IL_07e8;
					IL_0792:
					num = 0x6B58739B ^ num;
					_1AF96773 obj9 = _40B8698E;
					num = 972308121 - num;
					object _52BC02CD = obj8;
					num >>= 10;
					num = 0x5AAD039B ^ num;
					Type _37AC2BCF = _0D4C6B38._16871E65;
					num = 1225028908 - num;
					obj9._20DB4AD4(_318778F9(_52BC02CD, _37AC2BCF));
					num += 294519748;
					goto IL_07e8;
					IL_07e8:
					if (1202984907 % num != 0)
					{
						return;
					}
					goto IL_0792;
					IL_0305:
					num |= 0x5A21B88;
					int num22 = num9;
					int num23 = (int)num ^ -1511072770;
					num %= 1016419087;
					num9 = num22 - num23;
					num += 2958339545u;
				}
			}
		}
		finally
		{
			num = 311759914u;
			if ((0x3FED6C35 & num) != 0)
			{
				_4E2E44B7.Dispose();
			}
		}
	}

	private void _163950BA()
	{
		while (true)
		{
			_6D2115ED _6D2115ED2 = new _6D2115ED();
			while (true)
			{
				uint num = 1809983799u;
				num = 169226300 % num;
				_1AF96773 obj = _40B8698E;
				num = 1483097259 * num;
				_582960B3 obj2 = obj._170D7B68();
				num = 21594055 % num;
				_6D2115ED2._0C3C7D51(obj2._6AAF062D());
				if (num / 1509972787 != 0)
				{
					break;
				}
				num >>= 11;
				_6D2115ED obj3 = _381D5F4F;
				num = 1982549016 * num;
				byte num2 = obj3._0F9F2D0A();
				num %= 852916879;
				uint num3 = num2;
				Dictionary<int, _582960B3> dictionary2;
				object[] array;
				while (true)
				{
					IL_006b:
					ushort num4 = (ushort)_6D2115ED2._4B03768E();
					num = 1178488370 % num;
					if ((0x3B1C70D6 & num) == 0)
					{
						break;
					}
					do
					{
						Dictionary<int, _582960B3> dictionary = new Dictionary<int, _582960B3>();
						num -= 1069684906;
						dictionary2 = dictionary;
						num *= 1266358428;
						num = 733306812 / num;
						array = null;
						num += 736694311;
					}
					while ((0x4AF43484 ^ num) == 0);
					uint num5 = num - 736694311;
					num ^= 0x3E992619;
					if ((int)num4 > (int)num5)
					{
						if (747861826u >> (int)num != 0)
						{
							break;
						}
						array = new object[num4];
						num -= 1601447800;
						if (num - 1226786918 == 0)
						{
							goto end_IL_0006;
						}
						num -= 431901149;
						int num6 = (int)num ^ -1673673496;
						num = 1457144505u >> (int)num;
						int num7 = num4 - num6;
						num = 0x3E377ED8 ^ num;
						int num8 = num7;
						while (true)
						{
							num ^= 0x73B070E7;
							if ((num ^ 0x33A8612A) == 0)
							{
								break;
							}
							int num9 = num8;
							num <<= 2;
							if (num9 >= (int)(num - 917605496))
							{
								num = 1627673812u;
								if ((0x76752A93 ^ num) == 0)
								{
									goto end_IL_0006;
								}
								_582960B3 _582960B4 = _40B8698E._170D7B68();
								num &= 0x568B54E5;
								if ((num ^ 0x7DF84C58) == 0)
								{
									break;
								}
								bool num10 = _582960B4._11EF2F40();
								num /= 644696779;
								if (num10)
								{
									if (num > 1812667729)
									{
										goto IL_006b;
									}
									dictionary2[num8] = _582960B4;
									num ^= 0;
								}
								num -= 847145830;
								object[] array2 = array;
								num /= 587297170;
								int num11 = num8;
								num = 1609189346u >> (int)num;
								num -= 660552797;
								num -= 264201328;
								num = (uint)(734613672 << (int)num);
								int _52213A = _6D2115ED2._435152A1();
								num ^= 0x15C92DC2;
								array2[num11] = _318778F9(_582960B4, _4B341A98(_52213A))._0936516D();
								if (108546843 + num == 0)
								{
									goto end_IL_0006;
								}
								int num12 = num8;
								num |= 0x13641B69;
								int num13 = num12 - (int)(num ^ 0x576D3FEA);
								num = 0x53C75BDF ^ num;
								num8 = num13;
								num += 963751877;
								continue;
							}
							goto IL_024c;
						}
						break;
					}
					goto IL_0254;
					IL_024c:
					num ^= 0x23C1BA46;
					goto IL_0254;
					IL_0254:
					if (num > 511990687)
					{
						goto end_IL_0006;
					}
					goto IL_025f;
				}
				continue;
				IL_025f:
				num = (uint)(477001630 << (int)num);
				int num14 = _6D2115ED2._435152A1();
				num = 0x2CF35BE1 ^ num;
				int num15 = num14;
				num >>= 16;
				uint num16 = num ^ 0xACF2;
				num = 1387881268 / num;
				uint num17 = num3 & num16;
				num = 1056780204 / num;
				uint num18 = num - 33713;
				num = 593580825 / num;
				bool num19 = num17 > num18;
				num -= 1495075410;
				if (num19)
				{
					num = 0xB9D6B93 | num;
					object[] array3 = array;
					num = 0x2D0208FC | num;
					if (array3 != null)
					{
						num = 983442192 % num;
						object[] array4 = array;
						num -= 1367042870;
						int num20 = (int)num ^ -383600678;
						num /= 315905596;
						object obj4 = array4[num20];
						num += 2799909480u;
						if (obj4 != null)
						{
							goto IL_0317;
						}
						num ^= 0x91C418B;
					}
					num = 1996118372 / num;
					throw new NullReferenceException();
				}
				goto IL_0317;
				IL_0317:
				object _52BC02CD = new _78492021()._4927337F(array, _6D2115ED2._77F36CDA());
				num /= 411913333;
				if (num - 485118329 == 0)
				{
					continue;
				}
				Dictionary<int, _582960B3>.Enumerator enumerator = dictionary2.GetEnumerator();
				num = (uint)(171141910 << (int)num);
				Dictionary<int, _582960B3>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						num = (uint)(1434850264 << (int)num);
						if (num <= 1666860751)
						{
							num += 901998267;
							if (!enumerator2.MoveNext())
							{
								break;
							}
						}
						num = 732569815u;
						KeyValuePair<int, _582960B3> current = enumerator2.Current;
						num += 377686578;
						num ^= 0x2DCE13C9;
						_582960B3 value = current.Value;
						object[] array5 = array;
						num = 0x55643398 & num;
						int key = current.Key;
						num = 426456511 + num;
						object _63C = array5[key];
						num = 1238514867 - num;
						value._727F3897(_63C);
						num ^= 0x67DC13F4;
					}
				}
				finally
				{
					do
					{
						num = 738478183u;
						((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
					}
					while ((0x5CD833DD & num) == 0);
				}
				num = 1576150906u;
				num <<= 22;
				if (num15 != 0)
				{
					num = 1693266937 % num;
					Type type = _4B341A98(num15);
					num = 0xF41162C | num;
					Type type2 = type;
					num /= 1147821425;
					bool num21 = type2 != typeof(void);
					num = 0x44BB4438 & num;
					num ^= 0xDE800000u;
					if (num21)
					{
						num &= 0x7EF043E1;
						_1AF96773 obj5 = _40B8698E;
						num = 1400570759 + num;
						num %= 1669539709;
						num = 0x30950645 | num;
						_582960B3 _5FD = _318778F9(_52BC02CD, type2);
						num += 737808747;
						obj5._20DB4AD4(_5FD);
						num += 864948294;
					}
				}
				return;
				continue;
				end_IL_0006:
				break;
			}
		}
	}

	private unsafe void _5DBC7F12()
	{
		Type type2;
		_582960B3 _582960B4;
		uint num;
		do
		{
			num = 660290622u;
			_6D2115ED obj = _381D5F4F;
			num -= 1214781238;
			int _52213A = obj._435152A1();
			num = 1581612664 + num;
			Type type = _4B341A98(_52213A);
			num |= 0x2DB428D8;
			type2 = type;
			while (true)
			{
				num = 0x42AB5466 | num;
				_1AF96773 obj2 = _40B8698E;
				num /= 1370974024;
				_582960B4 = obj2._170D7B68();
				IntPtr _75062F;
				if (num * 1540979273 != 0)
				{
					_582960B3 obj3 = _582960B4;
					num = 1380587640 / num;
					bool num2 = obj3._11EF2F40();
					num >>= 22;
					if (num2)
					{
						break;
					}
					_582960B3 obj4 = _582960B4;
					num = 523830139 + num;
					object obj5 = obj4._0936516D();
					num = 0x396220A0 ^ num;
					Pointer obj6 = obj5 as Pointer;
					num = 1757968705 % num;
					if (obj6 == null)
					{
						num /= 80157645;
						if (num > 225865966)
						{
							continue;
						}
						_582960B3 obj7 = _582960B4;
						num = 0x5BC97FDE ^ num;
						_75062F = obj7._47C01150();
						goto IL_00e1;
					}
				}
				num = 0xBC01AD3 & num;
				_75062F = new IntPtr(Pointer.Unbox(_582960B4._0936516D()));
				num += 1405710218;
				goto IL_00e1;
				IL_00e1:
				_582960B4 = new _443828F0(_75062F, type2);
				num ^= 0x5BC97E92;
				break;
			}
			num = 0x1CE16F01 & num;
		}
		while (num == 113450911);
		_40B8698E._20DB4AD4(_318778F9(_582960B4, type2));
	}

	private void _082D12F7()
	{
		uint num = 555897473u;
		Type type2;
		do
		{
			num = (uint)(1128150850 << (int)num);
			num %= 1919843117;
			Type type = _4B341A98(_381D5F4F._435152A1());
			num |= 0x1D361DDE;
			type2 = type;
			num = 468192449 + num;
		}
		while ((num ^ 0x428A4479) == 0);
		Dictionary<object, DynamicMethod> dictionary = _11FE66F3;
		num = 0x1DF2B42 | num;
		Dictionary<object, DynamicMethod> obj = dictionary;
		bool lockTaken = (byte)(num ^ 0x39FF2FE2) != 0;
		DynamicMethod value;
		try
		{
			num /= 575754574;
			Monitor.Enter(obj, ref lockTaken);
			Dictionary<object, DynamicMethod> dictionary2 = _11FE66F3;
			num &= 0x7D13344C;
			num = (uint)(2021532098 << (int)num);
			bool num2 = dictionary2.TryGetValue(type2, out value);
			num >>= 21;
			if (!num2)
			{
				num -= 1855000702;
				num &= 0x63B2633;
				Type? typeFromHandle = typeof(int);
				num *= 1395734458;
				Module module = typeof(_78492021).Module;
				num <<= 25;
				uint skipVisibility = num ^ 0x74000001;
				num = 0x45C95A58 | num;
				value = new DynamicMethod("", typeFromHandle, null, module, (byte)skipVisibility != 0);
				num = 0x2324080F & num;
				if (num / 855140329 == 0)
				{
					DynamicMethod dynamicMethod = value;
					num &= 0x640B45F1;
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					num = 939603124 - num;
					num = 1321677612u >> (int)num;
					OpCode opcode = OpCodes.Sizeof;
					num = 383848523 + num;
					iLGenerator.Emit(opcode, type2);
					num &= 0x136F7EDF;
					OpCode ret = OpCodes.Ret;
					num -= 182541410;
					iLGenerator.Emit(ret);
				}
				Dictionary<object, DynamicMethod> dictionary3 = _11FE66F3;
				num = 441454098u >> (int)num;
				DynamicMethod value2 = value;
				num += 880813386;
				dictionary3.Add(type2, value2);
				num += 3414154663u;
			}
		}
		finally
		{
			bool num3 = lockTaken;
			num = 361575452u;
			if (num3)
			{
				num = 1155340468 + num;
				num = (uint)(103690578 << (int)num);
				Monitor.Exit(obj);
				num += 3829085212u;
			}
		}
		num = 1459975980u;
		_1AF96773 obj2 = _40B8698E;
		DynamicMethod dynamicMethod2 = value;
		num |= 0x431010BE;
		num = 0x75B760E6 & num;
		num += 1633288509;
		object? obj3 = dynamicMethod2.Invoke(null, null);
		num *= 657918092;
		int _7A3475AA = (int)obj3;
		num /= 2114870546;
		obj2._20DB4AD4(new _50424ADC(_7A3475AA));
	}

	private void _77F911BF()
	{
		_582960B3 _582960B4 = default(_582960B3);
		while (true)
		{
			_6D2115ED obj = _381D5F4F;
			uint num = 152508235u;
			short num2 = obj._4B03768E();
			num = 0x8875694 | num;
			short _167A2AAF = num2;
			num ^= 0x216E45BF;
			if (num > 290470146)
			{
				goto IL_002d;
			}
			goto IL_0050;
			IL_0050:
			bool num3 = _582960B4._11EF2F40();
			num /= 1361122235;
			if (num3)
			{
				num <<= 13;
				if (num - 2003508605 != 0)
				{
					throw new ArgumentException();
				}
				goto IL_002d;
			}
			num += 832318122;
			_1AF96773 obj2 = _40B8698E;
			_582960B3 _70C = _582960B4;
			num = (uint)(625017811 << (int)num);
			_2D9A5DA0 _5FD = new _2D9A5DA0(_70C);
			num = 402865836 - num;
			obj2._20DB4AD4(_5FD);
			if (455890228 % num != 0)
			{
				break;
			}
			continue;
			IL_002d:
			_582960B3 obj3 = _40B8698E._40FF23BC(_167A2AAF);
			num = 1045918521u >> (int)num;
			_582960B4 = obj3;
			num += 1361125065;
			goto IL_0050;
		}
	}

	private void _1F3A06D2()
	{
		uint num = 205683757u;
		while (true)
		{
			num = 0x7AC85327 & num;
			num = 2020552331 + num;
			_6D2115ED obj = _381D5F4F;
			num <<= 12;
			int _52213A = obj._435152A1();
			num = 646143115 * num;
			Type _37AC2BCF = _4B341A98(_52213A);
			num >>= 6;
			_582960B3 _52BC02CD;
			do
			{
				_52BC02CD = _40B8698E._170D7B68();
				num = 0x40480376 & num;
			}
			while (1070744369 == num);
			num = (uint)(1283012111 << (int)num);
			_1AF96773 obj2 = _40B8698E;
			num >>= 17;
			_582960B3 obj3 = obj2._170D7B68();
			num &= 0xC810A19;
			_582960B3 _582960B4 = obj3;
			num -= 1249328807;
			_582960B3 obj4 = _40B8698E._170D7B68();
			num = (uint)(918048750 << (int)num);
			object obj5 = obj4._0936516D();
			num /= 1973881340;
			Array obj6 = obj5 as Array;
			num >>= 19;
			Array array = obj6;
			if (num < 1206392549)
			{
				if (array == null)
				{
					num = 0x5FC215FF ^ num;
					throw new ArgumentException();
				}
				num = 638533748 * num;
				num = 0x65493D82 ^ num;
				num = 772687523 % num;
				num ^= 0x72750A13;
				_582960B3 _52BC02CD2 = _318778F9(_52BC02CD, _37AC2BCF);
				num *= 690518097;
				Type type = array.GetType();
				num >>= 23;
				object value = _318778F9(_52BC02CD2, type.GetElementType())._0936516D();
				num = 726229742 % num;
				num = 578753365 * num;
				array.SetValue(value, _582960B4._6AAF062D());
				if (1626498916u >> (int)num != 0)
				{
					break;
				}
			}
		}
	}

	private void _7EA22F58()
	{
		uint num = 509880681u;
		object obj = _40B8698E._170D7B68()._0936516D();
		num -= 920520058;
		Exception obj2 = obj as Exception;
		num += 1754167461;
		if (obj2 == null)
		{
			throw new ArgumentException();
		}
		throw obj2;
	}

	private void _28F05C6A()
	{
		uint num = 2025551858u;
		int _52213A = _381D5F4F._435152A1();
		num = 233784466 + num;
		Type _37AC2BCF = _4B341A98(_52213A);
		num = 1145000545u >> (int)num;
		_582960B3 _582960B4;
		do
		{
			num *= 367414349;
			_582960B4 = _40B8698E._170D7B68();
		}
		while (num <= 1078743535);
		while (true)
		{
			_1AF96773 obj = _40B8698E;
			num = 1576863588 % num;
			_582960B3 obj2 = obj._170D7B68();
			num = 0x6E621FB ^ num;
			Array array = obj2._0936516D() as Array;
			num = 1217135585 / num;
			if (array == null)
			{
				num |= 0x39FC1873;
				throw new ArgumentException();
			}
			if (num < 2043486330)
			{
				_1AF96773 obj3 = _40B8698E;
				num <<= 6;
				num |= 0x556D2D2C;
				int index = _582960B4._6AAF062D();
				num %= 613160607;
				object? value = array.GetValue(index);
				num += 502740768;
				obj3._20DB4AD4(_318778F9(value, _37AC2BCF));
				if ((num & 0x4E985822) != 0)
				{
					break;
				}
			}
		}
	}

	private void _56E7079F()
	{
		uint num;
		do
		{
			num = 1563975862u;
			num = (uint)(266225011 << (int)num);
			_6D2115ED obj = _381D5F4F;
			num = 0x5703003D & num;
			int _52213A = obj._435152A1();
			num %= 1500262066;
			Type type = _4B341A98(_52213A);
			num >>= 4;
			Type type2 = type;
			num &= 0x12ED1FE6;
			if (num <= 349249805)
			{
				num = 1744987772 * num;
				_1AF96773 obj2 = _40B8698E;
				num = 1559384495 + num;
				num <<= 1;
				_1AF96773 obj3 = _40B8698E;
				num = (uint)(103353486 << (int)num);
				object _52BC02CD = obj3._170D7B68()._7BBC17CC(type2, (byte)(num - 2147483648u) != 0);
				num = 814689721 + num;
				obj2._20DB4AD4(_318778F9(_52BC02CD, type2));
				continue;
			}
			break;
		}
		while (538075287 >= num);
	}

	private void _381C352C()
	{
		uint num = 153447573u;
		Array array = default(Array);
		if (num <= 1878329360)
		{
			Array obj = _40B8698E._170D7B68()._0936516D() as Array;
			num /= 440342487;
			array = obj;
		}
		Array array2 = array;
		num *= 1160531147;
		if (array2 == null)
		{
			num = 272446652 + num;
		}
		else
		{
			_1AF96773 obj2 = _40B8698E;
			num = 0x5C00078F | num;
			int length = array.Length;
			num = 1678260721 * num;
			obj2._20DB4AD4(new _50424ADC(length));
			if ((num & 0xED37348) != 0)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	private void _4F1657F9()
	{
		uint num = 688066399u;
		if (num < 2033531243)
		{
			do
			{
				_1AF96773 obj = _40B8698E;
				num *= 1751666513;
				num <<= 21;
				_12C661FB _5FD = new _12C661FB(_40B8698E._170D7B68());
				num >>= 20;
				obj._20DB4AD4(_5FD);
			}
			while (num + 117919280 == 0);
		}
	}

	private void _5B994F51()
	{
		MethodBase methodBase2 = default(MethodBase);
		DynamicMethod value = default(DynamicMethod);
		Type[] array7 = default(Type[]);
		int num27 = default(int);
		KeyValuePair<int, _582960B3> current2 = default(KeyValuePair<int, _582960B3>);
		Type type3 = default(Type);
		while (true)
		{
			IL_0000:
			int num = _40B8698E._170D7B68()._6AAF062D();
			uint num2 = 998575110u;
			int num3 = num;
			if (num2 <= 1415331434)
			{
				goto IL_0025;
			}
			goto IL_004d;
			IL_004d:
			while (true)
			{
				IL_004d_2:
				_6D2115ED obj = _381D5F4F;
				num2 <<= 0;
				byte num4 = obj._0F9F2D0A();
				num2 = 458892485u >> (int)num2;
				uint num5 = num4;
				while (true)
				{
					MethodBase methodBase = methodBase2;
					num2 = 0x61214B64 | num2;
					Type[] array2;
					if (methodBase.CallingConvention == (CallingConventions)((int)num2 + -1744292723))
					{
						num2 = 0x33B57617 ^ num2;
						if (955588086 > num2)
						{
							break;
						}
						num2 >>= 17;
						_0D4C6B37 obj2 = _46C53560(num3);
						num2 = 1425626168 % num2;
						bool num6 = obj2._27023992;
						num2 >>= 6;
						if (!num6)
						{
							num2 = 0x6A81132D & num2;
							throw new ArgumentException();
						}
						num2 ^= 0x73300B83;
						Type[] array = obj2._181E08D4();
						num2 = 112217187 + num2;
						array2 = array;
						goto IL_01f5;
					}
					MethodBase methodBase3 = methodBase2;
					num2 >>= 10;
					ParameterInfo[] parameters = methodBase3.GetParameters();
					num2 <<= 25;
					ParameterInfo[] array3 = parameters;
					if (674372268 > num2)
					{
						goto IL_0000;
					}
					num2 <<= 7;
					array2 = new Type[array3.Length];
					num2 = 0x72F620E0 & num2;
					uint num7 = num2 ^ 0;
					num2 = 719478941u >> (int)num2;
					int num8 = (int)num7;
					if (1878355529 != num2)
					{
						while ((0x1C9F00B9 ^ num2) != 0)
						{
							int num9 = num8;
							num2 /= 1564958680;
							if (num9 < array3.Length)
							{
								num2 = 1701003003u;
								Type[] array4 = array2;
								num2 = 0x10FF7D1D & num2;
								array4[num8] = array3[num8].ParameterType;
								if (1202866763 == num2)
								{
									goto IL_0000;
								}
								int num10 = num8;
								num2 *= 1724518482;
								num8 = num10 + ((int)num2 - -1253781503);
								num2 ^= 0x9FA6B09Fu;
								continue;
							}
							goto IL_01eb;
						}
						break;
					}
					goto IL_004d_2;
					IL_01eb:
					num2 ^= 0x79E057E4;
					goto IL_01f5;
					IL_01f5:
					bool flag;
					BindingFlags bindingFlags;
					MethodInfo methodInfo2;
					while (true)
					{
						num2 -= 1601452108;
						num2 -= 239014105;
						uint num11 = num2 ^ 0xC2D0EBE;
						num2 = 1044647852 * num2;
						flag = (num5 & num11) > (num2 ^ 0xFEDF1954u);
						num2 = 1090218346u >> (int)num2;
						if (num2 > 497839260)
						{
							break;
						}
						num2 = 0x185B207F ^ num2;
						uint num12 = num5 & (num2 ^ 0x185B2460);
						int num13 = (int)num2 + -408626288;
						num2 ^= 0x6713150A;
						if (num12 > (uint)num13)
						{
							num2 = 701777371u >> (int)num2;
							if ((0x25413416 ^ num2) == 0)
							{
								break;
							}
							num2 = 0x25796B8D & num2;
							_1AF96773 obj3 = _40B8698E;
							num2 = 0x49F5589A & num2;
							_582960B3 obj4 = obj3._170D7B68();
							num2 <<= 21;
							int _52213A = obj4._6AAF062D();
							num2 = 0x96C0B24 ^ num2;
							Type type = _4B341A98(_52213A);
							MethodBase methodBase4 = methodBase2;
							num2 = 0x4C823901 | num2;
							string name = methodBase4.Name;
							uint bindingAttr = num2 - 1290668529;
							num2 <<= 5;
							Type[] types = array2;
							num2 = 1339112707 / num2;
							num2 <<= 4;
							MethodInfo? method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
							num2 <<= 23;
							MethodInfo methodInfo = method;
							num2 ^= 0x7DC4323C;
							if (182867546 << (int)num2 == 0)
							{
								break;
							}
							bool num14 = methodInfo != null;
							num2 ^= 0x28C0346;
							if (num14)
							{
								num2 = (uint)(614563049 << (int)num2);
								methodBase2 = methodInfo;
								num2 ^= 0xDB48317Au;
							}
						}
						num2 += 1418411258;
						bindingFlags = (BindingFlags)(num2 + 741118348);
						if (778114175 >= num2)
						{
							break;
						}
						MethodBase methodBase5 = methodBase2;
						num2 = 1736445122 + num2;
						methodInfo2 = methodBase5 as MethodInfo;
						num2 &= 0x4C8321E6;
						if ((num2 & 0x5895191) == 0)
						{
							continue;
						}
						goto IL_03b4;
					}
					goto IL_0000;
					IL_03b4:
					Dictionary<int, _582960B3> dictionary = new Dictionary<int, _582960B3>();
					if (num2 > 574059186)
					{
						continue;
					}
					Type[] array5 = array2;
					num2 /= 283069132;
					int num15 = array5.Length;
					num2 -= 1462046818;
					object[] array6 = new object[num15];
					_4E2E44B6 obj5 = new _4E2E44B6();
					num2 += 1893479494;
					_4E2E44B6 _4E2E44B7 = obj5;
					try
					{
						num2 = 1059873673 / num2;
						while (true)
						{
							num2 += 314514294;
							int num16 = array6.Length;
							uint num17 = num2 ^ 0x12BF1B79;
							num2 |= 0x22456FC5;
							int num18 = num16 - (int)num17;
							while (true)
							{
								num2 = 0x15EF3E00 & num2;
								if (num18 >= (int)(num2 - 284114432))
								{
									goto IL_0429;
								}
								MethodBase methodBase6 = methodBase2;
								num2 <<= 10;
								bool isStatic = methodBase6.IsStatic;
								num2 /= 1249774431;
								object obj6;
								if (!isStatic)
								{
									if (num2 >= 1793343986)
									{
										break;
									}
									num2 = 144198398 + num2;
									obj6 = _40B8698E._170D7B68();
								}
								else
								{
									num2 = 0x43915989 ^ num2;
									if (144273923 * num2 == 0)
									{
										goto IL_0441;
									}
									obj6 = null;
									num2 += 3305566581u;
								}
								_582960B3 _582960B4 = (_582960B3)obj6;
								if ((0x22A21CE5 ^ num2) == 0)
								{
									break;
								}
								_582960B3 obj7 = _582960B4;
								num2 %= 718955977;
								object obj8;
								if (obj7 == null)
								{
									num2 = 1322057842 * num2;
									obj8 = null;
								}
								else
								{
									_582960B3 obj9 = _582960B4;
									num2 = 0x201926B7 | num2;
									obj8 = obj9._0936516D();
									num2 ^= 0xCA4809B7u;
								}
								if (obj8 == null)
								{
									num2 = 1557729148u >> (int)num2;
									obj8 = null;
									num2 ^= 0xBE08697Cu;
								}
								num2 = 1667201353 % num2;
								object obj10 = obj8;
								num2 &= 0x1BA935A1;
								if ((num2 & 0x57FB3818) == 0)
								{
									break;
								}
								num2 = 949045852u >> (int)num2;
								if (flag)
								{
									num2 <<= 7;
									object obj11 = obj10;
									num2 ^= 0x19A56F2A;
									num2 ^= 0x21BF5D04;
									if (obj11 == null)
									{
										num2 >>= 18;
										if (1394617277 << (int)num2 != 0)
										{
											throw new NullReferenceException();
										}
										goto IL_0441;
									}
								}
								num2 += 1073434227;
								if (1756724446 % num2 == 0)
								{
									break;
								}
								num2 &= 0xDE31D11;
								object _2BDA0AE = null;
								num2 = 651192330 * num2;
								if (num2 < 961033623)
								{
									break;
								}
								MethodBase methodBase7 = methodBase2;
								num2 = (uint)(872953673 << (int)num2);
								Dictionary<int, _582960B3>.Enumerator enumerator;
								if (methodBase7.CallingConvention == (CallingConventions)((int)num2 + -551363582))
								{
									if (num2 == 1069304479)
									{
										break;
									}
									Dictionary<object, DynamicMethod> dictionary2 = _11FE66F3;
									num2 *= 517232938;
									Dictionary<object, DynamicMethod> dictionary3 = dictionary2;
									uint num19 = num2 ^ 0x15CBE800;
									num2 = 466118760 + num2;
									bool lockTaken = (byte)num19 != 0;
									try
									{
										while (true)
										{
											Monitor.Enter(dictionary3, ref lockTaken);
											num2 = 0x3D1147D4 ^ num2;
											if ((num2 ^ 0x68A71BD4) == 0)
											{
												continue;
											}
											Dictionary<object, DynamicMethod> dictionary4 = _11FE66F3;
											num2 = 2101939947 * num2;
											num2 >>= 1;
											object key = num3;
											num2 &= 0xB1573F7;
											num2 = 1780180037 + num2;
											bool num20 = dictionary4.TryGetValue(key, out value);
											num2 = 1371633526 % num2;
											if (!num20)
											{
												if ((num2 & 0x3E417A68) != 0)
												{
													goto IL_082c;
												}
												goto IL_090b;
											}
											goto IL_0b24;
											IL_090b:
											num2 = 2092171712 * num2;
											object returnType2;
											if (methodInfo2 != null)
											{
												num2 /= 335217168;
												Type returnType = methodInfo2.ReturnType;
												num2 <<= 8;
												num2 |= 0x3E643BE4;
												Type? typeFromHandle = typeof(void);
												num2 ^= 0x70A7742D;
												bool num21 = returnType != typeFromHandle;
												num2 %= 440221236;
												if (num21)
												{
													returnType2 = methodInfo2.ReturnType;
													num2 += 1523041683;
													goto IL_0995;
												}
												num2 += 1523041683;
											}
											returnType2 = null;
											goto IL_0995;
											IL_0995:
											num2 *= 691144992;
											Type[] parameterTypes = array2;
											Module module = typeof(_78492021).Module;
											int skipVisibility = (int)num2 + -2046269439;
											num2 <<= 11;
											DynamicMethod dynamicMethod = new DynamicMethod("", (Type?)returnType2, parameterTypes, module, (byte)skipVisibility != 0);
											num2 = 612782773 - num2;
											value = dynamicMethod;
											num2 = 757158217 - num2;
											ILGenerator iLGenerator = value.GetILGenerator();
											int num22 = (int)num2 ^ -983892332;
											if ((0x68E91275 ^ num2) == 0)
											{
												continue;
											}
											while (true)
											{
												num2 <<= 11;
												int num23 = num22;
												IntPtr intPtr = (nint)array2.LongLength;
												num2 &= 0x7C9B7972;
												if (num23 >= (int)(nint)intPtr)
												{
													break;
												}
												num2 = 1784620609u;
												OpCode ldarg = OpCodes.Ldarg;
												int arg = num22;
												num2 -= 457912337;
												iLGenerator.Emit(ldarg, arg);
												int num24 = num22;
												uint num25 = num2 ^ 0x4F13F631;
												num2 = (uint)(245313700 << (int)num2);
												int num26 = num24 + (int)num25;
												num2 = 1718836263 * num2;
												num22 = num26;
												num2 ^= 0x9DA6FE94u;
											}
											num2 = 1665493733u >> (int)num2;
											if (1844608494 >>> (int)num2 == 0)
											{
												goto IL_0855;
											}
											num2 = 1193835211 / num2;
											OpCode call = OpCodes.Call;
											num2 = 0x121C69D8 | num2;
											iLGenerator.EmitCall(call, methodInfo2, array7);
											num2 >>= 12;
											num2 |= 0x4A3215D8;
											iLGenerator.Emit(OpCodes.Ret);
											if (1183136545 == num2)
											{
												goto IL_082c;
											}
											Dictionary<object, DynamicMethod> dictionary5 = _11FE66F3;
											num2 = 1007891508 - num2;
											num2 = 0x62AE4165 ^ num2;
											object key2 = num3;
											num2 = 0x489074A ^ num2;
											DynamicMethod value2 = value;
											num2 |= 0x43117E1B;
											dictionary5.Add(key2, value2);
											num2 += 2043115771;
											goto IL_0b24;
											IL_0b24:
											if (num2 - 178596842 != 0)
											{
												break;
											}
											goto IL_082c;
											IL_082c:
											num2 = 0xAD90F5E ^ num2;
											IntPtr intPtr2 = (nint)methodInfo2.GetParameters().LongLength;
											num2 += 275322289;
											num27 = (int)(nint)intPtr2;
											num2 = 0x475517DB | num2;
											goto IL_0855;
											IL_0855:
											IntPtr intPtr3 = (nint)array2.LongLength;
											num2 = 347764146 / num2;
											int num28 = (int)(nint)intPtr3;
											num2 = 1653610693 + num2;
											int num29 = num27;
											num2 *= 233251194;
											int num30 = num28 - num29;
											num2 += 2041856368;
											array7 = new Type[num30];
											num2 ^= 0x58EE3276;
											Type[] sourceArray = array2;
											num2 *= 1481972681;
											int sourceIndex = num27;
											num2 = 0x62C0E02 ^ num2;
											Type[] destinationArray = array7;
											num2 = 0x49750896 | num2;
											int destinationIndex = (int)num2 - -537405226;
											Type[] array8 = array2;
											num2 = 1103698261 - num2;
											int num31 = array8.Length;
											num2 += 1053716682;
											int num32 = num27;
											num2 ^= 0x7B05532C;
											int length = num31 - num32;
											num2 /= 865487638;
											Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
											num2 = 0x2D2A1B09 ^ num2;
											if (num2 == 132137770)
											{
												continue;
											}
											goto IL_090b;
										}
									}
									finally
									{
										if (lockTaken)
										{
											Dictionary<object, DynamicMethod> obj12 = dictionary3;
											num2 = 1505900963u;
											Monitor.Exit(obj12);
										}
									}
								}
								else
								{
									while (true)
									{
										MethodBase methodBase8 = methodBase2;
										num2 = 0x20E844E7 & num2;
										bool isConstructor = methodBase8.IsConstructor;
										num2 = 2008421839 / num2;
										if (isConstructor)
										{
											goto IL_0bbd;
										}
										goto IL_0cce;
										IL_0cce:
										if (538004630 - num2 == 0)
										{
											break;
										}
										MethodBase _31536C6D = methodBase2;
										object _43DB = obj10;
										num2 <<= 7;
										bool num33 = _77AD0510(_31536C6D, _43DB, ref _2BDA0AE, array6);
										num2 ^= 0x26426C9A;
										if (!num33)
										{
											if (num2 > 1299080376)
											{
												goto IL_0bbd;
											}
											if (flag)
											{
												goto IL_1510;
											}
											num2 = 294404180 * num2;
											if (num2 % 2056001351 != 0)
											{
												bool isVirtual = methodBase2.IsVirtual;
												num2 -= 1556834795;
												num2 += 4123232893u;
												if (!isVirtual)
												{
													goto IL_1510;
												}
												if (2040152632 >= num2)
												{
													bool isFinal = methodBase2.IsFinal;
													num2 ^= 0;
													if (isFinal)
													{
														goto IL_1510;
													}
													Type[] array9 = array2;
													num2 = 1106337411 * num2;
													IntPtr intPtr4 = (nint)array9.LongLength;
													num2 -= 61621239;
													int num34 = (int)(nint)intPtr4;
													uint num35 = num2 ^ 0x43DB1C56;
													num2 %= 1686381053;
													object[] array10 = new object[num34 + (int)num35];
													num2 |= 0x7B434971;
													object[] array11 = array10;
													num2 = 1236672874 * num2;
													if (num2 == 934285585)
													{
														continue;
													}
													num2 = 0xC5263DD & num2;
													uint num36 = num2 ^ 0x520244;
													object obj13 = obj10;
													num2 ^= 0x133B754B;
													array11[num36] = obj13;
													num2 *= 1684169864;
													int num37 = (int)num2 ^ -230220808;
													if (1111249684 > num2)
													{
														break;
													}
													while (true)
													{
														int num38 = num37;
														num2 = 900928750u >> (int)num2;
														Type[] array12 = array2;
														num2 = 0x60E152AA ^ num2;
														IntPtr intPtr5 = (nint)array12.LongLength;
														num2 = (uint)(8416262 << (int)num2);
														if (num38 < (int)(nint)intPtr5)
														{
															num2 = 1541025562u;
															if (num2 * 495614184 == 0)
															{
																break;
															}
															int num39 = num37;
															num2 >>= 0;
															uint num40 = num2 - 1541025561;
															num2 = 173177023 / num2;
															int num41 = num39 + (int)num40;
															num2 = 232681971 * num2;
															int num42 = num37;
															num2 = 501375036 * num2;
															object obj14 = array6[num42];
															num2 -= 1071867731;
															array11[num41] = obj14;
															if (num2 << 16 == 0)
															{
																goto end_IL_0b9d;
															}
															int num43 = num37;
															num2 = 0x123934EA ^ num2;
															num37 = num43 + ((int)num2 - -769283002);
															num2 += 539062193;
															continue;
														}
														num2 &= 0x45D61F1;
														Dictionary<object, DynamicMethod> dictionary3 = _11FE66F3;
														num2 = 159145465u >> (int)num2;
														bool lockTaken = (byte)(num2 - 159145465) != 0;
														DynamicMethod value3;
														try
														{
															while (true)
															{
																IL_0ee7:
																Dictionary<object, DynamicMethod> obj15 = dictionary3;
																num2 &= 0xA3364C6;
																num2 |= 0x4AA64558;
																Monitor.Enter(obj15, ref lockTaken);
																while (true)
																{
																	IL_0f04:
																	bool num44 = _11FE66F3.TryGetValue(methodBase2, out value3);
																	num2 = 493376880 - num2;
																	if (num44)
																	{
																		break;
																	}
																	num2 = 1030291643 / num2;
																	while (true)
																	{
																		num2 |= 0x37CB22D6;
																		int num45 = array11.Length;
																		num2 ^= 0x56235A14;
																		Type[] array13 = new Type[num45];
																		num2 = 0x9B904E1 | num2;
																		Type[] array14 = array13;
																		num2 |= 0x270B7D3E;
																		if ((num2 ^ 0x191E609B) == 0)
																		{
																			break;
																		}
																		num2 = 195113305 + num2;
																		int num46 = (int)num2 + -2073866072;
																		num2 >>= 10;
																		MethodBase methodBase9 = methodBase2;
																		num2 = 1152788959 * num2;
																		Type? declaringType = methodBase9.DeclaringType;
																		num2 = 0x2E1215A5 ^ num2;
																		array14[num46] = declaringType;
																		int num47 = (int)num2 ^ -57584432;
																		while (true)
																		{
																			int num48 = num47;
																			int num49 = array2.Length;
																			num2 = 259155726 % num2;
																			if (num48 < num49)
																			{
																				num2 = 1012083457u;
																				if (569847174 % num2 != 0)
																				{
																					num2 += 673196281;
																					int num50 = num47;
																					num2 = 1284327947 + num2;
																					int num51 = (int)num2 - -1325359612;
																					num2 %= 113448530;
																					int num52 = num50 + num51;
																					Type[] array15 = array2;
																					int num53 = num47;
																					num2 = (uint)(1402086725 << (int)num2);
																					Type obj16 = array15[num53];
																					num2 *= 484980793;
																					array14[num52] = obj16;
																					num2 = 2073510421 * num2;
																					if (597124025 << (int)num2 == 0)
																					{
																						goto IL_0f04;
																					}
																					int num54 = num47;
																					num2 = 0x42AE36DA | num2;
																					num47 = num54 + ((int)num2 + -1810773721);
																					num2 ^= 0x977F620Au;
																				}
																				continue;
																			}
																			num2 -= 932053741;
																			if (1555135070 == num2)
																			{
																				break;
																			}
																			num2 = 1377653346 * num2;
																			num2 = 0x553E4B09 | num2;
																			bool num55 = methodInfo2 != null;
																			num2 ^= 0x3ADB50DC;
																			object returnType4;
																			if (num55)
																			{
																				num2 = 0x27F47222 | num2;
																				num2 ^= 0x5A22688A;
																				Type returnType3 = methodInfo2.ReturnType;
																				num2 &= 0x34654C8C;
																				if (returnType3 != typeof(void))
																				{
																					returnType4 = methodInfo2.ReturnType;
																					num2 ^= 0x344404F8;
																					goto IL_1110;
																				}
																				num2 += 2577447659u;
																			}
																			num2 = 975716240u >> (int)num2;
																			returnType4 = null;
																			goto IL_1110;
																			IL_1110:
																			num2 = (uint)(1220572172 << (int)num2);
																			num2 |= 0x73F700FF;
																			Type? typeFromHandle2 = typeof(_78492021);
																			num2 <<= 2;
																			value3 = new DynamicMethod("", (Type?)returnType4, array14, typeFromHandle2.Module, (byte)(num2 - 3487302651u) != 0);
																			DynamicMethod dynamicMethod2 = value3;
																			num2 ^= 0x1E4C775D;
																			ILGenerator iLGenerator2 = dynamicMethod2.GetILGenerator();
																			num2 &= 0x3E5C046A;
																			ILGenerator iLGenerator3 = iLGenerator2;
																			num2 = (uint)(1150055580 << (int)num2);
																			if ((0x645E03E9 ^ num2) == 0)
																			{
																				goto end_IL_0f2b;
																			}
																			num2 = 252322860 - num2;
																			OpCode opcode;
																			if (!_582960B4._11EF2F40())
																			{
																				opcode = OpCodes.Ldarg;
																			}
																			else
																			{
																				opcode = OpCodes.Ldarga;
																				num2 ^= 0;
																			}
																			uint arg2 = num2 + 897732720;
																			num2 = 0x2DFD0C46 | num2;
																			iLGenerator3.Emit(opcode, (int)arg2);
																			int num56 = (int)(num2 + 268587051);
																			if ((num2 & 0x2DB468D6) == 0)
																			{
																				goto end_IL_0f2b;
																			}
																			while (true)
																			{
																				int num57 = num56;
																				num2 = 788740295 * num2;
																				IntPtr intPtr6 = (nint)array14.LongLength;
																				num2 |= 0x2B05BD6;
																				int num58 = (int)(nint)intPtr6;
																				num2 <<= 9;
																				if (num57 >= num58)
																				{
																					break;
																				}
																				int num59 = num56;
																				num2 = 255593354u;
																				bool num60 = dictionary.ContainsKey(num59 - ((int)num2 + -255593353));
																				num2 -= 858020944;
																				OpCode opcode2;
																				if (!num60)
																				{
																					opcode2 = OpCodes.Ldarg;
																				}
																				else
																				{
																					opcode2 = OpCodes.Ldarga;
																					num2 += 0;
																				}
																				int arg3 = num56;
																				num2 = 1129470792 + num2;
																				iLGenerator3.Emit(opcode2, arg3);
																				num2 ^= 0x1C7B5C6E;
																				int num61 = num56;
																				num2 &= 0x730E73CC;
																				uint num62 = num2 ^ 0x30052CD;
																				num2 &= 0x631629BC;
																				num56 = num61 + (int)num62;
																				num2 += 3976048458u;
																			}
																			if (1702628660 > num2)
																			{
																				break;
																			}
																			num2 = 0xA396F0E & num2;
																			OpCode call2 = OpCodes.Call;
																			num2 += 694816100;
																			iLGenerator3.Emit(call2, methodInfo2);
																			if (471883747 > num2)
																			{
																				break;
																			}
																			num2 -= 836510859;
																			iLGenerator3.Emit(OpCodes.Ret);
																			num2 &= 0x19BD37A3;
																			if (num2 + 144640156 == 0)
																			{
																				continue;
																			}
																			Dictionary<object, DynamicMethod> dictionary6 = _11FE66F3;
																			num2 ^= 0xF942C08;
																			dictionary6.Add(methodBase2, value3);
																			num2 += 3164657423u;
																			goto end_IL_0f04;
																		}
																		continue;
																		end_IL_0f2b:
																		break;
																	}
																	goto IL_0ee7;
																	continue;
																	end_IL_0f04:
																	break;
																}
																break;
															}
														}
														finally
														{
															num2 = 397347491u;
															if (lockTaken)
															{
																num2 |= 0x27DA621D;
																if (58351585 + num2 != 0)
																{
																	goto IL_1357;
																}
															}
															goto IL_1368;
															IL_1368:
															if (114185318 > num2)
															{
																goto IL_1357;
															}
															goto end_IL_1332;
															IL_1357:
															Monitor.Exit(dictionary3);
															num2 ^= 0x2050601C;
															goto IL_1368;
															end_IL_1332:;
														}
														do
														{
															DynamicMethod dynamicMethod3 = value3;
															num2 = 148001842u;
															num2 >>= 14;
															num2 = 1461004459 - num2;
															num2 >>= 8;
															object? obj17 = dynamicMethod3.Invoke(null, bindingFlags, null, array11, null);
															num2 = 0x114261E1 & num2;
															_2BDA0AE = obj17;
															num2 /= 1947156317;
														}
														while (num2 >= 1275661671);
														num2 = 0x6192445D ^ num2;
														enumerator = dictionary.GetEnumerator();
														try
														{
															while (true)
															{
																num2 |= 0x405E67DD;
																num2 %= 1992431832;
																bool num63 = enumerator.MoveNext();
																num2 = 2130200930 / num2;
																if (!num63)
																{
																	break;
																}
																while (true)
																{
																	num2 = 1589579560u;
																	if ((0x4D8F68FD ^ num2) == 0)
																	{
																		break;
																	}
																	KeyValuePair<int, _582960B3> current = enumerator.Current;
																	num2 ^= 0x339D2C22;
																	KeyValuePair<int, _582960B3> keyValuePair = current;
																	num2 |= 0x4BD4052F;
																	if (num2 * 930484935 != 0)
																	{
																		num2 &= 0x424B710D;
																		_582960B3 value4 = keyValuePair.Value;
																		num2 = (uint)(1433944640 << (int)num2);
																		num2 = 566065776 % num2;
																		num2 = 0x106B6C27 ^ num2;
																		int key3 = keyValuePair.Key;
																		uint num64 = num2 ^ 0x10F61656;
																		num2 &= 0x24280DD8;
																		int num65 = key3 + (int)num64;
																		num2 &= 0x6AE749BE;
																		object _63C = array11[num65];
																		num2 ^= 0x5518201F;
																		value4._727F3897(_63C);
																		num2 ^= 0x34AA6452;
																		break;
																	}
																}
															}
														}
														finally
														{
															num2 = 1960510540u;
															if (num2 + 2138792766 != 0)
															{
																((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
															}
														}
														num2 = 1122173584u;
														if (num2 / 1917063048 == 0)
														{
															dictionary.Clear();
															num2 ^= 0x64A16F8A;
														}
														break;
													}
												}
											}
										}
										goto IL_1569;
										IL_1510:
										num2 = 1983143214 * num2;
										if (1119112407 > num2)
										{
											MethodBase methodBase10 = methodBase2;
											num2 = 0x170B5760 | num2;
											object obj18 = obj10;
											num2 = 1791061105 * num2;
											num2 &= 0x7A4A37A8;
											object? obj19 = methodBase10.Invoke(obj18, bindingFlags, null, array6, null);
											num2 = 0x65DD3F8E | num2;
											_2BDA0AE = obj19;
											num2 ^= 0x5B9F52B4;
										}
										goto IL_1569;
										IL_0bbd:
										Type? declaringType2 = methodBase2.DeclaringType;
										num2 = 0x23340D1 & num2;
										bool isValueType = declaringType2.IsValueType;
										num2 += 901318953;
										num2 += 3393648345u;
										if (!isValueType)
										{
											goto IL_0cce;
										}
										Type? declaringType3 = methodBase2.DeclaringType;
										num2 += 1531732992;
										num2 /= 527591138;
										num2 = 40982140 / num2;
										num2 /= 952569077;
										object? obj20 = Activator.CreateInstance(declaringType3, bindingFlags, null, array6, null);
										num2 = 0x43C57CC0 & num2;
										obj10 = obj20;
										if (1243694738 * num2 != 0)
										{
											break;
										}
										_582960B3 obj21 = _582960B4;
										num2 &= 0x341F3FE9;
										num2 += 641887514;
										if (obj21 != null)
										{
											if (num2 < 37058890)
											{
												break;
											}
											bool num66 = _582960B4._11EF2F40();
											num2 += 0;
											if (num66)
											{
												_582960B3 obj22 = _582960B4;
												num2 <<= 5;
												object _52BC02CD = obj10;
												MethodBase methodBase11 = methodBase2;
												num2 = 0x3E300C70 ^ num2;
												Type? declaringType4 = methodBase11.DeclaringType;
												num2 = 1237286298 + num2;
												object _63C2 = _318778F9(_52BC02CD, declaringType4)._0936516D();
												num2 -= 289302780;
												obj22._727F3897(_63C2);
												num2 ^= 0x8BCAED4;
											}
										}
										goto IL_1569;
										continue;
										end_IL_0b9d:
										break;
									}
								}
								num2 = 39744962u;
								if (num2 / 300684565 == 0)
								{
									DynamicMethod dynamicMethod4 = value;
									num2 = 0x6EC464E2 ^ num2;
									num2 = 0x7DD75AC1 ^ num2;
									num2 = 1593780085 - num2;
									object? obj23 = dynamicMethod4.Invoke(null, bindingFlags, null, array6, null);
									num2 = 641887514 % num2;
									_2BDA0AE = obj23;
								}
								goto IL_1569;
								IL_1569:
								while (num2 / 1404960813 != 0)
								{
								}
								num2 %= 2106023118;
								enumerator = dictionary.GetEnumerator();
								try
								{
									if (1438390973 >>> (int)num2 == 0)
									{
										goto IL_15a1;
									}
									goto IL_15e7;
									IL_15e7:
									num2 >>= 5;
									bool num67 = enumerator.MoveNext();
									num2 |= 0x4572ED8;
									if (num67)
									{
										goto IL_15a1;
									}
									if (618426037 < num2)
									{
										goto IL_15bd;
									}
									goto end_IL_1589;
									IL_15a1:
									current2 = enumerator.Current;
									num2 = 225592272u;
									if (1574321561 != num2)
									{
										goto IL_15bd;
									}
									goto IL_15e7;
									IL_15bd:
									_582960B3 value5 = current2.Value;
									int key4 = current2.Key;
									num2 >>= 30;
									value5._727F3897(array6[key4]);
									num2 += 641887514;
									goto IL_15e7;
									end_IL_1589:;
								}
								finally
								{
									num2 = 547696297u;
									if (325873157 < num2)
									{
										num2 = 1767329073u >> (int)num2;
										((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
									}
								}
								num2 = 2092457088u;
								if (1531990364 < num2)
								{
									num2 = 1097286323u >> (int)num2;
									num2 |= 0x224B0FC4;
									if (!(methodInfo2 != null))
									{
										return;
									}
								}
								num2 = 558636575 / num2;
								Type returnType5 = methodInfo2.ReturnType;
								num2 = 2143504921 + num2;
								num2 = 163269923 + num2;
								Type? typeFromHandle3 = typeof(void);
								num2 = 913781239 - num2;
								bool num68 = returnType5 != typeFromHandle3;
								num2 = (uint)(1336695794 << (int)num2);
								num2 ^= 0xF36F4FF7u;
								if (num68)
								{
									num2 -= 859533437;
									_1AF96773 obj24 = _40B8698E;
									_582960B3 _5FD = _318778F9(_2BDA0AE, methodInfo2.ReturnType);
									num2 <<= 16;
									obj24._20DB4AD4(_5FD);
									num2 += 2213892087u;
								}
								return;
								IL_058b:
								num2 -= 962474436;
								int num69 = num18;
								num2 = 0x500E4E69 ^ num2;
								num18 = num69 - (int)(num2 ^ 0xB706EA6Cu);
								num2 ^= 0x85F99590u;
								continue;
								IL_0441:
								_582960B4 = _40B8698E._170D7B68();
								num2 /= 1878337557;
								_582960B3 obj25 = _582960B4;
								num2 = 0x61907160 ^ num2;
								bool num70 = obj25._11EF2F40();
								num2 = 0x153102DB & num2;
								if (num70)
								{
									num2 = (uint)(1082870256 << (int)num2);
									Type type2 = type3;
									num2 = 82968864 / num2;
									if (!type2.IsByRef)
									{
										if (num2 < 1198931502)
										{
											num2 *= 1898537108;
											int num71 = num18;
											num2 &= 0x368D6B26;
											_582960B3 obj26 = _582960B4;
											num2 = (uint)(2020418901 << (int)num2);
											object _01001C0B = obj26._0936516D();
											num2 %= 1476808589;
											object obj27 = _4E2E44B7._33CD5A83(_01001C0B);
											num2 %= 1132944499;
											array6[num71] = obj27;
											if (num2 / 696911366 != 0)
											{
												break;
											}
											goto IL_058b;
										}
										goto IL_0429;
									}
									num2 <<= 15;
									num2 = 0x436E7215 ^ num2;
									dictionary[num18] = _582960B4;
									num2 ^= 0x427E7255;
								}
								num2 -= 1124421819;
								num2 = 17917576u >> (int)num2;
								int num72 = num18;
								num2 &= 0x5A3561E2;
								num2 = 0x23743C3D ^ num2;
								object obj28 = _318778F9(_582960B4, type3)._0936516D();
								num2 -= 1488389774;
								array6[num72] = obj28;
								num2 ^= 0xEADBE347u;
								goto IL_058b;
								IL_0429:
								num2 = 928675363u;
								type3 = array2[num18];
								num2 = 0x2E1B4742 & num2;
								goto IL_0441;
							}
						}
					}
					finally
					{
						num2 = 1335504700u;
						if (num2 - 385157575 != 0)
						{
							num2 = 1284262796 + num2;
							_4E2E44B7.Dispose();
						}
					}
				}
				break;
			}
			goto IL_0025;
			IL_0025:
			num2 = 1530871351 % num2;
			MethodBase methodBase12 = _37690AA7(num3);
			num2 += 811077156;
			methodBase2 = methodBase12;
			num2 -= 458256979;
			goto IL_004d;
		}
	}

	private void _2C0F1316()
	{
		uint num = 1056338068u;
		_582960B3 _582960B5 = default(_582960B3);
		while (true)
		{
			_1AF96773 obj = _40B8698E;
			num = 1162759010 + num;
			_582960B3 obj2 = obj._170D7B68();
			num %= 2000636667;
			_582960B3 _582960B4 = obj2;
			num = 1436240905u >> (int)num;
			if (1329020090 >= num)
			{
				_1AF96773 obj3 = _40B8698E;
				num -= 896089734;
				_582960B5 = obj3._170D7B68();
				num = 2114661190 % num;
				if (1424456772 - num == 0)
				{
					continue;
				}
			}
			while (true)
			{
				byte num2 = _381D5F4F._0F9F2D0A();
				uint num3 = num - 2114661189;
				num <<= 20;
				uint num4 = num2 & num3;
				int num5 = (int)num ^ -1268776960;
				num <<= 0;
				bool flag = num4 > (uint)num5;
				num = 0x490278EB & num;
				if (num == 1130254674)
				{
					return;
				}
				while (true)
				{
					num = 0x3AA914AD ^ num;
					_582960B3 _7B73381D = _582960B5;
					num = 0x5B9D3E12 ^ num;
					TypeCode typeCode = _7B624F6F(_7B73381D, _582960B4);
					if (num == 1768304160)
					{
						continue;
					}
					while (true)
					{
						num /= 1399593394;
						int num6 = (int)typeCode - (int)(num ^ 8);
						num >>= 6;
						switch (num6)
						{
						default:
							num += 0;
							goto case 1;
						case 0:
							num |= 0x7C064F3F;
							if (num <= 754538006)
							{
								break;
							}
							goto IL_0142;
						case 2:
						{
							num = 2108234761 * num;
							_1AF96773 obj4 = _40B8698E;
							_582960B3 _14995F = _582960B5;
							num = 1300384628 * num;
							num %= 462367327;
							num <<= 10;
							_582960B3 _5FD = _66FF619D._207E1A7C(_14995F, _582960B4, flag);
							num &= 0x6E32B0F;
							obj4._20DB4AD4(_5FD);
							return;
						}
						case 4:
							goto end_IL_00e2;
						case 5:
							goto end_IL_00b9;
						case 1:
						case 3:
							num = (uint)(728255661 << (int)num);
							if (251877165 % num != 0)
							{
								throw new InvalidOperationException();
							}
							break;
						}
						goto end_IL_0070;
						IL_0142:
						_1AF96773 obj5 = _40B8698E;
						_582960B3 _385A1A7D = _582960B5;
						num &= 0x317A1873;
						num = 0x1BDA3704 | num;
						_582960B3 _5FD2 = _50424ADC._409A0EE0(_385A1A7D, _582960B4, flag);
						num -= 1698844221;
						obj5._20DB4AD4(_5FD2);
						if (1351688615 <= num)
						{
							return;
						}
						continue;
						end_IL_00e2:
						break;
					}
					num *= 388374155;
					if (num <= 1955074528)
					{
						_1AF96773 obj6 = _40B8698E;
						_582960B3 _49947B = _582960B5;
						num = 1154833971u >> (int)num;
						obj6._20DB4AD4(_5A103814._4C4356D8(_49947B, _582960B4, flag));
						return;
					}
					continue;
					end_IL_00b9:
					break;
				}
				if ((0x11735DDF ^ num) != 0)
				{
					num = 1793994676 - num;
					_1AF96773 obj7 = _40B8698E;
					_582960B3 _13A829F = _582960B5;
					num = (uint)(910099750 << (int)num);
					num = 1636395121 - num;
					obj7._20DB4AD4(_77315431._038D42A0(_13A829F, _582960B4, flag));
					if (num >= 274691771)
					{
						break;
					}
					return;
				}
				continue;
				end_IL_0070:
				break;
			}
		}
	}

	private MethodBase _37690AA7(int _7F5B64AB)
	{
		uint num = 194078268u;
		Dictionary<int, object> dictionary2 = default(Dictionary<int, object>);
		if (num != 2008884215)
		{
			Dictionary<int, object> dictionary = _000A3090;
			num ^= 0x53F54A9;
			dictionary2 = dictionary;
		}
		num -= 1631091740;
		bool lockTaken = (byte)(num ^ 0xAD75B679u) != 0;
		MethodBase result = default(MethodBase);
		try
		{
			if (num >= 980515835)
			{
				while (true)
				{
					IL_0042:
					Dictionary<int, object> obj = dictionary2;
					num = 0x28E71889 | num;
					num &= 0x8786B38;
					Monitor.Enter(obj, ref lockTaken);
					num = 19880986 + num;
					if (num > 1659635211)
					{
						continue;
					}
					while (true)
					{
						Dictionary<int, object> dictionary3 = _000A3090;
						num += 1407089253;
						if (dictionary3.TryGetValue(_7F5B64AB, out var value) && num * 1201552093 != 0)
						{
							MethodBase obj2 = (MethodBase)value;
							num /= 204957140;
							result = obj2;
							break;
						}
						if (num > 598221498)
						{
							MethodBase methodBase = _16B6617B.ResolveMethod(_7F5B64AB);
							num |= 0x5B727E80;
							if (num / 754913385 == 0)
							{
								continue;
							}
							Dictionary<int, object> dictionary4 = _000A3090;
							num &= 0x28BC139D;
							num &= 0x5FB8680A;
							dictionary4.Add(_7F5B64AB, methodBase);
							if ((0xCFC1C4E ^ num) == 0)
							{
								break;
							}
							num = 1301902607 / num;
							result = methodBase;
							if (num * 837822356 != 0)
							{
								break;
							}
						}
						goto IL_0042;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				bool num2 = lockTaken;
				num = 702308901u;
				if (num2)
				{
					num %= 2129146488;
					if (num + 851462153 == 0)
					{
						continue;
					}
					goto IL_0153;
				}
				goto IL_0163;
				IL_0153:
				Monitor.Exit(dictionary2);
				num ^= 0;
				goto IL_0163;
				IL_0163:
				if (num < 1324241734)
				{
					break;
				}
				goto IL_0153;
			}
		}
		num = 570764942u;
		return result;
	}

	private void _2AF82BD4()
	{
		while (true)
		{
			uint num = 788410102u;
			_1AF96773 obj = _40B8698E;
			num &= 0x6FDB3393;
			_582960B3 _582960B4 = obj._170D7B68();
			num += 1868911723;
			TypeCode num2 = _582960B4._09A801C9();
			num -= 1813390797;
			TypeCode typeCode = num2;
			num = 232880227 * num;
			while (true)
			{
				num ^= 0x19C333BC;
				int num3 = (int)num ^ -1761880539;
				num <<= 24;
				TypeCode num4 = typeCode - num3;
				num = 2041213196 - num;
				switch (num4)
				{
				default:
					if (1512834413 == num)
					{
						continue;
					}
					num ^= 0;
					goto case TypeCode.Object;
				case TypeCode.Empty:
				{
					num -= 585699938;
					if (127226406 == num)
					{
						continue;
					}
					_1AF96773 obj4 = _40B8698E;
					num = 0x2D9B42D0 ^ num;
					obj4._20DB4AD4(_50424ADC._5F615EA2(_582960B4));
					if (925633812 != num)
					{
						return;
					}
					break;
				}
				case TypeCode.DBNull:
				{
					_1AF96773 obj3 = _40B8698E;
					num /= 1561746032;
					_582960B3 _5FD2 = _66FF619D._22134A0D(_582960B4);
					num |= 0x4DD01888;
					obj3._20DB4AD4(_5FD2);
					if ((0x1741162A ^ num) != 0)
					{
						return;
					}
					break;
				}
				case TypeCode.Char:
				{
					num = 0x4DAE7AEB & num;
					_1AF96773 obj2 = _40B8698E;
					num *= 1878069215;
					_582960B3 _5FD = _5A103814._695126C8(_582960B4);
					num >>= 12;
					obj2._20DB4AD4(_5FD);
					return;
				}
				case TypeCode.SByte:
					num = 1546613202 % num;
					num ^= 0x3D2974BE;
					_40B8698E._20DB4AD4(_77315431._5ECB5C23(_582960B4));
					if (932118828 * num != 0)
					{
						return;
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					num = 1475422591 + num;
					throw new InvalidOperationException();
				}
				break;
			}
		}
	}

	private void _34042A95()
	{
		Type type = _4B341A98(_381D5F4F._435152A1());
		_1AF96773 obj = _40B8698E;
		uint num = 1648719167u;
		_1AF96773 obj2 = _40B8698E;
		num *= 832334402;
		_582960B3 obj3 = obj2._170D7B68();
		num ^= 0x29D415FB;
		object _52BC02CD = obj3._7BBC17CC(type, (byte)(num + 1341372988) != 0);
		num = 0x1423734F | num;
		num *= 2128358542;
		_582960B3 _5FD = _318778F9(_52BC02CD, type);
		num &= 0x37AD6BCC;
		obj._20DB4AD4(_5FD);
	}

	private void _4B320761()
	{
		uint num = 1805850902u;
		num &= 0x6DBA4F30;
		_582960B3 _582960B4 = _40B8698E._170D7B68();
		if (num >= 1453928270)
		{
			do
			{
				num %= 1553355957;
				_1AF96773 obj = _40B8698E;
				num <<= 4;
				num += 1570532465;
				Type _37AC2BCF = _582960B4._71C820E4();
				num /= 1911949768;
				obj._20DB4AD4(_318778F9(_582960B4, _37AC2BCF));
			}
			while ((num ^ 0x4B535DE3) == 0);
		}
	}

	private bool _37F07959(object _71FE17AD, Type _6D584921)
	{
		uint num = 1686057332u;
		if ((num & 0x205037BA) != 0)
		{
			Type type2;
			while (true)
			{
				num = 1975476655 / num;
				if (_71FE17AD == null)
				{
					num = 651503552 - num;
					return (byte)(num ^ 0x26D527BE) != 0;
				}
				if ((num & 0x108F5D36) == 0)
				{
					num <<= 7;
					Type type = _71FE17AD.GetType();
					num &= 0x650E703C;
					type2 = type;
					num *= 496323880;
					if (num >> 10 == 0)
					{
						break;
					}
				}
			}
			num = 412551058 - num;
			bool num2 = type2 == _6D584921;
			num = 1879594310 % num;
			if (!num2)
			{
				num = 1916422982u >> (int)num;
				num += 124585575;
				num += 43411529;
				if (!_6D584921.IsAssignableFrom(type2))
				{
					return (byte)(num ^ 0xA036EB1) != 0;
				}
				num += 61392973;
			}
		}
		return (byte)(num - 229390077) != 0;
	}

	private void _748B5AA0()
	{
		uint num;
		do
		{
			num = 1258375268u;
			_1AF96773 obj = _40B8698E;
			num |= 0x50A362EC;
			num %= 1264478197;
			_582960B3 _5FD = _40B8698E._69E05F5E()._5C7710FF();
			num <<= 30;
			obj._20DB4AD4(_5FD);
		}
		while ((num ^ 0x493830CF) == 0);
	}

	private void _1F923095()
	{
		uint num = 134618407u;
		while (true)
		{
			_582960B3 _582960B4 = _40B8698E._170D7B68();
			if (num > 383274150)
			{
				continue;
			}
			while (true)
			{
				num |= 0x2E23248;
				TypeCode num2 = _582960B4._09A801C9();
				num = 889857503u >> (int)num;
				TypeCode typeCode = num2;
				num |= 0x7BD31328;
				int num3 = (int)num + -2077457203;
				num *= 2032026347;
				if (typeCode != (TypeCode)num3)
				{
					num = 1350438381 * num;
					if (typeCode == (TypeCode)(num - 1533070969))
					{
						num -= 1391926851;
						_1AF96773 obj = _40B8698E;
						num *= 706304993;
						obj._20DB4AD4(_66FF619D._2F9725E9(_582960B4));
						if ((num ^ 0x274D04A4) == 0)
						{
							break;
						}
						return;
					}
				}
				else
				{
					num /= 1758345668;
					if (num <= 1456872040)
					{
						num >>= 31;
						_1AF96773 obj2 = _40B8698E;
						num = (uint)(1801354863 << (int)num);
						obj2._20DB4AD4(_50424ADC._58E83D0A(_582960B4));
						if (16331593 % num == 0)
						{
							break;
						}
						return;
					}
				}
				if (num - 1217406688 != 0)
				{
					throw new InvalidOperationException();
				}
			}
		}
	}

	private void _4DB576CF()
	{
		uint num = 615001849u;
		_582960B3 _582960B4 = default(_582960B3);
		Array array = default(Array);
		if (2001304171 >= num)
		{
			num = 1202407365 - num;
			_582960B4 = _40B8698E._170D7B68();
			object obj = _40B8698E._170D7B68()._0936516D();
			num /= 1204552615;
			array = obj as Array;
		}
		Array array2 = array;
		num = (uint)(1397062607 << (int)num);
		if (array2 == null)
		{
			num |= 0x557D6F61;
			if (723025384 * num == 0)
			{
				return;
			}
		}
		else if (num + 1671855512 != 0)
		{
			num |= 0x6FB06D37;
			_1AF96773 obj2 = _40B8698E;
			Array _1F = array;
			int _0E1A074A = _582960B4._6AAF062D();
			num ^= 0x59822179;
			obj2._20DB4AD4(new _581261AF(_1F, _0E1A074A));
			return;
		}
		throw new ArgumentException();
	}

	private string _67444B0A(int _4C98362A)
	{
		Dictionary<int, object> dictionary = _000A3090;
		uint num = 221281121u;
		Dictionary<int, object> obj = dictionary;
		num ^= 0x2FA53D88;
		bool lockTaken = (byte)(num ^ 0x229546E9) != 0;
		string result;
		try
		{
			if (num <= 1640587966)
			{
				goto IL_002c;
			}
			goto IL_0034;
			IL_002c:
			Monitor.Enter(obj, ref lockTaken);
			goto IL_0034;
			IL_0034:
			Dictionary<int, object> dictionary2 = _000A3090;
			num = 2136827482 * num;
			num |= 0x7D5C06F1;
			if (dictionary2.TryGetValue(_4C98362A, out var value))
			{
				num = 1657039979 / num;
				goto IL_0064;
			}
			num = (uint)(267221677 << (int)num);
			string text = _16B6617B.ResolveString(_4C98362A);
			Dictionary<int, object> dictionary3 = _000A3090;
			num ^= 0x46E65937;
			num >>= 23;
			dictionary3.Add(_4C98362A, text);
			if (2013936157 * num == 0)
			{
				goto IL_002c;
			}
			result = text;
			if (num == 1248929153)
			{
				goto IL_0064;
			}
			goto end_IL_0020;
			IL_0064:
			object obj2 = value;
			num = 670630598 - num;
			string obj3 = (string)obj2;
			num /= 597038733;
			result = obj3;
			if (num == 1592027939)
			{
				goto IL_002c;
			}
			end_IL_0020:;
		}
		finally
		{
			if (lockTaken)
			{
				num = 801991531u;
				Monitor.Exit(obj);
			}
		}
		return result;
	}

	private void _56F74966()
	{
		uint num = 2017990999u;
		Type type = default(Type);
		if (325530539 <= num)
		{
			type = _4B341A98(_381D5F4F._435152A1());
			num ^= 0x34A778D;
		}
		num = (uint)(1907784629 << (int)num);
		_1AF96773 obj = _40B8698E;
		num += 98066989;
		_582960B3 _582960B4 = obj._170D7B68();
		num = 861420260u >> (int)num;
		while (true)
		{
			num = 355141253 * num;
			object _71FE17AD = _582960B4._0936516D();
			num = 206793324u >> (int)num;
			Type _6D726748 = type;
			num *= 205072020;
			bool num2 = _37F07959(_71FE17AD, _6D726748);
			num ^= 0x5DE93D32;
			if (num2)
			{
				break;
			}
			if (num < 628429608)
			{
				throw new InvalidCastException();
			}
		}
		num += 1517375129;
		_1AF96773 obj2 = _40B8698E;
		num ^= 0x6B946682;
		obj2._20DB4AD4(_582960B4);
	}

	private FieldInfo _3BA823A3(int _3443057C)
	{
		uint num = 2016620944u;
		Dictionary<int, object> dictionary = default(Dictionary<int, object>);
		if (num > 1668496798)
		{
			dictionary = _000A3090;
		}
		bool lockTaken = (byte)(num + 2278346352u) != 0;
		FieldInfo result = default(FieldInfo);
		try
		{
			while (true)
			{
				Dictionary<int, object> obj = dictionary;
				num *= 1780486145;
				Monitor.Enter(obj, ref lockTaken);
				num ^= 0x2CDE138B;
				if (num == 1903645494)
				{
					break;
				}
				while (true)
				{
					Dictionary<int, object> dictionary2 = _000A3090;
					num = 1943880414u >> (int)num;
					num = 919156951 * num;
					object value;
					bool num2 = dictionary2.TryGetValue(_3443057C, out value);
					num += 1473467291;
					if (num2)
					{
						num = 97976597u >> (int)num;
						if ((num & 0x293612A3) != 0)
						{
							break;
						}
						result = (FieldInfo)value;
						goto end_IL_0022;
					}
					num &= 0x1A780126;
					FieldInfo fieldInfo = _16B6617B.ResolveField(_3443057C);
					Dictionary<int, object> dictionary3 = _000A3090;
					num = 953957012 * num;
					num &= 0x7A275194;
					dictionary3.Add(_3443057C, fieldInfo);
					result = fieldInfo;
					if ((0x6DB1751A & num) != 0)
					{
						goto end_IL_0022;
					}
				}
				continue;
				end_IL_0022:
				break;
			}
		}
		finally
		{
			bool num3 = lockTaken;
			num = 564101001u;
			if (num3)
			{
				Monitor.Exit(dictionary);
				num += 0;
			}
		}
		return result;
	}

	private void _1D221342()
	{
		uint num = 856576497u;
		_582960B3 _582960B5 = default(_582960B3);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			num = 0x645E2D73 ^ num;
			_582960B3 _582960B4 = _40B8698E._170D7B68();
			num &= 0x6DE7134;
			if ((num & 0x155B08EE) != 0)
			{
				goto IL_002e;
			}
			goto IL_00cf;
			IL_00cf:
			num = 0x729B1A71 | num;
			_582960B3 _7B73381D = _582960B5;
			num |= 0x17A94495;
			num = 1202667690 / num;
			TypeCode num2 = _7B624F6F(_7B73381D, _582960B4);
			num = 0x6A0F5102 | num;
			TypeCode typeCode = num2;
			num %= 1608653526;
			int num3 = (int)num + -170735139;
			num = (uint)(1575617879 << (int)num);
			switch (typeCode - num3)
			{
			default:
				num ^= 0;
				goto case TypeCode.Object;
			case TypeCode.Empty:
			{
				num >>= 29;
				num -= 981009198;
				_1AF96773 obj4 = _40B8698E;
				_582960B3 _412D6EEB = _582960B5;
				num = 226503969 - num;
				bool _66110BC = flag;
				num = 0x27C529CC & num;
				bool _26D = flag2;
				num ^= 0x64A95BFB;
				obj4._20DB4AD4(_50424ADC._159F3DF0(_412D6EEB, _582960B4, _66110BC, _26D));
				if (753010531 < num)
				{
					return;
				}
				break;
			}
			case TypeCode.DBNull:
				if (num > 2102804145)
				{
					_1AF96773 obj3 = _40B8698E;
					_582960B3 _1E = _582960B5;
					num = 419703351 + num;
					bool _7DBA79E = flag;
					bool _27A = flag2;
					num |= 0x2CB5360C;
					obj3._20DB4AD4(_66FF619D._2E690D97(_1E, _582960B4, _7DBA79E, _27A));
					if ((0x4C41776B & num) != 0)
					{
						return;
					}
					break;
				}
				goto case TypeCode.Empty;
			case TypeCode.Char:
			{
				_1AF96773 obj2 = _40B8698E;
				num <<= 13;
				_582960B3 _212F77BD = _582960B5;
				num >>= 24;
				_582960B3 _5FD = _5A103814._0B5F41B5(_212F77BD, _582960B4, flag, flag2);
				num %= 1947104775;
				obj2._20DB4AD4(_5FD);
				return;
			}
			case TypeCode.SByte:
			{
				num |= 0x329D79DD;
				_1AF96773 obj = _40B8698E;
				num = 0x4E637BE0 & num;
				_582960B3 _3B = _582960B5;
				num = 2141659926u >> (int)num;
				bool _0E955B4F = flag;
				num -= 913717292;
				obj._20DB4AD4(_77315431._706B32E9(_3B, _582960B4, _0E955B4F, flag2));
				return;
			}
			case TypeCode.Object:
			case TypeCode.Boolean:
				if (num * 1001204594 != 0)
				{
					throw new InvalidOperationException();
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			while (true)
			{
				num ^= 0x595E44AB;
				_1AF96773 obj5 = _40B8698E;
				num <<= 27;
				_582960B3 obj6 = obj5._170D7B68();
				num ^= 0x2F756AAD;
				_582960B5 = obj6;
				num <<= 27;
				if (num == 162817414)
				{
					break;
				}
				_6D2115ED obj7 = _381D5F4F;
				num = (uint)(735123732 << (int)num);
				byte num4 = obj7._0F9F2D0A();
				num >>= 7;
				flag2 = (num4 & (num - 5743153)) > (num ^ 0x57A232);
				int num5 = (int)num + -5743122;
				num <<= 27;
				int num6 = num4 & num5;
				uint num7 = num + 1879048192;
				num = 0x42654116 | num;
				bool num8 = (uint)num6 > num7;
				num = 982857145 / num;
				flag = num8;
				if (2136435067 == num)
				{
					continue;
				}
				goto IL_00cf;
			}
		}
	}

	private void _643B05B5()
	{
		while (true)
		{
			uint num = 951276575u;
			_40B8698E._3AD67507();
			num = 0x407D3473 & num;
			while (true)
			{
				IL_0019:
				num += 1263869950;
				_6D2115ED obj = _381D5F4F;
				num &= 0x7C32611C;
				obj._13A86F25();
				if (1231248895 < num)
				{
					break;
				}
				while (true)
				{
					IL_054b:
					if (_2D282653._346D2CCE() != 0)
					{
						while (true)
						{
							IL_0044:
							num = 977559358u;
							_38797DE2 obj2 = _2D282653;
							num = 1429950888u >> (int)num;
							_58BB531E obj3 = obj2._5090100A();
							num |= 0x7BBB4AD6;
							List<_5C0E71F4> list = obj3._38207DE6();
							if (num < 1284666035)
							{
								break;
							}
							while (true)
							{
								IL_007d:
								num = 1144212571u >> (int)num;
								_5C0E71F4 obj4 = _06733F26;
								num = 0x4AFC4750 & num;
								int num4;
								if (obj4 != null)
								{
									num = 1096501640 * num;
									if (num * 566757915 != 0)
									{
										break;
									}
									num = (uint)(1475881571 << (int)num);
									_5C0E71F4 item = _06733F26;
									num = 845118092 - num;
									int num2 = list.IndexOf(item);
									num = 828734667 + num;
									uint num3 = num ^ 0xBCCCCF5;
									num = 0x3E744164 | num;
									num4 = num2 + (int)num3;
								}
								else
								{
									num >>= 23;
									num4 = (int)(num + 0);
									num ^= 0x3FFCCDF4;
								}
								num *= 1476352718;
								num -= 2083607583;
								_06733F26 = null;
								int num5 = num4;
								if (num << 25 != 0)
								{
									while (num - 1626803564 != 0)
									{
										int num6 = num5;
										num = 700795780 * num;
										int count = list.Count;
										num |= 0x45DB0A43;
										if (num6 < count)
										{
											int index = num5;
											num = 1192441991u;
											_5C0E71F4 _5C0E71F5 = list[index];
											num = 0x32B66BAF | num;
											num >>= 9;
											byte num7 = _5C0E71F5._50C7492B();
											num |= 0x788969D4;
											byte b = num7;
											num = 124810931 - num;
											num |= 0x28FF3020;
											if (b != 0)
											{
												num %= 2135975497;
												num = 0x746421AE & num;
												if (b != num - 606339115)
												{
													goto IL_0348;
												}
												num = 0x60814A8D | num;
												_06733F26 = _5C0E71F5;
												_1AF96773 obj5 = _40B8698E;
												_2CEE4B34 _5FD = new _2CEE4B34(_459D7272);
												num = 1368597367 / num;
												obj5._20DB4AD4(_5FD);
												num >>= 7;
												if (2073902064 + num == 0)
												{
													goto end_IL_007d;
												}
												_6D2115ED obj6 = _381D5F4F;
												num ^= 0xE1A0097;
												obj6._0C3C7D51(_5C0E71F5._34C01896());
												if (1065826270 * num == 0)
												{
													goto end_IL_007d;
												}
												return;
											}
											num -= 303981680;
											if (284703440 >= num)
											{
												goto end_IL_007d;
											}
											num = 1608524646 / num;
											Type type = _459D7272.GetType();
											num |= 0x58CE5124;
											if (2109751618u >> (int)num != 0)
											{
												num %= 722617423;
												int _52213A = _5C0E71F5._34C01896();
												num <<= 3;
												Type type2 = _4B341A98(_52213A);
												num |= 0x4B6869BF;
												Type type3 = type2;
												num &= 0x70D8323F;
												num = 0x7A44591F ^ num;
												if (!(type == type3))
												{
													if (539429459 >>> (int)num == 0)
													{
														break;
													}
													num = 2126205117 % num;
													bool num8 = type.IsSubclassOf(type3);
													num += 596515535;
													if (!num8)
													{
														goto IL_0348;
													}
													num += 99121396;
												}
												num *= 574520993;
												if (111416954 << (int)num == 0)
												{
													break;
												}
												_2D282653._1D0C709F();
												num = 0x13213CF6 ^ num;
												num = 0x61FE7CE5 & num;
												_1AF96773 obj7 = _40B8698E;
												num = 302253936 % num;
												num = 0x5E0655E8 | num;
												_2CEE4B34 _5FD2 = new _2CEE4B34(_459D7272);
												num = 936447100 - num;
												obj7._20DB4AD4(_5FD2);
												num = 1370126604 - num;
												_6D2115ED obj8 = _381D5F4F;
												num = 1101351810 % num;
												obj8._0C3C7D51(_5C0E71F5._12B955CD());
												return;
											}
											goto IL_007d;
										}
										num *= 161157014;
										num |= 0x26E73659;
										_38797DE2 obj9 = _2D282653;
										num >>= 7;
										obj9._1D0C709F();
										num = 0x2717D44 & num;
										int count2 = list.Count;
										num = 0x4C0518BB & num;
										int num9 = count2;
										while (true)
										{
											num = 0x23591C27 | num;
											if (num << 25 == 0)
											{
												break;
											}
											int num10 = num9;
											num /= 1620270192;
											uint num11 = num ^ 0;
											num /= 185417244;
											if (num10 > (int)num11)
											{
												num = 1513707942u;
												int num12 = num9;
												num |= 0x74706CC5;
												_5C0E71F4 obj10 = list[num12 - (int)(num ^ 0x7E797DE6)];
												num >>= 21;
												_5C0E71F4 _5C0E71F6 = obj10;
												if (1467105991 < num)
												{
													goto IL_054b;
												}
												if (_5C0E71F6._50C7492B() != num - 1009)
												{
													num = 0x789D5F45 & num;
													num /= 1720585774;
													if (_5C0E71F6._50C7492B() != (num ^ 4))
													{
														goto IL_047e;
													}
													num += 1011;
												}
												_6D2115ED obj11 = _381D5F4F;
												num = 635639947 * num;
												int _4F437089 = _5C0E71F6._12B955CD();
												num = 0xC021863 | num;
												obj11._771E25CB(_4F437089);
												num ^= 0x9FDBFCF3u;
												goto IL_047e;
											}
											goto IL_04dc;
											IL_047e:
											if (num == 2124902316)
											{
												goto IL_0378;
											}
											int num13 = num9;
											num = 1381316945 - num;
											int num14 = (int)num + -1381316944;
											num %= 1597710991;
											num9 = num13 - num14;
											num ^= 0x52543151;
										}
										goto IL_007d;
										IL_0348:
										if (1922852070 + num == 0)
										{
											break;
										}
										int num15 = num5;
										num %= 79918664;
										int num16 = num15 + (int)(num - 46908467);
										num = 448281146 + num;
										num5 = num16;
										num += 3593220043u;
										continue;
										IL_04dc:
										if (num > 577389621)
										{
											goto end_IL_007d;
										}
										num = 1103697741u >> (int)num;
										_6D2115ED obj12 = _381D5F4F;
										num |= 0x27384FF8;
										int num17 = obj12._118322DE();
										num = 1231686819 + num;
										num += 2526983024u;
										if (num17 != 0)
										{
											num = 0x3317430B | num;
											if (305417824 >>> (int)num == 0)
											{
												goto end_IL_007d;
											}
											_6D2115ED obj13 = _381D5F4F;
											num <<= 23;
											obj13._55863A4A();
											return;
										}
										goto IL_054b;
										IL_0378:;
									}
									goto end_IL_0044;
								}
								goto IL_0044;
								continue;
								end_IL_007d:
								break;
							}
							goto end_IL_054b;
							continue;
							end_IL_0044:
							break;
						}
						goto IL_0019;
					}
					num &= 0x4D2B286C;
					if (num < 527827621)
					{
						break;
					}
					throw _459D7272;
					continue;
					end_IL_054b:
					break;
				}
				break;
			}
		}
	}

	static _78492021()
	{
		uint num = 1888551264u;
		Type? typeFromHandle = typeof(_78492021);
		num |= 0x51C75354;
		_16B6617B = typeFromHandle.Module;
		num = 2139647288u >> (int)num;
		do
		{
			_000A3090 = new Dictionary<int, object>();
			num = 1275531229 + num;
		}
		while (num > 1826899658);
		_11FE66F3 = new Dictionary<object, DynamicMethod>();
	}

	private void _18C71B02()
	{
		while (true)
		{
			_1AF96773 obj = _40B8698E;
			uint num = 765141209u;
			_582960B3 obj2 = obj._170D7B68();
			num = 1864048248 + num;
			_582960B3 _582960B4 = obj2;
			while (true)
			{
				_582960B3 obj3 = _582960B4;
				num *= 1656375296;
				object obj4 = obj3._0936516D();
				num /= 734810323;
				IConvertible obj5 = obj4 as IConvertible;
				num = 1162020425 - num;
				if (obj5 != null)
				{
					if ((0x186A2B87 ^ num) != 0)
					{
						_582960B3 obj6 = _582960B4;
						num &= 0x57139CA;
						double num2 = obj6._40F966AC();
						num <<= 9;
						double d = num2;
						num = 0x74E914F1 & num;
						if (num >= 728304489)
						{
							continue;
						}
						bool num3 = double.IsNaN(d);
						num = 2084977778 - num;
						if (!num3)
						{
							num /= 1229397017;
							if (num > 4485043)
							{
								break;
							}
							num = 1570242872u >> (int)num;
							if (!double.IsInfinity(d))
							{
								goto IL_0100;
							}
							num += 1299852246;
						}
					}
					num ^= 0x1E2472E8;
					if (608895115 + num == 0)
					{
						break;
					}
					throw new OverflowException();
				}
				num += 709500420;
				_77315431 obj7 = new _77315431(double.NaN);
				num = 0x67AB7C70 & num;
				_582960B4 = obj7;
				num += 3343047772u;
				goto IL_0100;
				IL_0100:
				num >>= 21;
				_1AF96773 obj8 = _40B8698E;
				num = 399720062 / num;
				_582960B3 _5FD = _582960B4;
				num &= 0x34497161;
				obj8._20DB4AD4(_5FD);
				if (645281595 % num == 0)
				{
					break;
				}
				return;
			}
		}
	}

	private void _3C2D1285()
	{
		uint num = 1842771074u;
		_582960B3 _582960B5 = default(_582960B3);
		while (true)
		{
			_582960B3 _582960B4 = _40B8698E._170D7B68();
			num = (uint)(200684180 << (int)num);
			if (num <= 1076436304)
			{
				goto IL_002f;
			}
			goto IL_004f;
			IL_004f:
			_6D2115ED obj = _381D5F4F;
			num = 404642887 * num;
			byte num2 = obj._0F9F2D0A();
			num = 1655985864 * num;
			uint num3 = num - 48929983;
			num *= 307918778;
			uint num4 = num2 & num3;
			int num5 = (int)num ^ -925686912;
			num |= 0x284603A1;
			bool flag = num4 > (uint)num5;
			if (num < 1172715694)
			{
				continue;
			}
			while (true)
			{
				_582960B3 _7B73381D = _582960B5;
				num = 468480314 + num;
				TypeCode num6 = _7B624F6F(_7B73381D, _582960B4);
				num = 1773300629 - num;
				TypeCode typeCode = num6;
				if (770909224 == num)
				{
					break;
				}
				uint num7 = num ^ 0x64EED6BB;
				num = 0x386C3680 | num;
				if (typeCode != (TypeCode)num7)
				{
					num ^= 0x2EA020E7;
					num = 1570129180 / num;
					int num8 = (int)num - -8;
					num = 0x389449CC | num;
					TypeCode num9 = typeCode - num8;
					num /= 1809152714;
					switch (num9)
					{
					case TypeCode.Empty:
						break;
					case TypeCode.DBNull:
					{
						_1AF96773 obj2 = _40B8698E;
						num = 0x40A04418 ^ num;
						_582960B3 _5FD = _66FF619D._6CCC34C2(_582960B5, _582960B4, flag);
						num = 1386052867 / num;
						obj2._20DB4AD4(_5FD);
						return;
					}
					case TypeCode.Char:
						goto IL_01fc;
					case TypeCode.SByte:
						goto IL_0255;
					case TypeCode.Object:
					case TypeCode.Boolean:
						goto IL_02ae;
					default:
						num = (uint)(2102466063 << (int)num);
						throw new InvalidOperationException();
					}
					num /= 1678800259;
					num <<= 6;
					_1AF96773 obj3 = _40B8698E;
					num = 360580490 * num;
					_582960B3 _5FD2 = _50424ADC._3CB9335A(_582960B5, _582960B4, flag);
					num = 2065392640u >> (int)num;
					obj3._20DB4AD4(_5FD2);
					if (1575617194 - num == 0)
					{
						break;
					}
				}
				else
				{
					num &= 0x19D26AA7;
					if (147070065 >>> (int)num == 0)
					{
						break;
					}
					_1AF96773 obj4 = _40B8698E;
					num ^= 0x39107A04;
					_582960B3 _29717F = _582960B5;
					num = 2113034055 / num;
					_582960B3 _5FD3 = _2CEE4B34._04A142D0(_29717F, _582960B4);
					num ^= 0x1331BF7;
					obj4._20DB4AD4(_5FD3);
				}
				return;
				IL_0255:
				num = (uint)(1361146943 << (int)num);
				if (num - 480775776 != 0)
				{
					num ^= 0x9343ED1;
					_1AF96773 obj5 = _40B8698E;
					num = 0x123A55AF | num;
					_582960B3 _43484A0B = _582960B5;
					num = 261240409 % num;
					num ^= 0x2C7B5F1C;
					obj5._20DB4AD4(_77315431._483F64ED(_43484A0B, _582960B4, flag));
					return;
				}
				continue;
				IL_01fc:
				num <<= 29;
				num /= 338168807;
				_1AF96773 obj6 = _40B8698E;
				_582960B3 _03130F = _582960B5;
				num = 0x52F03AF0 & num;
				num ^= 0x67C114E3;
				num = (uint)(905263406 << (int)num);
				obj6._20DB4AD4(_5A103814._7F0F7C23(_03130F, _582960B4, flag));
				if ((num ^ 0x7F0F2AA0) == 0)
				{
					break;
				}
				return;
			}
			continue;
			IL_002f:
			num &= 0x633908FB;
			_1AF96773 obj7 = _40B8698E;
			num = 58679352 - num;
			_582960B5 = obj7._170D7B68();
			goto IL_004f;
			IL_02ae:
			if (1355561499 >= num)
			{
				_1AF96773 obj8 = _40B8698E;
				_582960B3 _30BA = _582960B5;
				num = 0x13CE7F5F | num;
				_582960B3 _5FD4 = _18D4487E._3F20099B(_30BA, _582960B4, flag);
				num /= 1020004908;
				obj8._20DB4AD4(_5FD4);
				if (num <= 2032606911)
				{
					break;
				}
				continue;
			}
			goto IL_002f;
		}
	}

	private void _0DA75EB2()
	{
		uint num = 1144214812u;
		Type type;
		do
		{
			num = (uint)(1306359814 << (int)num);
			num *= 1976529883;
			type = _4B341A98(_381D5F4F._435152A1());
			num = 770263434u >> (int)num;
		}
		while (num == 589246074);
		_582960B3 obj = _40B8698E._170D7B68();
		num = 1663249911 % num;
		object _63C = null;
		num /= 864567569;
		bool isValueType = type.IsValueType;
		num += 1271413239;
		if (isValueType)
		{
			num = 391147298 / num;
			Type? underlyingType = Nullable.GetUnderlyingType(type);
			num = 222582071 + num;
			bool num2 = underlyingType == null;
			num += 1048831168;
			if (num2)
			{
				object uninitializedObject = FormatterServices.GetUninitializedObject(type);
				num = 368340939 / num;
				_63C = uninitializedObject;
				num += 1271413239;
			}
		}
		obj._727F3897(_63C);
	}

	private void _2D70200B()
	{
		uint num = 1213690349u;
		while (true)
		{
			num = 1094651564 - num;
			_1AF96773 obj = _40B8698E;
			num = 0x181A095E ^ num;
			_582960B3 obj2 = obj._170D7B68();
			num |= 0xA8E26E8;
			_582960B3 _582960B4 = obj2;
			num = 190519690 % num;
			if (2034720628 / num == 0)
			{
				continue;
			}
			while (true)
			{
				_582960B3 obj3 = _40B8698E._170D7B68();
				num = 2123762262u >> (int)num;
				_582960B3 _582960B5 = obj3;
				if (num == 242364971)
				{
					break;
				}
				num = 1276015165 * num;
				num ^= 0x34A30ADF;
				TypeCode typeCode = _7B624F6F(_582960B5, _582960B4);
				num /= 130370621;
				if (typeCode != (TypeCode)((int)num + -22))
				{
					num = 1091517786u >> (int)num;
					if (typeCode == (TypeCode)(num ^ 0xB))
					{
						num = 0x5CEE27F3 ^ num;
						if ((num & 0x78849BB) != 0)
						{
							_1AF96773 obj4 = _40B8698E;
							num >>= 5;
							num %= 33717672;
							num /= 638413708;
							obj4._20DB4AD4(_66FF619D._3D30647A(_582960B5, _582960B4));
							return;
						}
					}
					if (num - 1207174127 != 0)
					{
						throw new InvalidOperationException();
					}
					continue;
				}
				if (num % 1847731382 == 0)
				{
					break;
				}
				num -= 1217350094;
				_1AF96773 obj5 = _40B8698E;
				_582960B3 _5FD = _50424ADC._27EB338E(_582960B5, _582960B4);
				num = 1256416464 / num;
				obj5._20DB4AD4(_5FD);
				if (num >= 737963513)
				{
					break;
				}
				return;
			}
		}
	}

	private void _7E6B08A7()
	{
		uint num = 1052918902u;
		Type _6D726748 = _4B341A98(_381D5F4F._435152A1());
		if (1465655598 != num)
		{
			goto IL_0023;
		}
		goto IL_0099;
		IL_0023:
		_582960B3 _582960B4 = default(_582960B3);
		do
		{
			_582960B4 = _40B8698E._170D7B68();
			num = (uint)(1184399291 << (int)num);
		}
		while (1339300981 >= num);
		num = 0x2FD6104E ^ num;
		_582960B3 obj = _582960B4;
		num ^= 0x49BD3E12;
		bool num2 = _37F07959(obj._0936516D(), _6D726748);
		num /= 1585326583;
		if (!num2)
		{
			num = 0x6C5D0D47 & num;
			num = 0x6F140263 | num;
			_2CEE4B34 obj2 = new _2CEE4B34(null);
			num = 1497569770 - num;
			_582960B4 = obj2;
			num ^= 0xEA2F1786u;
		}
		goto IL_0099;
		IL_0099:
		num = 585196045u >> (int)num;
		num %= 1831738350;
		_1AF96773 obj3 = _40B8698E;
		num &= 0x1C1E20EB;
		obj3._20DB4AD4(_582960B4);
		if (num / 1802720342 == 0)
		{
			return;
		}
		goto IL_0023;
	}

	private void _620F74F5()
	{
		uint num = 850553276u;
		FieldInfo fieldInfo2 = default(FieldInfo);
		if ((0xD2E2107 & num) != 0)
		{
			do
			{
				num = 1707813932 + num;
				FieldInfo fieldInfo = _3BA823A3(_381D5F4F._435152A1());
				num = 1140332750 * num;
				fieldInfo2 = fieldInfo;
			}
			while (num == 1180780977);
		}
		do
		{
			num = 1536166017u >> (int)num;
			_1AF96773 obj = _40B8698E;
			num >>= 23;
			FieldInfo _1B0D1A = fieldInfo2;
			num = 1146754425 * num;
			obj._20DB4AD4(new _3C2B59A3(_1B0D1A, this));
		}
		while (1801466425 >>> (int)num == 0);
	}

	private void _08952BA9()
	{
		uint num = 1859002637u;
		_1AF96773 obj = _40B8698E;
		num = 533398894 * num;
		_5A103814 _5FD = new _5A103814(_381D5F4F._4FA84D15());
		num -= 1479804976;
		obj._20DB4AD4(_5FD);
	}

	private void _1FC105EF()
	{
		while (true)
		{
			uint num = 1287484993u;
			_1AF96773 obj = _40B8698E;
			num = 1364069065 % num;
			_582960B3 obj2 = obj._170D7B68();
			num -= 1100115519;
			_582960B3 _582960B4 = obj2;
			num = 1048002933 - num;
			if (666726315 > num)
			{
				continue;
			}
			while (true)
			{
				_582960B3 obj3 = _40B8698E._170D7B68();
				num /= 1516967243;
				_582960B3 _582960B5 = obj3;
				bool flag;
				bool flag2;
				while (true)
				{
					num = 761419422u >> (int)num;
					_6D2115ED obj4 = _381D5F4F;
					num |= 0xD3700C2;
					byte num2 = obj4._0F9F2D0A();
					num <<= 7;
					int num3 = num2 & ((int)num - -610932865);
					num = 0x63363B9 ^ num;
					int num4 = (int)num ^ -576289735;
					num *= 303839272;
					flag = (uint)num3 > (uint)num4;
					num >>= 14;
					int num5 = (int)num + -138388;
					num *= 1941261793;
					int num6 = num2 & num5;
					num = 1490059046 * num;
					flag2 = (uint)num6 > (uint)((int)num - -1766864968);
					while (true)
					{
						TypeCode num7 = _7B624F6F(_582960B5, _582960B4);
						num = 2138339711 % num;
						TypeCode typeCode = num7;
						if (218788982 >= num)
						{
							break;
						}
						uint num8 = num - 2138339702;
						num = 1112240402 - num;
						int num9 = (int)typeCode - (int)num8;
						num = (uint)(254102576 << (int)num);
						switch (num9)
						{
						case 0:
							break;
						case 2:
						{
							num >>= 23;
							num %= 731846667;
							_1AF96773 obj6 = _40B8698E;
							num /= 554642259;
							obj6._20DB4AD4(_66FF619D._0E4A18C3(_582960B5, _582960B4, flag2, flag));
							return;
						}
						case 4:
							goto IL_018f;
						case 5:
							goto IL_01f3;
						case 1:
						case 3:
						{
							num = 548879615 / num;
							_1AF96773 obj5 = _40B8698E;
							num >>= 26;
							num *= 3805448;
							obj5._20DB4AD4(_18D4487E._32DC6BCE(_582960B5, _582960B4, flag2, flag));
							return;
						}
						default:
							num >>= 23;
							throw new InvalidOperationException();
						}
						num ^= 0x688F23A4;
						if (num - 1493965832 == 0)
						{
							break;
						}
						_1AF96773 obj7 = _40B8698E;
						num /= 1185955020;
						num = 0x5BA000A9 | num;
						_582960B3 _5FD = _50424ADC._011B4C33(_582960B5, _582960B4, flag2, flag);
						num >>= 23;
						obj7._20DB4AD4(_5FD);
						return;
						IL_01f3:
						num = 995361186 - num;
						if (1889999720 >= num)
						{
							continue;
						}
						goto IL_0206;
					}
					break;
					IL_0206:
					num = 0x1A6948CE | num;
					_1AF96773 obj8 = _40B8698E;
					num *= 1245776472;
					num <<= 12;
					_582960B3 _5FD2 = _77315431._31E76A87(_582960B5, _582960B4, flag2, flag);
					num = 1553157564 * num;
					obj8._20DB4AD4(_5FD2);
					if (num / 2075883031 != 0)
					{
						return;
					}
				}
				break;
				IL_018f:
				num |= 0x565E43A3;
				if (2104385386 * num != 0)
				{
					num += 225513213;
					_1AF96773 obj9 = _40B8698E;
					num = 0x4271925 & num;
					num += 347080122;
					num = 194277679u >> (int)num;
					num &= 0x208E40D9;
					obj9._20DB4AD4(_5A103814._5F8B1692(_582960B5, _582960B4, flag2, flag));
					if ((num & 0x2B86153A) != 0)
					{
						break;
					}
					return;
				}
			}
		}
	}

	private void _3CB70A58()
	{
		IntPtr intPtr;
		uint num;
		do
		{
			_1AF96773 obj = _40B8698E;
			num = 1710446747u;
			_582960B3 obj2 = obj._170D7B68();
			num &= 0x5E8E3959;
			intPtr = Marshal.AllocHGlobal(obj2._47C01150());
			num = (uint)(1098403782 << (int)num);
		}
		while (num << 21 != 0);
		num = 86378721 * num;
		List<IntPtr> list = _0E4305CB;
		num = 0x5D5665BF | num;
		num |= 0x29CD32D8;
		list.Add(intPtr);
		num &= 0x33033E55;
		_1AF96773 obj3 = _40B8698E;
		num = (uint)(641617924 << (int)num);
		num /= 1508660927;
		obj3._20DB4AD4(new _515B561F(intPtr));
	}

	private unsafe void _01BE1822()
	{
		uint num = 627978162u;
		while (true)
		{
			_6D2115ED obj = _381D5F4F;
			num = 0x184E4ECB ^ num;
			int _52213A = obj._435152A1();
			num = 133131999u >> (int)num;
			Type type = _4B341A98(_52213A);
			num >>= 24;
			Type type2 = type;
			num -= 2086545742;
			_1AF96773 obj2 = _40B8698E;
			num = 268439618 + num;
			_582960B3 obj3 = obj2._170D7B68();
			num <<= 12;
			_582960B3 _582960B4 = obj3;
			num = (uint)(2021001936 << (int)num);
			if (71193710 >= num)
			{
				continue;
			}
			while (true)
			{
				IL_0073:
				num = 260792260u >> (int)num;
				_1AF96773 obj4 = _40B8698E;
				num ^= 0x334708;
				_582960B3 _582960B5 = obj4._170D7B68();
				if (1054359703 << (int)num == 0)
				{
					break;
				}
				num = 0x6FB65B61 ^ num;
				_582960B3 _52BC02CD = _582960B4;
				num = 313352414 / num;
				num |= 0x49631192;
				_582960B4 = _318778F9(_52BC02CD, type2);
				if (num == 1838498821)
				{
					continue;
				}
				while (true)
				{
					_582960B3 obj5 = _582960B5;
					num -= 476005484;
					if (obj5._11EF2F40())
					{
						if (num >> 3 == 0)
						{
							break;
						}
						num = 0x64E07DA9 | num;
						_582960B3 obj6 = _318778F9(_582960B4, _582960B5._71C820E4());
						num = 1245794039 - num;
						_582960B4 = obj6;
					}
					else
					{
						num >>= 12;
						if (num == 341078334)
						{
							goto IL_0073;
						}
						_582960B3 obj7 = _582960B5;
						num /= 2123182123;
						object obj8 = obj7._0936516D();
						num = 579828528 - num;
						Pointer obj9 = obj8 as Pointer;
						num = (uint)(2126736259 << (int)num);
						IntPtr _75062F;
						if (obj9 == null)
						{
							_75062F = _582960B5._47C01150();
						}
						else
						{
							_582960B3 obj10 = _582960B5;
							num = 0x4B687E6F | num;
							void* value = Pointer.Unbox(obj10._0936516D());
							num = 0x50AD42A1 | num;
							_75062F = new IntPtr(value);
							num ^= 0x106C7EEF;
						}
						num -= 645405385;
						_582960B5 = new _443828F0(_75062F, type2);
						num += 2538761233u;
					}
					num = 0x65B7009C ^ num;
					if (num != 694095310)
					{
						_582960B3 obj11 = _582960B5;
						_582960B3 obj12 = _582960B4;
						num %= 155472122;
						object _63C = obj12._0936516D();
						num = 0x386B06C9 & num;
						obj11._727F3897(_63C);
						if ((0x6BA7361F ^ num) == 0)
						{
							break;
						}
						return;
					}
				}
				break;
			}
		}
	}

	private void _46E26DC8()
	{
		uint num = 1362633093u;
		while (true)
		{
			num = 0x49E55420 | num;
			_6D2115ED obj = _381D5F4F;
			num *= 410400868;
			int num2 = obj._435152A1();
			num <<= 27;
			if (329863581 > num)
			{
				continue;
			}
			while (true)
			{
				num = 0x6975316 | num;
				int num3 = num2 >> (int)(num ^ 0xA697530Eu);
				if (num - 1967806976 == 0)
				{
					continue;
				}
				int num4 = (int)num ^ -1500032228;
				num = 0x67CD5D09 & num;
				if (num3 <= num4)
				{
					num = 1505898802u >> (int)num;
					num <<= 29;
					uint num5 = num - 1073741823;
					num = 0x5F2B5CD1 ^ num;
					int num6 = num3 - (int)num5;
					num ^= 0x4B3E376A;
					switch (num6)
					{
					case 3:
						goto IL_013c;
					case 0:
					case 1:
						goto IL_01a6;
					case 5:
						goto IL_0214;
					case 2:
					case 4:
						goto IL_03a0;
					}
					num = 0x31B71C16 ^ num;
					while (true)
					{
						num = 2084519001 % num;
						if (num3 != (int)(num - 379372706))
						{
							break;
						}
						num = 1843161923u >> (int)num;
						if (668474823 == num)
						{
							continue;
						}
						goto IL_02ae;
					}
					num += 1031317263;
				}
				else
				{
					num = 478897669 * num;
					int num7 = (int)num - -639593243;
					num += 2050283195;
					if (num3 == num7)
					{
						goto IL_01a6;
					}
					if ((num ^ 0x6D2248C0) == 0)
					{
						break;
					}
					num = 0x1F06560E ^ num;
					int num8 = (int)num + -1259552138;
					num += 151137798;
					if (num3 == num8)
					{
						goto IL_0214;
					}
					if (1953647324 <= num)
					{
						break;
					}
					num ^= 0;
				}
				goto IL_03a0;
				IL_03a0:
				num |= 0x157352C4;
				throw new InvalidOperationException();
				IL_01a6:
				if (num == 1470521527)
				{
					break;
				}
				num &= 0x36290E32;
				_1AF96773 obj2 = _40B8698E;
				num /= 909186577;
				ModuleHandle moduleHandle = _16B6617B.ModuleHandle;
				num = 1921394027u >> (int)num;
				num ^= 0xC4D5007;
				RuntimeTypeHandle runtimeTypeHandle = moduleHandle.ResolveTypeHandle(num2);
				num = 0x3BAF2953 | num;
				obj2._20DB4AD4(new _49826529(runtimeTypeHandle));
				if (num % 106960383 == 0)
				{
					break;
				}
				return;
				IL_013c:
				if (2031385738 > num)
				{
					num = 0x4F796774 & num;
					_1AF96773 obj3 = _40B8698E;
					Module module = _16B6617B;
					num = 807407707 % num;
					moduleHandle = module.ModuleHandle;
					num = 1764174980u >> (int)num;
					num &= 0x331D57E6;
					object _78492022 = moduleHandle.ResolveFieldHandle(num2);
					num = 2139816717 * num;
					_49826529 _5FD = new _49826529(_78492022);
					num = 238557314 - num;
					obj3._20DB4AD4(_5FD);
					return;
				}
				continue;
				IL_0214:
				num = 683673431 * num;
				if (num * 955472438 == 0)
				{
					break;
				}
				_1AF96773 obj4 = _40B8698E;
				num %= 166815134;
				Module module2 = _16B6617B;
				num %= 757210534;
				ModuleHandle moduleHandle2 = module2.ModuleHandle;
				num /= 1917460815;
				moduleHandle = moduleHandle2;
				num %= 1380736109;
				num = 955350157 + num;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle.ResolveMethodHandle(num2);
				num = 0x68AD2CA4 | num;
				object _78492023 = runtimeMethodHandle;
				num *= 604246782;
				obj4._20DB4AD4(new _49826529(_78492023));
				if (num / 1795111787 == 0)
				{
					return;
				}
				continue;
				IL_02ae:
				num = 1132491794 % num;
				if (_46C53560(num2)._27023992)
				{
					num = 0x32223F1C | num;
					if (1364526425 < num)
					{
						break;
					}
					num = 0x33BE3D08 | num;
					_1AF96773 obj5 = _40B8698E;
					moduleHandle = _16B6617B.ModuleHandle;
					num &= 0x15EA26A6;
					object _78492024 = moduleHandle.ResolveMethodHandle(num2);
					num &= 0x5B8B37FE;
					_49826529 _5FD2 = new _49826529(_78492024);
					num = 0x1C974B09 & num;
					obj5._20DB4AD4(_5FD2);
					if (num > 2071362286)
					{
						break;
					}
				}
				else
				{
					num ^= 0x21DB2183;
					_1AF96773 obj6 = _40B8698E;
					num |= 0x66D87D60;
					Module module3 = _16B6617B;
					num = 349520874 / num;
					moduleHandle = module3.ModuleHandle;
					num = (uint)(742155820 << (int)num);
					num ^= 0x551E660B;
					RuntimeFieldHandle runtimeFieldHandle = moduleHandle.ResolveFieldHandle(num2);
					num = 763177859 * num;
					_49826529 _5FD3 = new _49826529(runtimeFieldHandle);
					num = 609425169 - num;
					obj6._20DB4AD4(_5FD3);
					if (261568743 > num)
					{
						break;
					}
				}
				return;
			}
		}
	}

	private void _04D16CFA()
	{
		while (true)
		{
			uint num = 2032475264u;
			_582960B3 _582960B4 = _40B8698E._170D7B68();
			if ((num ^ 0x565302C2) == 0)
			{
				continue;
			}
			_582960B3 _582960B5;
			TypeCode typeCode;
			while (true)
			{
				_582960B5 = _40B8698E._170D7B68();
				num = 0x4F3A0A69 & num;
				if (1347755410 >= num)
				{
					num = 1569220035 * num;
					num = 0x51486C4A ^ num;
					typeCode = _7B624F6F(_582960B5, _582960B4);
					if (2091081337 * num != 0)
					{
						break;
					}
				}
			}
			int num2 = (int)num - -943295423;
			num >>= 9;
			if (typeCode != (TypeCode)num2)
			{
				if (348868103 < num)
				{
					continue;
				}
				do
				{
					if (typeCode == (TypeCode)(num ^ 0x63E331))
					{
						num ^= 0x60CD666E;
						continue;
					}
					throw new InvalidOperationException();
				}
				while (1907167061 <= num);
				_1AF96773 obj = _40B8698E;
				num /= 1494892351;
				num = 681932478 - num;
				obj._20DB4AD4(_66FF619D._1D45514F(_582960B5, _582960B4));
				if (1543141034 << (int)num != 0)
				{
					break;
				}
				continue;
			}
			num = 68293737 + num;
			num |= 0x77542206;
			_1AF96773 obj2 = _40B8698E;
			num = (uint)(1911633529 << (int)num);
			obj2._20DB4AD4(_50424ADC._25AD7155(_582960B5, _582960B4));
			break;
		}
	}

	private TypeCode _7B624F6F(_582960B3 _7B73381D, _582960B3 _541F4105)
	{
		uint num = 1281828708u;
		if (128539010 != num)
		{
			goto IL_0011;
		}
		goto IL_003c;
		IL_0011:
		num = 0x10A5407A ^ num;
		TypeCode num2 = _7B73381D._09A801C9();
		num |= 0x55834F19;
		TypeCode typeCode = num2;
		num /= 1054238137;
		if (872953038 / num != 0)
		{
			goto IL_003c;
		}
		goto IL_0057;
		IL_003c:
		TypeCode typeCode2 = _541F4105._09A801C9();
		num %= 290677892;
		if ((0x42A6088E & num) != 0)
		{
			goto IL_0011;
		}
		goto IL_0057;
		IL_0057:
		if (typeCode != TypeCode.Empty)
		{
			num = 0x427F0587 | num;
			if (num == 2138649478)
			{
				goto IL_003c;
			}
			while (true)
			{
				TypeCode num3 = typeCode2;
				num |= 0x650733ED;
				if (num3 == TypeCode.Empty)
				{
					break;
				}
				num = 905391937 * num;
				TypeCode num4 = typeCode;
				num &= 0x3C9D28F9;
				uint num5 = num ^ 0x140900A8;
				num /= 1604602116;
				if (num4 != (TypeCode)num5)
				{
					num = 1121919074u >> (int)num;
					if (num < 1937396761)
					{
						if (typeCode2 == (TypeCode)(num ^ 0x42DF2063))
						{
							num ^= 0x42DF2062;
							goto IL_00e1;
						}
						num = 1765156903 / num;
						if (typeCode == (TypeCode)(num ^ 0xB))
						{
							goto IL_00fe;
						}
						num = 1660190278 * num;
						if (num >= 1590045791)
						{
							TypeCode num6 = typeCode2;
							uint num7 = num ^ 0x62F47E4C;
							num += 705392881;
							if (num6 == (TypeCode)num7)
							{
								goto IL_0165;
							}
							if (1728277417 >= num)
							{
								continue;
							}
							TypeCode num8 = typeCode;
							num = 1327322457 / num;
							int num9 = (int)num - -12;
							num -= 356329709;
							if (num8 == (TypeCode)num9)
							{
								num = 117844471 * num;
								if (1390891745 / num == 0)
								{
									continue;
								}
								TypeCode num10 = typeCode2;
								uint num11 = num - 1172409932;
								num = 726950640u >> (int)num;
								if (num10 != (TypeCode)num11)
								{
									TypeCode num12 = typeCode2;
									num = (uint)(215508477 << (int)num);
									int num13 = (int)num - -201326603;
									num -= 1708596506;
									num ^= 0x8E28E3BCu;
									if (num12 != (TypeCode)num13)
									{
										if (1075987706 < num)
										{
											continue;
										}
										TypeCode num14 = typeCode2;
										uint num15 = num ^ 0x156;
										num += 0;
										if (num14 != (TypeCode)num15)
										{
											num = 56506339u >> (int)num;
											return (TypeCode)(num ^ 0);
										}
									}
								}
								num += 825639380;
								return typeCode;
							}
							goto IL_0299;
						}
					}
					goto IL_0011;
				}
				goto IL_00e1;
				IL_00e1:
				return (TypeCode)(num ^ 1);
			}
			num ^= 0x677F37EE;
		}
		return (TypeCode)(num ^ 1);
		IL_0165:
		num /= 662575923;
		if ((0x7D734718 ^ num) != 0)
		{
			if (typeCode != (TypeCode)(num ^ 0xA))
			{
				num = (uint)(736037296 << (int)num);
				if ((num & 0x68396461) == 0)
				{
					goto IL_003c;
				}
				TypeCode num16 = typeCode;
				uint num17 = num ^ 0x5EF84D8A;
				num *= 319638827;
				num ^= 0x12848483;
				if (num16 != (TypeCode)num17)
				{
					num /= 192160533;
					return (TypeCode)(num ^ 0);
				}
			}
			num = 1052409696 - num;
			return typeCode2;
		}
		goto IL_0011;
		IL_0299:
		if (1566917939 < num)
		{
			TypeCode num18 = typeCode2;
			int num19 = (int)num - -356329721;
			num = (uint)(958011840 << (int)num);
			if (num18 != (TypeCode)num19)
			{
				num &= 0x409C63A7;
				TypeCode num20 = typeCode;
				num |= 0x2153D9F;
				if (num20 != (TypeCode)((int)num + -1108688273))
				{
					num = 0x379E09A4 & num;
					if (num - 1536033062 == 0)
					{
						goto IL_0011;
					}
					if (typeCode2 != (TypeCode)(num - 34867574))
					{
						if (num + 2034651144 != 0)
						{
							TypeCode num21 = typeCode;
							num = 196111857 * num;
							int num22 = (int)num - -1280693961;
							num = 872311822u >> (int)num;
							if (num21 != (TypeCode)num22)
							{
								num ^= 0x22B20B1A;
								if (598868456 >>> (int)num == 0)
								{
									goto IL_0011;
								}
								if (typeCode2 != (TypeCode)(num - 562949581))
								{
									TypeCode num23 = typeCode;
									num = (uint)(956183674 << (int)num);
									int num24 = (int)num ^ -402653173;
									num += 1133774340;
									if (num23 != (TypeCode)num24)
									{
										if (num << 15 == 0)
										{
											goto IL_0011;
										}
										TypeCode num25 = typeCode2;
										num = 1355962018 % num;
										if (num25 != (TypeCode)((int)num + -624840851))
										{
											num |= 0x6CAD3290;
											return (TypeCode)(num ^ 0x6DBF7297);
										}
										num += 106280294;
									}
									return (TypeCode)((int)num + -731121145);
								}
								num += 3786537190u;
							}
							num %= 867775218;
							return (TypeCode)(num ^ 0x33FE6CD);
						}
						goto IL_003c;
					}
					num ^= 0x4001341B;
				}
				return (TypeCode)((int)num + -1108688273);
			}
			TypeCode num26 = typeCode;
			int num27 = (int)num ^ -838860791;
			num = 0x7BCF7120 & num;
			if (num26 != (TypeCode)num27)
			{
				if (645881285 % num == 0)
				{
					goto IL_0011;
				}
				TypeCode num28 = typeCode;
				uint num29 = num ^ 0x4A00000B;
				num ^= 0;
				if (num28 != (TypeCode)num29)
				{
					num = 0x2817096F ^ num;
					TypeCode num30 = typeCode;
					uint num31 = num ^ 0x62170963;
					num = 1417362079 - num;
					num += 1469828816;
					if (num30 != (TypeCode)num31)
					{
						return (TypeCode)((int)num + -1241513984);
					}
				}
			}
			num = 0x20787588 ^ num;
			if ((num ^ 0x2DD26D37) != 0)
			{
				return typeCode2;
			}
		}
		goto IL_0011;
		IL_00fe:
		if (1602684134 != num)
		{
			TypeCode num32 = typeCode2;
			uint num33 = num ^ 8;
			num = 0x5A7C6A85 ^ num;
			if (num32 != (TypeCode)num33)
			{
				TypeCode num34 = typeCode2;
				uint num35 = num - 1518103162;
				num ^= 0;
				if (num34 != (TypeCode)num35)
				{
					return (TypeCode)((int)num + -1518103172);
				}
			}
			return typeCode;
		}
		goto IL_0011;
	}

	private void _19AE5B2D()
	{
		while (true)
		{
			_6D2115ED obj = _381D5F4F;
			uint num = 795490082u;
			short num2 = obj._4B03768E();
			num = 672741408 % num;
			short num3 = num2;
			num = 0x34E42D6F & num;
			if ((num & 0x2A18173E) != 0)
			{
				_1AF96773 obj2 = _40B8698E;
				num |= 0xD39580D;
				_582960B3 _582960B4 = obj2._40FF23BC(num3);
				num += 1853229868;
				if ((num & 0x37DD2336) == 0)
				{
					continue;
				}
				_582960B3 _582960B5 = _40B8698E._170D7B68();
				num = 1673017139 % num;
				if (_582960B4 != null)
				{
					num |= 0x78383718;
					num %= 2130515917;
					_582960B3 obj3 = _318778F9(_582960B5, _582960B4._71C820E4());
					num >>= 30;
					object _63C = obj3._0936516D();
					num = 1531393967 + num;
					_582960B4._727F3897(_63C);
					if ((num ^ 0x13C70852) != 0)
					{
						break;
					}
					continue;
				}
				if (num == 411971888)
				{
					continue;
				}
				bool num4 = _582960B5._11EF2F40();
				num = 1321036037 * num;
				if (num4)
				{
					num /= 296618966;
					if (num <= 1226329636)
					{
						_40B8698E._3CF40F6B(num3, _582960B5);
						num = 0x7E7A50F0 | num;
						break;
					}
					continue;
				}
				num %= 115036857;
				if (num >= 2039894249)
				{
					continue;
				}
			}
			throw new ArgumentException();
		}
	}

	private void _1BA85A41()
	{
		uint num = 1842314515u;
		if (1415725869 != num)
		{
			goto IL_0011;
		}
		goto IL_00e8;
		IL_0011:
		int _7F5B64AB = _381D5F4F._435152A1();
		num += 848046670;
		MethodBase methodBase = _37690AA7(_7F5B64AB);
		num = (uint)(1381183498 << (int)num);
		goto IL_003a;
		IL_003a:
		Type type2 = default(Type);
		do
		{
			num = 2052014463 + num;
			_1AF96773 obj = _40B8698E;
			num %= 1106267611;
			_582960B3 obj2 = obj._170D7B68();
			num /= 217121385;
			Type type = obj2._0936516D().GetType();
			num += 352217301;
			type2 = type;
			num = 0x759973FF ^ num;
		}
		while (1720525567 <= num);
		goto IL_0084;
		IL_0084:
		MethodBase methodBase2 = methodBase;
		num += 1897995206;
		Type declaringType = methodBase2.DeclaringType;
		num %= 1741100003;
		goto IL_009d;
		IL_009d:
		MethodBase methodBase3 = methodBase;
		num = 595209377 / num;
		ParameterInfo[] parameters = methodBase3.GetParameters();
		IntPtr intPtr = (nint)parameters.LongLength;
		num = 440361176 / num;
		int num2 = (int)(nint)intPtr;
		num = 0x524A56AD | num;
		Type[] array = new Type[num2];
		num &= 0x78F53AC6;
		Type[] array2 = array;
		num = 194342820 / num;
		int num3 = (int)(num ^ 0);
		num <<= 27;
		ParameterInfo[] array3 = parameters;
		goto IL_00e8;
		IL_00e8:
		uint num4 = num ^ 0;
		num = 637472043 - num;
		int num5 = (int)num4;
		if ((num ^ 0x15A2685) != 0)
		{
			while (true)
			{
				num >>= 18;
				if (num >= 1137844017)
				{
					break;
				}
				int num6 = num5;
				ParameterInfo[] array4 = array3;
				num = 1886202261 - num;
				IntPtr intPtr2 = (nint)array4.LongLength;
				num = 2030581332 / num;
				if (num6 < (int)(nint)intPtr2)
				{
					ParameterInfo[] array5 = array3;
					num = 381117199u;
					ParameterInfo obj3 = array5[num5];
					num %= 630944557;
					ParameterInfo parameterInfo = obj3;
					Type[] array6 = array2;
					num = (uint)(1413229920 << (int)num);
					int num7 = num3;
					num = 0x7AE25C8D & num;
					uint num8 = num ^ 0x12A00001;
					num = 982658643 * num;
					num3 = num7 + (int)num8;
					num %= 1711089629;
					array6[num7] = parameterInfo.ParameterType;
					num &= 0x41944314;
					if (2047690205 / num == 0)
					{
						break;
					}
					int num9 = num5;
					num += 1971674121;
					int num10 = (int)num ^ -1224369144;
					num = 0x2EE8381B | num;
					num5 = num9 + num10;
					num += 1712410896;
					continue;
				}
				goto IL_02ad;
			}
			goto IL_0011;
		}
		goto IL_003a;
		IL_02ad:
		while (true)
		{
			num %= 383280787;
			if ((0x79B64596 & num) != 0)
			{
				break;
			}
			Type type3 = type2;
			num = (uint)(678722689 << (int)num);
			num ^= 0x65810FFE;
			bool num11 = type3 != null;
			num = 1332436632 + num;
			num += 2066393708;
			if (num11)
			{
				num = (uint)(731011327 << (int)num);
				if (538732900u >> (int)num != 0)
				{
					goto IL_003a;
				}
				Type type4 = type2;
				Type type5 = declaringType;
				num |= 0x4B2230D;
				if (type4 != type5)
				{
					num = 788883381u;
					if (1620724991 < num)
					{
						break;
					}
					Type type6 = type2;
					string name = methodBase.Name;
					uint bindingAttr = num ^ 0x2F045783;
					num = 1616673927 / num;
					uint callConvention = num ^ 1;
					Type[] types = array2;
					num &= 0x5EC867EF;
					MethodInfo? method = type6.GetMethod(name, (BindingFlags)bindingAttr, null, (CallingConventions)callConvention, types, null);
					num <<= 13;
					MethodInfo methodInfo = method;
					bool num12 = methodInfo != null;
					num = 0x62D6410A & num;
					if (num12)
					{
						num |= 0x2C387386;
						if ((num ^ 0x6DF612EF) == 0)
						{
							goto IL_0084;
						}
						MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
						num += 616521859;
						MethodBase methodBase4 = methodBase;
						num *= 388375681;
						bool num13 = baseDefinition == methodBase4;
						num /= 1628010317;
						num += 16382;
						if (num13)
						{
							num *= 575372074;
							if (num < 862150139)
							{
								goto IL_009d;
							}
							num = 132344933 / num;
							methodBase = methodInfo;
							goto IL_0332;
						}
					}
					if (959334091 > num)
					{
						Type type7 = type2;
						num = 0x54702887 | num;
						type2 = type7.BaseType;
						num ^= 0x54706886;
						continue;
					}
					goto IL_0084;
				}
				num += 3494740993u;
			}
			goto IL_0332;
			IL_0332:
			if (435030622 != num)
			{
				_1AF96773 obj4 = _40B8698E;
				num /= 1873101553;
				_4C96047E _5FD = new _4C96047E(methodBase);
				num = 0x70C95690 ^ num;
				obj4._20DB4AD4(_5FD);
				if (num < 105449428)
				{
					break;
				}
				return;
			}
			goto IL_0084;
		}
		goto IL_0011;
	}

	private unsafe _582960B3 _318778F9(object _52BC02CD, Type _37AC2BCF)
	{
		while (true)
		{
			_582960B3 _582960B4 = _52BC02CD as _582960B3;
			while (true)
			{
				bool isEnum = _37AC2BCF.IsEnum;
				uint num = 2106482070u;
				if (isEnum)
				{
					if (num <= 1925606444)
					{
						break;
					}
					goto IL_0023;
				}
				num /= 1757232183;
				TypeCode typeCode = Type.GetTypeCode(_37AC2BCF);
				num /= 545662132;
				TypeCode typeCode2 = typeCode;
				num = 753365167 - num;
				num %= 2024869077;
				uint num2 = num ^ 0x2CE770AC;
				num = 298979803 % num;
				int num3 = (int)typeCode2 - (int)num2;
				num |= 0x2CFC3428;
				switch (num3)
				{
				default:
					num ^= 0;
					goto IL_062b;
				case 0:
					break;
				case 1:
					goto IL_022a;
				case 2:
					goto IL_027d;
				case 3:
					goto IL_02c8;
				case 4:
					goto IL_0323;
				case 5:
					goto IL_0368;
				case 6:
				{
					num &= 0x20774A2D;
					int _7A3475AA;
					if (_582960B4 == null)
					{
						object value2 = _52BC02CD;
						num %= 2094681946;
						_7A3475AA = Convert.ToInt32(value2);
					}
					else
					{
						num = (uint)(179593369 << (int)num);
						_7A3475AA = _582960B4._6AAF062D();
						num ^= 0x48B73229;
					}
					return new _50424ADC(_7A3475AA);
				}
				case 7:
					goto IL_041d;
				case 8:
					goto IL_0474;
				case 9:
					goto IL_04e2;
				case 10:
				{
					num *= 103439874;
					float _3A4B;
					if (_582960B4 == null)
					{
						num += 1751127207;
						object value = _52BC02CD;
						num >>= 5;
						_3A4B = Convert.ToSingle(value);
					}
					else
					{
						num = 2061897026 * num;
						_3A4B = _582960B4._078008FE();
						num ^= 0x2C0AC238;
					}
					return new _5A103814(_3A4B);
				}
				case 11:
					goto IL_0582;
				case 15:
					goto IL_05d2;
				case 12:
				case 13:
				case 14:
					goto IL_062b;
				}
				num = 0x9D70B07 & num;
				bool _375C684C;
				if (_582960B4 == null)
				{
					num ^= 0x5DF40C49;
					if (num + 80052196 == 0)
					{
						goto IL_0023;
					}
					_375C684C = Convert.ToBoolean(_52BC02CD);
				}
				else
				{
					num %= 1008414638;
					if (1092578015 <= num)
					{
						break;
					}
					num = 48439191 * num;
					_375C684C = _582960B4._27B26B78();
					num ^= 0xF720F88Fu;
				}
				return new _488D2F82(_375C684C);
				IL_0323:
				short _585E;
				if (_582960B4 == null)
				{
					if ((num ^ 0x6955133F) == 0)
					{
						break;
					}
					object value3 = _52BC02CD;
					num += 119866645;
					_585E = Convert.ToInt16(value3);
				}
				else
				{
					if (341213102 / num != 0)
					{
						break;
					}
					_585E = _582960B4._72435997();
					num ^= 0x78DD0EEB;
				}
				return new _4F3F00F5(_585E);
				IL_02c8:
				byte _259033B;
				if (_582960B4 == null)
				{
					num += 815336946;
					if (48131701 > num)
					{
						goto IL_0023;
					}
					object value4 = _52BC02CD;
					num %= 896291539;
					_259033B = Convert.ToByte(value4);
				}
				else
				{
					num = 17646763 + num;
					if (num <= 704072109)
					{
						break;
					}
					num |= 0x2BB06D6F;
					_259033B = _582960B4._70DF711E();
					num ^= 0x3C05E1A8;
				}
				return new _48772BCF(_259033B);
				IL_05d2:
				if (50751253 - num == 0)
				{
					break;
				}
				num += 671482667;
				object _618A179B;
				if (_582960B4 == null)
				{
					if (num - 1845959556 == 0)
					{
						goto IL_0023;
					}
					object obj = _52BC02CD;
					num &= 0x23764974;
					_618A179B = (string)obj;
				}
				else
				{
					if (212237450 + num == 0)
					{
						goto IL_0072;
					}
					_618A179B = _582960B4.ToString();
					num += 3154104318u;
				}
				return new _0BD93DAD((string)_618A179B);
				IL_0072:
				while (true)
				{
					object obj2 = _52BC02CD;
					num = 892211822u >> (int)num;
					Enum obj3 = obj2 as Enum;
					num /= 53232658;
					num ^= 0;
					if (obj3 != null)
					{
						break;
					}
					num ^= 0x5B601D31;
					if (1802982590 * num != 0)
					{
						object obj4 = Enum.ToObject(_37AC2BCF, _52BC02CD);
						num -= 715226998;
						_52BC02CD = obj4;
						num ^= 0x30BE9DBB;
						break;
					}
				}
				goto IL_00c8;
				IL_027d:
				num %= 1229196527;
				if (1758095422 < num)
				{
					continue;
				}
				num = 0x236177AD ^ num;
				sbyte _78492022;
				if (_582960B4 == null)
				{
					_78492022 = Convert.ToSByte(_52BC02CD);
				}
				else
				{
					if (1908543377 == num)
					{
						break;
					}
					_78492022 = _582960B4._22B70934();
					num ^= 0;
				}
				return new _1CE22CD9(_78492022);
				IL_062b:
				num -= 1818629285;
				num = 0x242257C7 ^ num;
				num |= 0x667F0115;
				Type? typeFromHandle = typeof(IntPtr);
				num = 261504205 / num;
				bool num4 = _37AC2BCF == typeFromHandle;
				num = 107963985 * num;
				if (num4)
				{
					if (num >= 1815305630)
					{
						break;
					}
					num = 0x4AF84EF9 ^ num;
					if (_582960B4 != null)
					{
						num = 1192324171 + num;
						if (271679165 / num == 0)
						{
							num = 590221833 * num;
							return new _515B561F(_582960B4._47C01150());
						}
						continue;
					}
					num *= 1989886826;
					object obj5 = _52BC02CD;
					num = 1812535137 + num;
					IntPtr _06C6674A;
					if (obj5 == null)
					{
						num >>= 30;
						_06C6674A = IntPtr.Zero;
					}
					else
					{
						num = 1453225197 * num;
						object obj6 = _52BC02CD;
						num = 1896558808 % num;
						_06C6674A = (IntPtr)obj6;
						num += 2398408488u;
					}
					num = 0x7B573E66 ^ num;
					return new _515B561F(_06C6674A);
				}
				if (_37AC2BCF == typeof(UIntPtr))
				{
					num = (uint)(1883454174 << (int)num);
					if (668076302 < num)
					{
						num ^= 0x284D5929;
						if (_582960B4 != null)
						{
							num /= 803216629;
							UIntPtr _10662FF = _582960B4._15842C84();
							num = 2092109696 % num;
							return new _51773792(_10662FF);
						}
						num |= 0x7E236142;
						if (2011372186 / num != 0)
						{
							break;
						}
						IntPtr _10662FF2;
						if (_52BC02CD == null)
						{
							_10662FF2 = (nint)(nuint)UIntPtr.Zero;
						}
						else
						{
							if (num - 1284391199 == 0)
							{
								break;
							}
							_10662FF2 = (nint)(nuint)(UIntPtr)_52BC02CD;
							num += 0;
						}
						return new _51773792((nuint)(nint)_10662FF2);
					}
				}
				else
				{
					bool isValueType = _37AC2BCF.IsValueType;
					num = 1813674399 - num;
					if (isValueType)
					{
						num = 0x699F02B5 | num;
						if (num <= 1434131483)
						{
							break;
						}
						num <<= 5;
						if (_582960B4 != null)
						{
							num = 1369785635 / num;
							return new _49826529(_582960B4._0936516D());
						}
						if (1104102958 << (int)num != 0)
						{
							object obj7 = _52BC02CD;
							num = 0x5A43120C & num;
							object? _78492023;
							if (obj7 != null)
							{
								_78492023 = _52BC02CD;
							}
							else
							{
								num = 99499976u >> (int)num;
								num = 2112425660 * num;
								_78492023 = Activator.CreateInstance(_37AC2BCF);
								num ^= 0x538D4E0;
							}
							num /= 640229160;
							return new _49826529(_78492023);
						}
						continue;
					}
					if ((num ^ 0x20F907CA) != 0)
					{
						num = 464519988 / num;
						if (_37AC2BCF.IsArray)
						{
							object _78492024;
							if (_582960B4 == null)
							{
								num -= 1635735846;
								object obj8 = _52BC02CD;
								num = 0x10CF52A2 & num;
								_78492024 = (Array)obj8;
							}
							else
							{
								object obj9 = _582960B4._0936516D();
								num >>= 19;
								_78492024 = (Array)obj9;
								num += 276824706;
							}
							return new _28B24C0E((Array)_78492024);
						}
						num = 0x2C1D4E59 ^ num;
						if (1145524217 % num != 0)
						{
							num = 301793428u >> (int)num;
							bool isPointer = _37AC2BCF.IsPointer;
							num |= 0x74422F71;
							if (isPointer)
							{
								if (_582960B4 != null)
								{
									num += 73161722;
									num = 0x73DA3174 ^ num;
									object _04F76BC = Pointer.Box(_582960B4._1AF75EB9(), _37AC2BCF);
									num %= 522215150;
									return new _18D4487E(_04F76BC, _37AC2BCF);
								}
								num += 1277111617;
								nint ptr;
								if (_52BC02CD == null)
								{
									num *= 1551723708;
									uint num5 = num - 2037420184;
									num ^= 0x7D8B10A1;
									ptr = (nint)num5;
								}
								else
								{
									if (num - 140268467 == 0)
									{
										goto IL_0023;
									}
									object ptr2 = _52BC02CD;
									num = 0x29BB0E43 | num;
									ptr = (nint)Pointer.Unbox(ptr2);
									num += 452993342;
								}
								return new _18D4487E(Pointer.Box((void*)ptr, _37AC2BCF), _37AC2BCF);
							}
							num += 431838148;
							object _3CE71D;
							if (_582960B4 == null)
							{
								_3CE71D = _52BC02CD;
							}
							else
							{
								num *= 193274789;
								num = 2086998548 % num;
								_3CE71D = _582960B4._0936516D();
								num ^= 0xB7ECA7FEu;
							}
							return new _2CEE4B34(_3CE71D);
						}
						goto IL_0031;
					}
				}
				goto IL_0023;
				IL_00c8:
				if (952648291 >= num)
				{
					object obj10 = _52BC02CD;
					num = (uint)(1118323431 << (int)num);
					object _1D1B43E;
					if (obj10 != null)
					{
						num = 0x390069D8 ^ num;
						if (938164148 > num)
						{
							goto IL_0023;
						}
						_1D1B43E = (Enum)_52BC02CD;
					}
					else
					{
						num += 1074358450;
						num = 0x5F65333A & num;
						_1D1B43E = (Enum)Activator.CreateInstance(_37AC2BCF);
						num ^= 0x79890827;
					}
					num = (uint)(1793070797 << (int)num);
					return new _3DD06737((Enum)_1D1B43E);
				}
				goto IL_0023;
				IL_0368:
				num += 1021670778;
				if (num - 1962634587 == 0)
				{
					continue;
				}
				num /= 1548373592;
				ushort _787C;
				if (_582960B4 == null)
				{
					num = (uint)(805401727 << (int)num);
					object value5 = _52BC02CD;
					num <<= 29;
					_787C = Convert.ToUInt16(value5);
				}
				else
				{
					num = 0x7344046 | num;
					if (1354960623 <= num)
					{
						break;
					}
					num <<= 4;
					_787C = _582960B4._16D4371A();
					num += 1287388048;
				}
				return new _05FE464D(_787C);
				IL_041d:
				uint _24A0670E;
				if (_582960B4 == null)
				{
					num = 784347353 % num;
					object value6 = _52BC02CD;
					num *= 540695871;
					_24A0670E = Convert.ToUInt32(value6);
				}
				else
				{
					num = (uint)(673394717 << (int)num);
					if (1467303898 / num != 0)
					{
						continue;
					}
					_24A0670E = _582960B4._76377E70();
					num ^= 0x6C34DA67;
				}
				num *= 62285855;
				return new _39EC73F4(_24A0670E);
				IL_0582:
				if (num == 188810089)
				{
					break;
				}
				num = 755053112 * num;
				double _5FD;
				if (_582960B4 == null)
				{
					object value7 = _52BC02CD;
					num %= 1126530018;
					_5FD = Convert.ToDouble(value7);
				}
				else
				{
					num /= 239420216;
					_5FD = _582960B4._40F966AC();
					num ^= 0x4D6DD2D;
				}
				num = 666183768 % num;
				return new _77315431(_5FD);
				IL_0474:
				if (num <= 1482307710)
				{
					long _52CC445F;
					if (_582960B4 == null)
					{
						num <<= 0;
						if ((num & 0x630963A8) == 0)
						{
							goto IL_0023;
						}
						_52CC445F = Convert.ToInt64(_52BC02CD);
					}
					else
					{
						num = (uint)(1307453170 << (int)num);
						if (429075739 * num == 0)
						{
							break;
						}
						num -= 1321029525;
						_52CC445F = _582960B4._3E0F495D();
						num += 4240147856u;
					}
					num |= 0x1E89090E;
					return new _66FF619D(_52CC445F);
				}
				goto IL_0023;
				IL_0023:
				num = 0x13B23B8E & num;
				if (_582960B4 != null)
				{
					goto IL_0031;
				}
				goto IL_0051;
				IL_0031:
				num = 1244614633 - num;
				object obj11 = _582960B4._0936516D();
				num -= 1918400213;
				_52BC02CD = obj11;
				num += 1261263352;
				goto IL_0051;
				IL_0051:
				object obj12 = _52BC02CD;
				num /= 1575636787;
				if (obj12 != null)
				{
					num = 0x61424815 | num;
					if (8261310 == num)
					{
						continue;
					}
					goto IL_0072;
				}
				goto IL_00c8;
				IL_04e2:
				num -= 1029861486;
				if (num > 1538198414)
				{
					break;
				}
				num %= 1537411733;
				ulong _42877CF;
				if (_582960B4 == null)
				{
					num = 2046047463 - num;
					if (785190283 > num)
					{
						continue;
					}
					_42877CF = Convert.ToUInt64(_52BC02CD);
				}
				else
				{
					_42877CF = _582960B4._5ECF32BD();
					num += 2025630157;
				}
				num <<= 27;
				return new _482E45FB(_42877CF);
				IL_022a:
				num = 0x1EDD3EC2 ^ num;
				char _65AE5CD;
				if (_582960B4 == null)
				{
					num = 1808868151 + num;
					if (1604218787 == num)
					{
						break;
					}
					_65AE5CD = Convert.ToChar(_52BC02CD);
				}
				else
				{
					num = 369041724 - num;
					if (1606555824 == num)
					{
						break;
					}
					_65AE5CD = _582960B4._52B43B98();
					num += 2618824813u;
				}
				return new _19B932DA(_65AE5CD);
			}
		}
	}

	private void _67880719()
	{
		uint num = 686515309u;
		num *= 1433362469;
		_1AF96773 obj = _40B8698E;
		num = 0x45E32792 & num;
		long _52CC445F = _381D5F4F._72111BC7();
		num /= 120787449;
		obj._20DB4AD4(new _66FF619D(_52CC445F));
	}

	private void _78DA3BAD()
	{
		uint num = 836848850u;
		if (num >> 18 != 0)
		{
			num *= 644107636;
			Exception ex = _459D7272;
			num = 656478661u >> (int)num;
			if ((ex != null || 1914140556 < num) && num << 22 != 0)
			{
				throw _459D7272;
			}
		}
		throw new InvalidOperationException();
	}

	private void _4EA5585B()
	{
		while (true)
		{
			_582960B3 _582960B4 = _40B8698E._170D7B68();
			uint num = 1985572307u;
			while (true)
			{
				num = 0x70B83DD5 | num;
				_582960B3 _582960B5 = _40B8698E._170D7B68();
				num %= 2135113960;
				if (num / 2013734380 != 0)
				{
					break;
				}
				bool flag;
				bool flag2;
				while (true)
				{
					byte num2 = _381D5F4F._0F9F2D0A();
					num = 698099880 * num;
					uint num3 = num ^ 0x2D682D19;
					num = 549287169 * num;
					flag = (num2 & num3) > num - 347874584;
					num = 0x44BF60C5 ^ num;
					uint num4 = num ^ 0x500345FD;
					num >>= 0;
					flag2 = (num2 & num4) > (uint)((int)num + -1342391773);
					num *= 1117154065;
					TypeCode num5 = _7B624F6F(_582960B4, _582960B5);
					num -= 504189690;
					TypeCode typeCode = num5;
					num |= 0x28D508F7;
					num -= 1376130736;
					uint num6 = num ^ 0x27D9994E;
					num ^= 0x33405BC0;
					switch ((int)typeCode - (int)num6)
					{
					case 0:
					{
						num |= 0x4F81870;
						_1AF96773 obj = _40B8698E;
						num %= 584872157;
						num = 882319164 + num;
						num = 1894529983 * num;
						obj._20DB4AD4(_50424ADC._17D57EAC(_582960B4, _582960B5, flag2, flag));
						return;
					}
					case 2:
						break;
					case 4:
						goto IL_01a2;
					case 5:
						goto IL_01d8;
					case 1:
					case 3:
						goto IL_023e;
					default:
						goto IL_0298;
					}
					break;
					IL_01d8:
					num &= 0x182F09AF;
					if (num == 664479487)
					{
						continue;
					}
					goto IL_01ee;
				}
				num = 0x3DF976D3 & num;
				if (1317955238 * num == 0)
				{
					break;
				}
				num ^= 0x7E01016C;
				_1AF96773 obj2 = _40B8698E;
				num = 1176064338 * num;
				num &= 0x755B3284;
				num >>= 14;
				_582960B3 _5FD = _66FF619D._755C7C0C(_582960B4, _582960B5, flag2, flag);
				num = 0x3A6069A0 ^ num;
				obj2._20DB4AD4(_5FD);
				return;
				IL_01ee:
				_1AF96773 obj3 = _40B8698E;
				num = 403654499 % num;
				num = (uint)(1630539112 << (int)num);
				num -= 1522664828;
				_582960B3 _5FD2 = _77315431._09BD67D8(_582960B4, _582960B5, flag2, flag);
				num %= 1740466492;
				obj3._20DB4AD4(_5FD2);
				if (740244511 <= num)
				{
					break;
				}
				return;
				IL_0298:
				if (1726706887 % num == 0)
				{
					break;
				}
				throw new InvalidOperationException();
				IL_01a2:
				num /= 2061384452;
				if (num <= 703864981)
				{
					_1AF96773 obj4 = _40B8698E;
					num += 1697660401;
					obj4._20DB4AD4(_5A103814._54097123(_582960B4, _582960B5, flag2, flag));
					return;
				}
				continue;
				IL_023e:
				num ^= 0x29190632;
				_1AF96773 obj5 = _40B8698E;
				num = 2107135155u >> (int)num;
				num /= 1650480677;
				num = 1352018626 * num;
				num >>= 1;
				obj5._20DB4AD4(_18D4487E._3979755E(_582960B4, _582960B5, flag2, flag));
				if (444472138 >= num)
				{
					return;
				}
			}
		}
	}

	private void _348D306A()
	{
		while (true)
		{
			uint num = 762195035u;
			_1AF96773 obj = _40B8698E;
			num -= 474897826;
			_582960B3 _582960B4 = obj._170D7B68();
			num = 29515034 - num;
			while (true)
			{
				num %= 1502903470;
				_1AF96773 obj2 = _40B8698E;
				num |= 0x41D5459B;
				_582960B3 _582960B5 = obj2._170D7B68();
				num ^= 0x4C6D52B8;
				if (310001330 * num == 0)
				{
					continue;
				}
				uint num2 = _381D5F4F._0F9F2D0A() & (num ^ 0x31908726);
				num = 1510685368 % num;
				bool num3 = num2 > (num ^ 0x287AB391);
				num = 0x7A820D76 ^ num;
				bool flag = num3;
				num = 2003377861 + num;
				if (num < 160052345)
				{
					break;
				}
				TypeCode num4 = _582960B5._09A801C9();
				num /= 1816272189;
				TypeCode typeCode = num4;
				if (1486760055 % num != 0)
				{
					break;
				}
				if (typeCode != (TypeCode)(num + 8))
				{
					num -= 890717429;
					if ((0x4E066225 & num) == 0)
					{
						break;
					}
					while (true)
					{
						num |= 0x778261E9;
						if (typeCode == (TypeCode)((int)num - -1377310))
						{
							break;
						}
						if (1841190758 < num)
						{
							num *= 60769701;
							throw new InvalidOperationException();
						}
					}
					num = 464459426 + num;
					if (920868793 >>> (int)num == 0)
					{
						break;
					}
					_1AF96773 obj3 = _40B8698E;
					num = 0x555A49CE & num;
					obj3._20DB4AD4(_66FF619D._1D2D1B25(_582960B5, _582960B4, flag));
					return;
				}
				num *= 229276803;
				if (942415445 != num)
				{
					num <<= 10;
					_40B8698E._20DB4AD4(_50424ADC._0F661174(_582960B5, _582960B4, flag));
					return;
				}
			}
		}
	}

	private void _562978D7()
	{
		uint num;
		do
		{
			num = 876551546u;
			if (_459D7272 != null)
			{
				num = 0x54D03F42 | num;
				_643B05B5();
				if (num >= 1746288104)
				{
					break;
				}
			}
			num = 0x34F1095C ^ num;
			_381D5F4F._55863A4A();
		}
		while (num >> 13 == 0);
	}

	private void _753C322B()
	{
		uint num = 1240010521u;
		_1AF96773 obj = _40B8698E;
		_6D2115ED obj2 = _381D5F4F;
		num <<= 23;
		int _7A3475AA = obj2._435152A1();
		num = 1043736992u >> (int)num;
		_50424ADC _5FD = new _50424ADC(_7A3475AA);
		num -= 1013994911;
		obj._20DB4AD4(_5FD);
	}

	private void _06B941F1()
	{
		_1AF96773 obj = _40B8698E;
		uint num = 37242842u;
		obj._20DB4AD4(new _2CEE4B34(null));
	}

	private void _14D24103()
	{
		FieldInfo _488D58F;
		uint num;
		do
		{
			num = 1644388186u;
			num = 2035418796u >> (int)num;
			_6D2115ED obj = _381D5F4F;
			num /= 2056152459;
			_488D58F = _3BA823A3(obj._435152A1());
			num = 0x3C751044 & num;
		}
		while (num - 314252238 == 0);
		_582960B3 _08EE4CD = _40B8698E._170D7B68();
		_1AF96773 obj2 = _40B8698E;
		num = 0x6EF076CA & num;
		num %= 1758337540;
		num = 1057168156 * num;
		_4287017A _5FD = new _4287017A(_488D58F, _08EE4CD);
		num = 0x63123809 ^ num;
		obj2._20DB4AD4(_5FD);
	}

	private void _76A86CFF()
	{
		MethodBase methodBase2;
		ParameterInfo[] array;
		uint num;
		while (true)
		{
			num = 741087156u;
			num = 1696995351 % num;
			int _7F5B64AB = _381D5F4F._435152A1();
			num *= 419497512;
			MethodBase methodBase = _37690AA7(_7F5B64AB);
			num &= 0xCB23610;
			methodBase2 = methodBase;
			num = 1592285982u >> (int)num;
			if ((0x47FA50CD & num) != 0)
			{
				num += 1624666259;
				ParameterInfo[] parameters = methodBase2.GetParameters();
				num = 0x2E8959AB | num;
				array = parameters;
				if ((num ^ 0x69666756) != 0)
				{
					break;
				}
			}
		}
		Dictionary<int, _582960B3> dictionary = new Dictionary<int, _582960B3>();
		num += 233052769;
		Dictionary<int, _582960B3> dictionary2 = dictionary;
		object[] array2;
		do
		{
			num = 1747994606 / num;
			array2 = new object[array.Length];
		}
		while (2097576016 <= num);
		_4E2E44B6 obj = new _4E2E44B6();
		num = 0x7F8C4C8D ^ num;
		_4E2E44B6 _4E2E44B7 = obj;
		try
		{
			num %= 2071735492;
			int num2 = array.Length;
			uint num3 = num - 68165576;
			num = 0x56475C70 & num;
			int num4 = num2 - (int)num3;
			num = 1426484796 - num;
			int num5 = num4;
			while (true)
			{
				num /= 2138833601;
				int num6 = num5;
				uint num7 = num ^ 0;
				num *= 1954964479;
				if (num6 < (int)num7)
				{
					break;
				}
				while (true)
				{
					int num8 = num5;
					num = 1971195657u;
					Type parameterType = array[num8].ParameterType;
					_582960B3 _582960B4;
					do
					{
						_582960B4 = _40B8698E._170D7B68();
					}
					while ((num ^ 0x45D859E9) == 0);
					num = 0x68001F41 | num;
					bool num9 = _582960B4._11EF2F40();
					num ^= 0x158560A7;
					if (num9)
					{
						if (num > 1966372851)
						{
							continue;
						}
						num <<= 31;
						bool isByRef = parameterType.IsByRef;
						num = 1930697035 + num;
						if (!isByRef)
						{
							num = 1709516735 / num;
							int num10 = num5;
							num ^= 0x3C9E6F75;
							num |= 0x426A6F6F;
							IntPtr intPtr = _4E2E44B7._33CD5A83(_582960B4._0936516D());
							num = 1616329832 % num;
							object obj2 = intPtr;
							num = 2051763294 + num;
							array2[num10] = obj2;
							goto IL_0240;
						}
						int key = num5;
						num -= 2104914014;
						num <<= 28;
						dictionary2[key] = _582960B4;
						num ^= 0xB8FB7FEEu;
					}
					if ((0x638D6493 ^ num) == 0)
					{
						break;
					}
					num -= 368319445;
					int num11 = num5;
					num <<= 14;
					num = 2016827970 / num;
					num ^= 0x58C76B8C;
					object obj3 = _318778F9(_582960B4, parameterType)._0936516D();
					num = (uint)(2099651734 << (int)num);
					array2[num11] = obj3;
					num += 2019117254;
					goto IL_0240;
					IL_0240:
					int num12 = num5;
					num %= 299697367;
					uint num13 = num ^ 0x4466EB3;
					num = 0xAE75173 & num;
					num5 = num12 - (int)num13;
					num ^= 0x514011CE;
					break;
				}
			}
			num = 691817478 + num;
			object _52BC02CD = ((ConstructorInfo)methodBase2).Invoke(array2);
			num += 1114391077;
			Dictionary<int, _582960B3>.Enumerator enumerator = dictionary2.GetEnumerator();
			num ^= 0x72FB671E;
			Dictionary<int, _582960B3>.Enumerator enumerator2 = enumerator;
			try
			{
				while (true)
				{
					bool num14 = enumerator2.MoveNext();
					num |= 0x14067DC5;
					if (num14)
					{
						num = 2002483333u;
						KeyValuePair<int, _582960B3> current = enumerator2.Current;
						num <<= 13;
						_582960B3 value = current.Value;
						num = 0x5B5A6645 | num;
						num >>= 28;
						num = 2076578882 % num;
						object _63C = array2[current.Key];
						num = 268063002 * num;
						value._727F3897(_63C);
						num ^= 0x1953E935;
					}
					else if (1253067286 != num)
					{
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
			}
			do
			{
				num = 627442250u;
				_1AF96773 obj4 = _40B8698E;
				num = 1093206455u >> (int)num;
				Type? declaringType = methodBase2.DeclaringType;
				num /= 416309457;
				_582960B3 _5FD = _318778F9(_52BC02CD, declaringType);
				num >>= 6;
				obj4._20DB4AD4(_5FD);
			}
			while (num == 2075603973);
		}
		finally
		{
			_4E2E44B7.Dispose();
		}
	}

	private void _32565EA6()
	{
		uint num = 1658283782u;
		int _52213A = _381D5F4F._435152A1();
		num = 0x4B995E2F & num;
		Type type = _4B341A98(_52213A);
		num = 1952781614 % num;
		Type elementType = type;
		do
		{
			_1AF96773 obj = _40B8698E;
			num = (uint)(206461402 << (int)num);
			num |= 0x25EB15B5;
			obj._20DB4AD4(new _28B24C0E(Array.CreateInstance(elementType, _40B8698E._170D7B68()._6AAF062D())));
		}
		while (2092977801 < num);
	}

	private void _446A73F3()
	{
		_6D2115ED obj = _381D5F4F;
		uint num = 1356088436u;
		int _52213A = obj._435152A1();
		num = 0x9BE7ED3 | num;
		Type type = _4B341A98(_52213A);
		num = 1724150938u >> (int)num;
		Type _37AC2BCF = type;
		if (num + 512174540 != 0)
		{
			_1AF96773 obj2 = _40B8698E;
			num = (uint)(1550256951 << (int)num);
			_1AF96773 obj3 = _40B8698E;
			num = (uint)(2025222293 << (int)num);
			object _52BC02CD = obj3._170D7B68()._0936516D();
			num >>= 13;
			_582960B3 _5FD = _318778F9(_52BC02CD, _37AC2BCF);
			num = 121441213 - num;
			obj2._20DB4AD4(_5FD);
		}
	}

	private void _2008142B()
	{
		uint num = 1843136154u;
		while (true)
		{
			num = 0x2E1D4EDF ^ num;
			_1AF96773 obj = _40B8698E;
			num = 0x5CF509B8 & num;
			_582960B3 _582960B4 = obj._170D7B68();
			num = 0x7109579F | num;
			while (true)
			{
				_1AF96773 obj2 = _40B8698E;
				num >>= 12;
				_582960B3 _582960B5 = obj2._170D7B68();
				TypeCode typeCode = _582960B5._09A801C9();
				num %= 1542128301;
				if (num == 1585998996)
				{
					break;
				}
				num *= 1956070120;
				if (typeCode != (TypeCode)(num - 1001607423))
				{
					num |= 0x38B56A00;
					if ((num ^ 0xDF95073) == 0)
					{
						continue;
					}
					uint num2 = num ^ 0x3BB77B03;
					num = 95820687 / num;
					if (typeCode != (TypeCode)num2)
					{
						if (1475946702 == num)
						{
							break;
						}
						throw new InvalidOperationException();
					}
					num *= 759843622;
					if ((0xA7C1F96 ^ num) == 0)
					{
						break;
					}
					num = 613289668 * num;
					_1AF96773 obj3 = _40B8698E;
					num = 610280286 - num;
					obj3._20DB4AD4(_66FF619D._5EA561DC(_582960B5, _582960B4));
					return;
				}
				num >>= 4;
				_1AF96773 obj4 = _40B8698E;
				num = 1468084986 % num;
				obj4._20DB4AD4(_50424ADC._42BB5CB8(_582960B5, _582960B4));
				if (1806111603 <= num)
				{
					break;
				}
				return;
			}
		}
	}

	private void _154C653A()
	{
		uint num = 728658349u;
		do
		{
			_40B8698E._170D7B68();
		}
		while (num - 1500014517 == 0);
	}

	private bool _77AD0510(MethodBase _31536C6D, object _43DB2052, ref object _2BDA0AE6, object[] _7B840856)
	{
		uint num = 71853284u;
		Type declaringType = _31536C6D.DeclaringType;
		num = 1812999976 / num;
		while (true)
		{
			num = 0x59990850 ^ num;
			if (declaringType == null)
			{
				break;
			}
			while (true)
			{
				num = 0x4A7E67BD | num;
				Type? underlyingType = Nullable.GetUnderlyingType(declaringType);
				num = 806824883 - num;
				bool num2 = underlyingType != null;
				num *= 550841394;
				if (num2)
				{
					num = 0x2AF85C56 | num;
					string name = _31536C6D.Name;
					num |= 0x76231A76;
					num >>= 15;
					bool num3 = string.Equals(name, "get_HasValue", (StringComparison)(num ^ 0xFFF3));
					num >>= 18;
					if (num3)
					{
						num ^= 0x706D1AF9;
						object obj = _43DB2052;
						num = 0x6197FC1 & num;
						bool num4 = Unsafe.As<object, UIntPtr>(ref obj) > Unsafe.As<@null, UIntPtr>(ref null);
						num = 752185535 - num;
						object obj2 = num4;
						num += 544156984;
						_2BDA0AE6 = obj2;
						num = 0x44DD49CB & num;
						return (byte)(num - 1142489345) != 0;
					}
					if (num * 94403060 != 0)
					{
						break;
					}
					string name2 = _31536C6D.Name;
					num = 644632605 + num;
					uint comparisonType = num - 644632601;
					num &= 0x291A2F95;
					if (string.Equals(name2, "get_Value", (StringComparison)comparisonType))
					{
						if (num != 505156856)
						{
							if (_43DB2052 == null)
							{
								num <<= 10;
								throw new InvalidOperationException();
							}
							if ((0x28356F66 ^ num) == 0)
							{
								break;
							}
							_2BDA0AE6 = _43DB2052;
							num %= 895499930;
							return (byte)(num ^ 0x20080014) != 0;
						}
						continue;
					}
					num |= 0x2AA67DF6;
					string name3 = _31536C6D.Name;
					num ^= 0x782B2F5C;
					num = 0x5DF5455A | num;
					bool num5 = name3.Equals("GetValueOrDefault", (StringComparison)(num ^ 0x5FF557FF));
					num ^= 0x30A6A677;
					if (num5)
					{
						if (_43DB2052 == null)
						{
							num = 1830365079 / num;
							if (1342849082 <= num)
							{
								break;
							}
							Type? declaringType2 = _31536C6D.DeclaringType;
							num = 0x324E2917 ^ num;
							_43DB2052 = Activator.CreateInstance(Nullable.GetUnderlyingType(declaringType2));
							num += 1023789173;
						}
						num = (uint)(2002156688 << (int)num);
						num = (uint)(2138862950 << (int)num);
						object obj3 = _43DB2052;
						num = 1756635337u >> (int)num;
						_2BDA0AE6 = obj3;
						return (byte)(num ^ 0x1A2D082) != 0;
					}
				}
				return (byte)(num - 1867772300) != 0;
			}
		}
		num = 852315487 * num;
		return (byte)(num ^ 0x2BBD0817) != 0;
	}

	private void _6C632EE4()
	{
		uint num = 1711960954u;
		num = 1505915843 - num;
		_6D2115ED obj = _381D5F4F;
		num -= 626228754;
		string _618A179B = _67444B0A(obj._435152A1());
		do
		{
			_40B8698E._20DB4AD4(new _0BD93DAD(_618A179B));
		}
		while ((num & 0x1F362E1C) == 0);
	}

	public object _4927337F(object[] _6E0D5FD7, int _0B5B0913)
	{
		uint num = 700919066u;
		if (326515704 <= num)
		{
			do
			{
				_381D5F4F._0C3C7D51(_0B5B0913);
			}
			while (822289897 == num);
		}
		num = 531896411 + num;
		_1AF96773 obj = _40B8698E;
		num -= 1418205691;
		num = 1076255730u >> (int)num;
		_28B24C0E _5FD = new _28B24C0E(_6E0D5FD7);
		num *= 587538779;
		obj._20DB4AD4(_5FD);
		object result;
		try
		{
			while (true)
			{
				num = 506420116u;
				try
				{
					num += 920453749;
					while (true)
					{
						num *= 2041992786;
						Dictionary<uint, _19C46BFE> dictionary = _37ED57E7;
						num <<= 25;
						num = 0x763B7DCD ^ num;
						dictionary[_381D5F4F._0F9F2D0A()]();
						num |= 0x463120AD;
						while (true)
						{
							if (_381D5F4F._77F36CDA() == 0)
							{
								if (1841576789 > num)
								{
									break;
								}
								goto end_IL_005f;
							}
							if (num >= 222975486)
							{
								goto end_IL_006e;
							}
						}
						continue;
						end_IL_006e:
						break;
					}
				}
				catch (Exception ex)
				{
					do
					{
						num = 838619815u;
						_5C0E71F4 obj2 = _06733F26;
						num = 0x70DF24F4 | num;
						if (obj2 == null)
						{
							num ^= 0x78E267F3;
							num %= 745691563;
							_459D7272 = ex;
							num += 1759667699;
						}
					}
					while ((num & 0x1DD60CC8) == 0);
					num = 1277641429u >> (int)num;
					_643B05B5();
				}
				continue;
				end_IL_005f:
				break;
			}
			num = 66411151u;
			_582960B3 obj3 = _40B8698E._170D7B68();
			num = 0x3CA33422 ^ num;
			object obj4 = obj3._0936516D();
			num = 156255610 - num;
			result = obj4;
		}
		finally
		{
			List<IntPtr> list = _0E4305CB;
			num = 557467513u;
			List<IntPtr>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				if (1779986607 / num != 0)
				{
					while (true)
					{
						num ^= 0xAEB1ECB;
						num >>= 26;
						if (enumerator.MoveNext())
						{
							IntPtr current = enumerator.Current;
							num = 1626482199u;
							Marshal.FreeHGlobal(current);
							num ^= 0x41C8616E;
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				num = 1177167449u;
				((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
			}
			do
			{
				List<IntPtr> list2 = _0E4305CB;
				num = 291142030u;
				list2.Clear();
			}
			while (1369203247 == num);
		}
		num = 347473067u;
		return result;
	}

	private void _6DC22504()
	{
		while (true)
		{
			uint num = 1872780473u;
			_1AF96773 obj = _40B8698E;
			num %= 1246891713;
			_582960B3 _582960B4 = obj._170D7B68();
			while (true)
			{
				IL_001a:
				_1AF96773 obj2 = _40B8698E;
				num += 1204236106;
				_582960B3 _582960B5 = obj2._170D7B68();
				num = 206717931 + num;
				while (true)
				{
					byte num2 = _381D5F4F._0F9F2D0A();
					num = 0x64B75187 ^ num;
					uint num3 = num ^ 0x1DD090AB;
					num &= 0x16EE3310;
					uint num4 = num2 & num3;
					num %= 1460690122;
					bool flag = num4 > (num ^ 0x14C01000);
					if (num / 1654921833 != 0)
					{
						break;
					}
					TypeCode typeCode = _582960B5._09A801C9();
					num %= 913865338;
					if (typeCode != (TypeCode)(num ^ 0x14C01009))
					{
						if ((0x485E14B3 ^ num) != 0)
						{
							uint num5 = num ^ 0x14C0100B;
							num = 803809759 * num;
							if (typeCode == (TypeCode)num5)
							{
								if (251741837 + num != 0)
								{
									num >>= 23;
									_1AF96773 obj3 = _40B8698E;
									num = 811402628 + num;
									num |= 0x5CB332B5;
									num = 0x280C1B4F ^ num;
									obj3._20DB4AD4(_66FF619D._3B3E58BA(_582960B5, _582960B4, flag));
									if (647118951 * num == 0)
									{
										break;
									}
									return;
								}
								continue;
							}
							throw new InvalidOperationException();
						}
					}
					else
					{
						num += 1033916351;
						if (num - 2090229361 != 0)
						{
							num >>= 2;
							_1AF96773 obj4 = _40B8698E;
							num = 921190497 - num;
							num <<= 20;
							num /= 1997942797;
							num /= 1816411924;
							obj4._20DB4AD4(_50424ADC._12535A29(_582960B5, _582960B4, flag));
							if ((0x27251ABA ^ num) != 0)
							{
								return;
							}
						}
					}
					goto IL_001a;
				}
				break;
			}
		}
	}

	private void _174859CF()
	{
		uint num = 1598427541u;
		_1AF96773 obj = _40B8698E;
		num ^= 0xA556BD3;
		_77315431 _5FD = new _77315431(_381D5F4F._53AB0A6E());
		num >>= 19;
		obj._20DB4AD4(_5FD);
	}

	private void _61F0475A()
	{
		uint num = 541732523u;
		do
		{
			int _7F5B64AB = _381D5F4F._435152A1();
			num = 696866057 / num;
			MethodBase methodBase = _37690AA7(_7F5B64AB);
			num = 0x69D646DD | num;
			MethodBase _36B7196A = methodBase;
			num |= 0x46D0DA1;
			_1AF96773 obj = _40B8698E;
			num &= 0x4E770A8C;
			_4C96047E _5FD = new _4C96047E(_36B7196A);
			num = 1834234249u >> (int)num;
			obj._20DB4AD4(_5FD);
		}
		while (1128926345 == num);
	}

	private void _16E87D4E()
	{
		uint num = 1697527461u;
		_582960B3 _582960B4 = default(_582960B3);
		if (2061385784 / num != 0)
		{
			do
			{
				num = 0xBE70DAC & num;
				_582960B4 = _40B8698E._170D7B68();
			}
			while (num << 4 == 0);
		}
		num = 1079721955 % num;
		_582960B3 obj = _40B8698E._170D7B68();
		num /= 1605657670;
		_582960B3 _52BC02CD = obj;
		_582960B3 obj2 = _582960B4;
		num -= 2047963704;
		num %= 243477261;
		num |= 0x3BCE580E;
		_582960B3 obj3 = _318778F9(_52BC02CD, _582960B4._71C820E4());
		num = 398215362 * num;
		object _63C = obj3._0936516D();
		num %= 766660293;
		obj2._727F3897(_63C);
	}

	private void _0D9A0A2F()
	{
		uint num = 1161918212u;
		object obj2 = default(object);
		while (true)
		{
			int _52213A = _381D5F4F._435152A1();
			num = (uint)(1857628629 << (int)num);
			Type type = _4B341A98(_52213A);
			if (num > 1112553747)
			{
				goto IL_0031;
			}
			goto IL_0052;
			IL_0052:
			while (true)
			{
				object obj = obj2;
				num = 0x3A4D0431 | num;
				if (obj != null)
				{
					num = 0x225C5833 & num;
					if (type.IsValueType)
					{
						num = 399139498 / num;
						object obj3 = obj2;
						num &= 0x12CF1442;
						if (type != obj3.GetType())
						{
							if (64302367 > num)
							{
								throw new InvalidCastException();
							}
							continue;
						}
						num &= 0x2E361C33;
						_1AF96773 obj4 = _40B8698E;
						num = 0xEE86EC5 ^ num;
						_582960B3 _5FD = _318778F9(obj2, type);
						num += 2061439509;
						obj4._20DB4AD4(_5FD);
						return;
					}
					num &= 0x68091F2E;
					if (num > 699084471)
					{
						break;
					}
					TypeCode typeCode = Type.GetTypeCode(type);
					if (1373123259u >> (int)num != 0)
					{
						uint num2 = num ^ 0x20081023;
						num = 1165115427 / num;
						switch ((int)typeCode - (int)num2)
						{
						case 0:
							num = 0x345F4866 | num;
							_40B8698E._20DB4AD4(new _488D2F82((bool)obj2));
							return;
						case 1:
						{
							num = 1392261188 - num;
							_1AF96773 obj5 = _40B8698E;
							num = (uint)(1849167720 << (int)num);
							object obj6 = obj2;
							num = 1645491730 - num;
							char _65AE5CD = (char)obj6;
							num = 259271696 - num;
							obj5._20DB4AD4(new _19B932DA(_65AE5CD));
							return;
						}
						case 2:
							goto IL_01b5;
						case 3:
							num &= 0x7BAF6C2D;
							_40B8698E._20DB4AD4(new _48772BCF((byte)obj2));
							return;
						case 4:
							goto IL_0212;
						case 5:
							goto IL_0244;
						case 6:
							goto IL_0293;
						case 7:
							goto IL_02c5;
						case 8:
							goto IL_02ff;
						case 9:
							goto IL_0347;
						case 10:
							goto IL_0381;
						case 11:
							goto IL_03c3;
						}
						if (2066231211 < num || 1195654507 - num == 0)
						{
							break;
						}
						throw new InvalidCastException();
					}
					goto IL_0031;
				}
				goto IL_0060;
				IL_0381:
				_1AF96773 obj7 = _40B8698E;
				num = 1486954121 - num;
				object obj8 = obj2;
				num = 1157513451 + num;
				float _3A4B = (float)obj8;
				num += 2067877856;
				_5A103814 _5FD2 = new _5A103814(_3A4B);
				num = 0x437C01B4 & num;
				obj7._20DB4AD4(_5FD2);
				if (num != 1626939783)
				{
					return;
				}
				continue;
				IL_0347:
				num = 1566187706 + num;
				_1AF96773 obj9 = _40B8698E;
				object obj10 = obj2;
				num = 0x25592882 & num;
				_482E45FB _5FD3 = new _482E45FB((ulong)obj10);
				num = 294521747 * num;
				obj9._20DB4AD4(_5FD3);
				if (352990204 < num)
				{
					return;
				}
				goto IL_0031;
				IL_01b5:
				if (num >= 2041919288)
				{
					break;
				}
				_1AF96773 obj11 = _40B8698E;
				num = 0x1B7F4CB1 | num;
				_1CE22CD9 _5FD4 = new _1CE22CD9((sbyte)obj2);
				num /= 486754381;
				obj11._20DB4AD4(_5FD4);
				if (1913548115 * num != 0)
				{
					break;
				}
				return;
				IL_0244:
				if ((num ^ 0x283E1A30) == 0)
				{
					break;
				}
				_1AF96773 obj12 = _40B8698E;
				num = 221257206 * num;
				object obj13 = obj2;
				num += 657143497;
				ushort _787C = (ushort)obj13;
				num = 860754438 / num;
				_05FE464D _5FD5 = new _05FE464D(_787C);
				num /= 730666069;
				obj12._20DB4AD4(_5FD5);
				if ((num & 0xD9E1E3B) != 0)
				{
					break;
				}
				return;
				IL_02c5:
				num = 0x285913AE | num;
				if (28258248 == num)
				{
					break;
				}
				_1AF96773 obj14 = _40B8698E;
				object obj15 = obj2;
				num -= 1133463916;
				_39EC73F4 _5FD6 = new _39EC73F4((uint)obj15);
				num <<= 27;
				obj14._20DB4AD4(_5FD6);
				return;
				IL_02ff:
				if (num >= 657391826)
				{
					break;
				}
				num = (uint)(369183540 << (int)num);
				_1AF96773 obj16 = _40B8698E;
				num %= 871916740;
				object obj17 = obj2;
				num ^= 0x4F3A53C6;
				long _52CC445F = (long)obj17;
				num &= 0x6BB01502;
				obj16._20DB4AD4(new _66FF619D(_52CC445F));
				return;
				IL_0293:
				num = 2029870666 + num;
				if (num >= 1248005663)
				{
					_1AF96773 obj18 = _40B8698E;
					object obj19 = obj2;
					num <<= 10;
					obj18._20DB4AD4(new _50424ADC((int)obj19));
					return;
				}
				goto IL_0060;
				IL_0060:
				throw new NullReferenceException();
				IL_03c3:
				if (num != 747919940)
				{
					_1AF96773 obj20 = _40B8698E;
					double _5FD7 = (double)obj2;
					num = 1230915484u >> (int)num;
					obj20._20DB4AD4(new _77315431(_5FD7));
					return;
				}
				continue;
				IL_0212:
				_1AF96773 obj21 = _40B8698E;
				num = 1240930162 % num;
				_4F3F00F5 _5FD8 = new _4F3F00F5((short)obj2);
				num >>= 21;
				obj21._20DB4AD4(_5FD8);
				if (num == 2128349952)
				{
					break;
				}
				return;
			}
			continue;
			IL_0031:
			_1AF96773 obj22 = _40B8698E;
			num /= 1832929270;
			object obj23 = obj22._170D7B68()._0936516D();
			num -= 397955022;
			obj2 = obj23;
			goto IL_0052;
		}
	}

	private void _64351E3E()
	{
		uint num = 1968985381u;
		if (1956332379 < num)
		{
			goto IL_0011;
		}
		goto IL_0026;
		IL_0011:
		num = 17917630 - num;
		int num2 = _381D5F4F._435152A1();
		goto IL_0026;
		IL_0026:
		while (true)
		{
			IL_0026_2:
			num = 0x34BE657B & num;
			_6D2115ED obj = _381D5F4F;
			num *= 1663064709;
			_582960B3 obj2 = _40B8698E._170D7B68();
			num /= 1193495382;
			int _4F437089 = obj2._6AAF062D();
			num -= 1265190444;
			obj._771E25CB(_4F437089);
			num &= 0x7FFE31EA;
			List<int> list = new List<int>();
			num *= 215904029;
			List<int> list2 = list;
			while (true)
			{
				_38797DE2 obj3 = _2D282653;
				num = 1777343940 * num;
				int num3 = obj3._346D2CCE();
				num -= 23139909;
				if (num3 != 0)
				{
					if (num < 1928687753)
					{
						break;
					}
					int num4 = num2;
					_58BB531E obj4 = _2D282653._5090100A();
					num = 952662343 % num;
					if (num4 > obj4._423815D3())
					{
						num = 366823098u;
						num *= 1198589954;
						List<_5C0E71F4> list3 = _2D282653._1D0C709F()._38207DE6();
						num <<= 24;
						List<_5C0E71F4> list4 = list3;
						uint num5 = num - 1946157056;
						num |= 0x525B12D0;
						int num6 = (int)num5;
						while (true)
						{
							num %= 1015242681;
							int num7 = num6;
							num = 927489713 % num;
							if (num7 >= list4.Count)
							{
								break;
							}
							num = 345126146u;
							if (num == 1293181044)
							{
								goto end_IL_0166;
							}
							_5C0E71F4 _5C0E71F5 = list4[num6];
							byte num8 = _5C0E71F5._50C7492B();
							int num9 = (int)num + -345126144;
							num >>= 20;
							if (num8 == num9)
							{
								num = 0x74CF179A | num;
								num = 2009938878 - num;
								list2.Add(_5C0E71F5._12B955CD());
								num += 4244757862u;
							}
							if (1587623476 + num == 0)
							{
								goto end_IL_0166;
							}
							int num10 = num6;
							uint num11 = num ^ 0x148;
							num /= 953095295;
							int num12 = num10 + (int)num11;
							num = 831522471 + num;
							num6 = num12;
							num ^= 0x47CB1477;
						}
						num += 30245903;
						continue;
					}
					num += 1229441908;
				}
				if (num == 81985943)
				{
					break;
				}
				goto IL_01c3;
				continue;
				end_IL_0166:
				break;
			}
			break;
			IL_01c3:
			int count = list2.Count;
			num = 1231949610 - num;
			int num13 = count;
			while (true)
			{
				num = (uint)(1582714286 << (int)num);
				if (num - 1509646830 == 0)
				{
					break;
				}
				int num14 = num13;
				num = 0x4A947588 & num;
				if (num14 > (int)num + -43253760)
				{
					num = 1487167933u;
					if ((num ^ 0x53550F3) == 0)
					{
						goto IL_0026_2;
					}
					num <<= 12;
					_6D2115ED obj5 = _381D5F4F;
					int num15 = num13;
					num = 398992756 % num;
					int num16 = (int)num + -398992755;
					num ^= 0x64864E4D;
					int index = num15 - num16;
					num = 0xEE832C0 ^ num;
					obj5._771E25CB(list2[index]);
					num = 0x7D237FB4 & num;
					if ((num & 0x8073719) == 0)
					{
						break;
					}
					int num17 = num13;
					uint num18 = num - 2099403183;
					num %= 1243576185;
					num13 = num17 - (int)num18;
					num ^= 0xF45F2858u;
					continue;
				}
				num >>= 23;
				num |= 0x3E776A8D;
				_459D7272 = null;
				num = 1582647141 + num;
				_1AF96773 obj6 = _40B8698E;
				num = 0x79107C0C | num;
				obj6._3AD67507();
				num = 0x555B46BB & num;
				num = 109522332 - num;
				_6D2115ED obj7 = _381D5F4F;
				num -= 1077415490;
				obj7._55863A4A();
				return;
			}
			break;
		}
		goto IL_0011;
	}

	private void _31842681()
	{
		while (true)
		{
			_1AF96773 obj = _40B8698E;
			uint num = 643964254u;
			int num2 = obj._170D7B68()._6AAF062D();
			num = (uint)(383737818 << (int)num);
			if (num2 == 0)
			{
				num %= 27616300;
				_643B05B5();
				if (num < 1758016455)
				{
					break;
				}
			}
			_2D282653._1D0C709F();
			num *= 816736163;
			if (839927156 * num == 0)
			{
				_1AF96773 obj2 = _40B8698E;
				num = 1779500890 / num;
				_2CEE4B34 _5FD = new _2CEE4B34(_459D7272);
				num = 0x73BB2D5D | num;
				obj2._20DB4AD4(_5FD);
				num -= 1492986985;
				num %= 1668682214;
				_6D2115ED obj3 = _381D5F4F;
				num = 0x7FBB5891 & num;
				_5C0E71F4 obj4 = _06733F26;
				num -= 1353415663;
				obj3._0C3C7D51(obj4._12B955CD());
				num -= 1070017411;
				_06733F26 = null;
				break;
			}
		}
	}

	private void _224B291D()
	{
		uint num;
		do
		{
			int _52213A = _381D5F4F._435152A1();
			num = 1476075923u;
			Type type = _4B341A98(_52213A);
			num &= 0x7D755855;
			Type _37AC2BCF = type;
			_1AF96773 obj = _40B8698E;
			num /= 239938511;
			num = 882729456 / num;
			num = 468344816u >> (int)num;
			_1AF96773 obj2 = _40B8698E;
			num ^= 0x45571AE2;
			_582960B3 _52BC02CD = obj2._170D7B68();
			num = 88168032 % num;
			_582960B3 _5FD = _318778F9(_52BC02CD, _37AC2BCF);
			num = 1555176013 + num;
			obj._20DB4AD4(_5FD);
		}
		while (762974056 << (int)num == 0);
	}

	private _0D4C6B37 _46C53560(int _465105DA)
	{
		Dictionary<int, object> dictionary = _000A3090;
		uint num = 1722039625u;
		Dictionary<int, object> obj = dictionary;
		num = 1968708974 - num;
		bool lockTaken = (byte)(num ^ 0xEB3E025) != 0;
		_0D4C6B37 result;
		try
		{
			num /= 27358320;
			int num2 = default(int);
			byte[] array2 = default(byte[]);
			_0D4C6B37 _0D4C6B38 = default(_0D4C6B37);
			do
			{
				Monitor.Enter(obj, ref lockTaken);
				if (835857188 >= num)
				{
					goto IL_003f;
				}
				goto IL_0054;
				IL_0054:
				Dictionary<int, object> dictionary2 = _000A3090;
				num %= 1371742453;
				int key = num2;
				num %= 2111574527;
				num = 0x7F2439A0 & num;
				if (dictionary2.TryGetValue(key, out var value))
				{
					num += 1437560759;
				}
				else
				{
					num %= 242230268;
					if (1874867624 != num)
					{
						Module module = _16B6617B;
						num >>= 30;
						byte[] array = module.ResolveSignature(_465105DA);
						num %= 1509375421;
						array2 = array;
						_0D4C6B38 = new _0D4C6B37();
						num %= 1231255908;
						if ((num ^ 0x3B0F1303) == 0)
						{
							goto IL_003f;
						}
					}
					_0D4C6B37 obj2 = _0D4C6B38;
					byte[] _34756DF = array2;
					num = 1130196445 + num;
					obj2._11100F8E(_34756DF, _16B6617B);
					num = 679020444 * num;
					if (1515084509 >= num)
					{
						_000A3090.Add(num2, _0D4C6B38);
						num <<= 18;
						_0D4C6B37 obj3 = _0D4C6B38;
						num = (uint)(1278674810 << (int)num);
						result = obj3;
						break;
					}
				}
				object obj4 = value;
				num /= 7430915;
				_0D4C6B37 obj5 = (_0D4C6B37)obj4;
				num ^= 0x501A2F51;
				result = obj5;
				continue;
				IL_003f:
				int num3 = _465105DA | (int)(num + 1073741815);
				num /= 755975153;
				num2 = num3;
				goto IL_0054;
			}
			while (836841781 * num == 0);
		}
		finally
		{
			do
			{
				bool num4 = lockTaken;
				num = 1257193008u;
				if (num4)
				{
					num = 1572483264 / num;
					Monitor.Exit(obj);
					num += 1257193007;
				}
			}
			while (num * 1139887028 == 0);
		}
		return result;
	}

	private void _39050D2A()
	{
		uint num = 1504719201u;
		Type _37AC2BCF = default(Type);
		if (915544244 <= num)
		{
			num >>= 30;
			_6D2115ED obj = _381D5F4F;
			num = 1781530784u >> (int)num;
			int _52213A = obj._435152A1();
			num %= 544416722;
			Type type = _4B341A98(_52213A);
			num *= 1086284586;
			_37AC2BCF = type;
			num <<= 20;
		}
		_1AF96773 obj2 = _40B8698E;
		_1AF96773 obj3 = _40B8698E;
		num = 2047483830 * num;
		object _3CE71D = _318778F9(obj3._170D7B68(), _37AC2BCF)._0936516D();
		num <<= 10;
		obj2._20DB4AD4(new _2CEE4B34(_3CE71D));
	}

	private Type _4B341A98(int _52213A96)
	{
		uint num = 88547184u;
		Dictionary<int, object> dictionary = _000A3090;
		num = 0x28D064BB | num;
		Dictionary<int, object> obj = dictionary;
		num = 677199215 * num;
		bool lockTaken = (byte)(num ^ 0xF01E4CD5u) != 0;
		Type result;
		try
		{
			object value = default(object);
			while (true)
			{
				num = 604793158 % num;
				Monitor.Enter(obj, ref lockTaken);
				if (num >= 270095441)
				{
					Dictionary<int, object> dictionary2 = _000A3090;
					num = 1153368733u >> (int)num;
					num = 753168851 * num;
					if (!dictionary2.TryGetValue(_52213A96, out value))
					{
						num = 1309103665 + num;
						Module module = _16B6617B;
						num *= 1390423626;
						Type type = module.ResolveType(_52213A96);
						num = 1764448502 + num;
						if ((num ^ 0x54B86013) != 0)
						{
							Dictionary<int, object> dictionary3 = _000A3090;
							num %= 1997145060;
							dictionary3.Add(_52213A96, type);
							result = type;
							if (num >> 9 != 0)
							{
								break;
							}
						}
						continue;
					}
				}
				do
				{
					Type obj2 = (Type)value;
					num |= 0x47936F22;
					result = obj2;
				}
				while (num < 1710958510);
				break;
			}
		}
		finally
		{
			num = 1727602490u;
			if ((num ^ 0xE6A4B91) == 0)
			{
				goto IL_0100;
			}
			bool num2 = lockTaken;
			num = 1460488847 - num;
			if (num2)
			{
				goto IL_0100;
			}
			goto end_IL_00e0;
			IL_0100:
			Monitor.Exit(obj);
			num ^= 0;
			end_IL_00e0:;
		}
		return result;
	}

	private void _25121C24()
	{
		Type type2 = default(Type);
		while (true)
		{
			uint num = 1359680821u;
			_6D2115ED obj = _381D5F4F;
			num = 0x2E164307 & num;
			short _42A95CF = obj._4B03768E();
			if (115961842 + num != 0)
			{
				do
				{
					num >>= 24;
					_1AF96773 obj2 = _40B8698E;
					num <<= 31;
					int _52213A = obj2._170D7B68()._6AAF062D();
					num >>= 25;
					Type type = _4B341A98(_52213A);
					num &= 0x74CE7EBE;
					type2 = type;
					num /= 1398480485;
				}
				while (num * 1784480617 != 0);
			}
			_582960B3 _582960B4 = _40B8698E._170D7B68();
			num = 0x11813B96 & num;
			num += 1853424333;
			_1AF96773 obj3 = _40B8698E;
			num %= 430864192;
			_582960B3 _582960B5 = obj3._170D7B68();
			if (num > 1147749464)
			{
				continue;
			}
			while (true)
			{
				num ^= 0x21056F9;
				if (_582960B4._11EF2F40())
				{
					if ((num & 0x11F22170) == 0)
					{
						break;
					}
					_582960B3 obj4 = _582960B5;
					num *= 1195850254;
					object _52BC02CD = obj4._0936516D();
					Type _37AC2BCF = type2;
					num <<= 9;
					_582960B3 _664F7AFF = _318778F9(_52BC02CD, _37AC2BCF);
					num = (uint)(409807575 << (int)num);
					num = 118833181 - num;
					_582960B5 = new _47F23E32(_664F7AFF, _582960B4);
				}
				else
				{
					if (1098873247 / num == 0)
					{
						continue;
					}
					_582960B3 obj5 = _318778F9(_582960B5._0936516D(), type2);
					num = 758670328 - num;
					_582960B5 = obj5;
					num ^= 0xC920E582u;
				}
				if (1086528369 == num)
				{
					break;
				}
				num *= 1379550346;
				_1AF96773 obj6 = _40B8698E;
				num ^= 0x6FA234CE;
				obj6._3CF40F6B(_42A95CF, _582960B5);
				num = 681064770 + num;
				if (1453011270 != num)
				{
					return;
				}
			}
		}
	}

	private void _321E0290()
	{
		uint num = 2072395233u;
		if ((num ^ 0x129D688F) != 0)
		{
			goto IL_0012;
		}
		goto IL_0031;
		IL_0012:
		byte b = default(byte);
		do
		{
			b = _381D5F4F._0F9F2D0A();
			num = 0x5E1D1DAD | num;
		}
		while (447104031 >= num);
		goto IL_0031;
		IL_0031:
		num %= 1676629659;
		_6D2115ED obj = _381D5F4F;
		num |= 0x708C318D;
		int _1E6A67B = obj._435152A1();
		_6D2115ED obj2 = _381D5F4F;
		num = 0x451B4977 & num;
		int num2 = obj2._435152A1();
		num = (uint)(360152640 << (int)num);
		int _1DCD = num2;
		num = 0x317939AD | num;
		if ((0x2AE336F8 ^ num) != 0)
		{
			int _1B9E21E = _381D5F4F._435152A1();
			num = 676283833 * num;
			if (367016173 != num)
			{
				_6D2115ED obj3 = _381D5F4F;
				num <<= 23;
				int _3B5013C = obj3._435152A1();
				num = 660423060 - num;
				_38797DE2 obj4 = _2D282653;
				num = 299589146u >> (int)num;
				byte _38B9397E = b;
				num = 422394502 / num;
				num = 1461550731 * num;
				obj4._2F4D0B82(_1E6A67B, _1DCD, _38B9397E, _1B9E21E, _3B5013C);
				if (num >> 2 != 0)
				{
					return;
				}
			}
		}
		goto IL_0012;
	}

	private void _0E4B1755()
	{
		while (true)
		{
			uint num = 263263781u;
			_582960B3 obj = _40B8698E._170D7B68();
			num = 87382112u >> (int)num;
			_582960B3 _582960B4 = obj;
			num = 0x5F946A20 | num;
			if (num <= 1141974813)
			{
				continue;
			}
			while (true)
			{
				num += 1291744931;
				_582960B3 obj2 = _40B8698E._170D7B68();
				num ^= 0x74552B6E;
				_582960B3 _582960B5 = obj2;
				num = 0x6D702610 ^ num;
				if (134764188 << (int)num == 0)
				{
					continue;
				}
				while (true)
				{
					num = 2027171227 * num;
					TypeCode typeCode = _7B624F6F(_582960B5, _582960B4);
					uint num2 = num ^ 0x696C9221;
					num %= 989675582;
					if (typeCode == (TypeCode)num2)
					{
						break;
					}
					if ((0x2D94B01 ^ num) == 0)
					{
						goto end_IL_0033;
					}
					uint num3 = num ^ 0x2E6F51E1;
					num = 1063595098 * num;
					if (typeCode != (TypeCode)num3)
					{
						if (112751960 - num == 0)
						{
							goto end_IL_0033;
						}
						if (num < 2071753222)
						{
							throw new InvalidOperationException();
						}
						continue;
					}
					num = 1673469427u >> (int)num;
					_1AF96773 obj3 = _40B8698E;
					_582960B3 _5FD = _66FF619D._18B551FE(_582960B5, _582960B4);
					num *= 367613797;
					obj3._20DB4AD4(_5FD);
					return;
				}
				if (2110132703 > num)
				{
					num <<= 4;
					_1AF96773 obj4 = _40B8698E;
					num = 384634750 - num;
					_582960B3 _5FD2 = _50424ADC._274F64E2(_582960B5, _582960B4);
					num /= 1565797719;
					obj4._20DB4AD4(_5FD2);
					return;
				}
				continue;
				end_IL_0033:
				break;
			}
		}
	}

	public _78492021()
	{
		uint num = 457121400u;
		while (true)
		{
			_37ED57E7 = new Dictionary<uint, _19C46BFE>();
			num = 1118713416 - num;
			if (1537485197 % num == 0)
			{
				continue;
			}
			while (true)
			{
				_6D2115ED obj = new _6D2115ED();
				num = (uint)(781851102 << (int)num);
				_381D5F4F = obj;
				while (true)
				{
					IL_003e:
					num = 223881363 - num;
					_1AF96773 obj2 = new _1AF96773();
					num += 846085550;
					_40B8698E = obj2;
					num |= 0x620A398C;
					if (num == 587020039)
					{
						break;
					}
					while (true)
					{
						IL_006c:
						_38797DE2 obj3 = new _38797DE2();
						num -= 576026977;
						_2D282653 = obj3;
						num |= 0x658B5AD3;
						while (true)
						{
							IL_0087:
							num *= 750263127;
							_0E4305CB = new List<IntPtr>();
							while (true)
							{
								IL_009a:
								num %= 207829899;
								base._002Ector();
								num = 788425259 + num;
								Dictionary<uint, _19C46BFE> dictionary = _37ED57E7;
								num = 487461868 % num;
								uint key = num ^ 0x1D0E13EC;
								num &= 0x39D9496D;
								_19C46BFE value = _748B5AA0;
								num /= 1396247829;
								dictionary[key] = value;
								if ((0x769654A & num) != 0)
								{
									break;
								}
								Dictionary<uint, _19C46BFE> dictionary2 = _37ED57E7;
								num = 0x2D7C5F93 ^ num;
								uint key2 = num - 763125650;
								num <<= 27;
								dictionary2[key2] = _4F1657F9;
								if (num < 235686659)
								{
									break;
								}
								Dictionary<uint, _19C46BFE> dictionary3 = _37ED57E7;
								int key3 = (int)num ^ -1744830462;
								num = 1203852381 / num;
								num *= 665601798;
								num >>= 21;
								_19C46BFE value2 = _61F0475A;
								num = 1581467493 * num;
								dictionary3[(uint)key3] = value2;
								num |= 0xD957825;
								if ((num ^ 0x1697479A) == 0)
								{
									break;
								}
								Dictionary<uint, _19C46BFE> dictionary4 = _37ED57E7;
								num >>= 24;
								int key4 = (int)num + -10;
								num = 588148840 / num;
								num = 122378377 - num;
								dictionary4[(uint)key4] = _0D9A0A2F;
								while (true)
								{
									num *= 1606107652;
									Dictionary<uint, _19C46BFE> dictionary5 = _37ED57E7;
									uint key5 = num + 682425736;
									num &= 0x48C5B6E;
									num = 0x34891E3E ^ num;
									num += 1512270121;
									dictionary5[key5] = _1FC105EF;
									if ((0x59D4534A ^ num) == 0)
									{
										break;
									}
									num &= 0x16ED1439;
									Dictionary<uint, _19C46BFE> dictionary6 = _37ED57E7;
									uint key6 = num ^ 0x2AC043C;
									num = 2037923226 + num;
									num &= 0x69B00C67;
									dictionary6[key6] = _7E6B08A7;
									num = 914454291 * num;
									if (890401918 >= num)
									{
										goto IL_003e;
									}
									num >>= 15;
									Dictionary<uint, _19C46BFE> dictionary7 = _37ED57E7;
									uint key7 = num ^ 0x1BC82;
									num /= 1480007990;
									num &= 0x659E4DEE;
									_19C46BFE value3 = _19AE5B2D;
									num = (uint)(651958152 << (int)num);
									dictionary7[key7] = value3;
									num <<= 1;
									if ((0x11AB73C2 ^ num) == 0)
									{
										break;
									}
									num = (uint)(82404817 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary8 = _37ED57E7;
									uint key8 = num ^ 0x65D10007;
									num += 183330622;
									dictionary8[key8] = _78760B02;
									num = 1940543084 * num;
									if (1521621180 > num)
									{
										goto IL_006c;
									}
									Dictionary<uint, _19C46BFE> dictionary9 = _37ED57E7;
									num %= 1386118374;
									uint key9 = num ^ 0x4AF16854;
									num /= 970593896;
									num += 507130946;
									dictionary9[key9] = _174859CF;
									num = 0x8F3E6C ^ num;
									if (num >> 16 == 0)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary10 = _37ED57E7;
									num = 1204882192 * num;
									uint key10 = num ^ 0xC1FA7F9;
									num -= 1990352363;
									num += 138832660;
									num ^= 0x7B8014BB;
									_19C46BFE value4 = _04D16CFA;
									num = (uint)(1530669218 << (int)num);
									dictionary10[key10] = value4;
									num = 1493635234 + num;
									if (num / 2006012707 == 0)
									{
										goto end_IL_009a;
									}
									num = 0x720F1F46 | num;
									Dictionary<uint, _19C46BFE> dictionary11 = _37ED57E7;
									num ^= 0x544B30CD;
									int key11 = (int)num ^ -1548447831;
									num &= 0x3C42604C;
									num = 719465522u >> (int)num;
									_19C46BFE value5 = _67880719;
									num = (uint)(2104823957 << (int)num);
									dictionary11[(uint)key11] = value5;
									if (num <= 827134545)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary12 = _37ED57E7;
									num = 0x60242C28 & num;
									uint key12 = num ^ 0x4004000B;
									num = 1587048325u >> (int)num;
									num = 750731215 + num;
									_19C46BFE value6 = _381C352C;
									num += 1280777436;
									dictionary12[key12] = value6;
									num = 244269500 + num;
									num *= 1255607458;
									Dictionary<uint, _19C46BFE> dictionary13 = _37ED57E7;
									int key13 = (int)num ^ -2061508780;
									num |= 0x604C63BC;
									num = 1194531894 * num;
									num -= 1487091483;
									dictionary13[(uint)key13] = _4B320761;
									if (1752193504 >= num)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary14 = _37ED57E7;
									uint key14 = num ^ 0x6CD05800;
									num *= 767042814;
									num = 1251437220u >> (int)num;
									_19C46BFE value7 = _64351E3E;
									num &= 0x6ECA0CD5;
									dictionary14[key14] = value7;
									num = 1656243649 + num;
									num -= 710885985;
									Dictionary<uint, _19C46BFE> dictionary15 = _37ED57E7;
									uint key15 = num ^ 0x38630FEE;
									num <<= 11;
									num = 2077098496 + num;
									dictionary15[key15] = _2D70200B;
									num += 1155558693;
									if (num < 1717315721)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary16 = _37ED57E7;
									int key16 = (int)num ^ -651333846;
									num = 0x266230A5 & num;
									num = (uint)(583416544 << (int)num);
									_19C46BFE value8 = _224B291D;
									num = 0x109F4982 ^ num;
									dictionary16[(uint)key16] = value8;
									num = 1992435610 - num;
									if (1359956488 >>> (int)num == 0)
									{
										goto end_IL_009a;
									}
									num = 122775336 - num;
									_37ED57E7[num ^ 0xD8E75500u] = _16E87D4E;
									Dictionary<uint, _19C46BFE> dictionary17 = _37ED57E7;
									num -= 737758622;
									uint key17 = num + 1393686687;
									num *= 274615208;
									num -= 752113364;
									dictionary17[key17] = _753C322B;
									if ((0x5EBB3E2E ^ num) == 0)
									{
										goto IL_006c;
									}
									num -= 1632779236;
									Dictionary<uint, _19C46BFE> dictionary18 = _37ED57E7;
									uint key18 = num + 2045200890;
									num -= 821317289;
									num >>= 13;
									dictionary18[key18] = _348D306A;
									num = 569788159 % num;
									Dictionary<uint, _19C46BFE> dictionary19 = _37ED57E7;
									uint key19 = num - 118083;
									num = 728001530 * num;
									num = 1710303195 + num;
									dictionary19[key19] = _2008142B;
									num %= 179520074;
									if (1286029834 - num == 0)
									{
										goto end_IL_009a;
									}
									num = 1108611466 / num;
									Dictionary<uint, _19C46BFE> dictionary20 = _37ED57E7;
									uint key20 = num ^ 0x19;
									num = 237518364u >> (int)num;
									_19C46BFE value9 = _32565EA6;
									num -= 1294092893;
									dictionary20[key20] = value9;
									num <<= 21;
									num = 1250428912 / num;
									Dictionary<uint, _19C46BFE> dictionary21 = _37ED57E7;
									num = 393417368u >> (int)num;
									uint key21 = num ^ 0x1773128D;
									_19C46BFE value10 = _154C653A;
									num &= 0x38D50D4E;
									dictionary21[key21] = value10;
									num = 0x3761484C | num;
									if (832395322 > num)
									{
										goto IL_003e;
									}
									Dictionary<uint, _19C46BFE> dictionary22 = _37ED57E7;
									uint key22 = num - 930170934;
									num = 833947714 % num;
									dictionary22[key22] = _5B994F51;
									if (1498706823 % num == 0)
									{
										goto IL_006c;
									}
									Dictionary<uint, _19C46BFE> dictionary23 = _37ED57E7;
									uint key23 = num - 833947691;
									num |= 0x20B20468;
									num /= 1032340894;
									num = 0x7F9C0FBF & num;
									_19C46BFE value11 = _2C0F1316;
									num |= 0x6F6733E1;
									dictionary23[key23] = value11;
									if (1163687390 >= num)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary24 = _37ED57E7;
									int key24 = (int)num + -1869034441;
									_19C46BFE value12 = _0DA75EB2;
									num = 522933251 - num;
									dictionary24[(uint)key24] = value12;
									num = 732135247 - num;
									if (796554917 == num)
									{
										goto end_IL_009a;
									}
									num += 1507002860;
									Dictionary<uint, _19C46BFE> dictionary25 = _37ED57E7;
									int key25 = (int)num ^ -709728000;
									num = (uint)(216604677 << (int)num);
									_19C46BFE value13 = _0E4B1755;
									num = 639794396 - num;
									dictionary25[(uint)key25] = value13;
									num |= 0x6748608F;
									Dictionary<uint, _19C46BFE> dictionary26 = _37ED57E7;
									uint key26 = num - 2137685189;
									num += 1702562104;
									num &= 0x7BD056F1;
									dictionary26[key26] = _01BE1822;
									if (908143633 << (int)num == 0)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary27 = _37ED57E7;
									uint key27 = num ^ 0x60C0060A;
									num = 390559806 - num;
									_19C46BFE value14 = _446A73F3;
									num = 0x74DA4603 & num;
									dictionary27[key27] = value14;
									num = 1987994019u >> (int)num;
									Dictionary<uint, _19C46BFE> dictionary28 = _37ED57E7;
									int key28 = (int)num + -993996981;
									num >>= 1;
									_19C46BFE value15 = _56E7079F;
									num = (uint)(1400781870 << (int)num);
									dictionary28[(uint)key28] = value15;
									num -= 744040436;
									Dictionary<uint, _19C46BFE> dictionary29 = _37ED57E7;
									uint key29 = num ^ 0x51E30611;
									_19C46BFE value16 = _1BA85A41;
									num = 1771862754 * num;
									dictionary29[key29] = value16;
									num |= 0x2D6C0E4E;
									Dictionary<uint, _19C46BFE> dictionary30 = _37ED57E7;
									num = 0xFBF3616 & num;
									uint key30 = num ^ 0xFBD0608;
									num *= 159980015;
									num = 0x1A895D7F & num;
									_19C46BFE value17 = _321E0290;
									num = 1013537712 / num;
									dictionary30[key30] = value17;
									num = (uint)(1278683484 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary31 = _37ED57E7;
									uint key31 = num + 2031801503;
									num |= 0x2244772D;
									num ^= 0x2BF94742;
									_19C46BFE value18 = _39050D2A;
									num = 0x4D4B0E88 ^ num;
									dictionary31[key31] = value18;
									num %= 253779147;
									Dictionary<uint, _19C46BFE> dictionary32 = _37ED57E7;
									num = 0x51EA0EF9 | num;
									uint key32 = num - 1543167707;
									num = 1198612520 - num;
									num <<= 18;
									_19C46BFE value19 = _7EA22F58;
									num = 0x7791D2C | num;
									dictionary32[key32] = value19;
									Dictionary<uint, _19C46BFE> dictionary33 = _37ED57E7;
									num = 0x2E7C07A2 | num;
									uint key33 = num ^ 0x2FFD1F8F;
									num = 1690239310 + num;
									dictionary33[key33] = _46E26DC8;
									num = (uint)(1090525353 << (int)num);
									num = (uint)(1426282665 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary34 = _37ED57E7;
									uint key34 = num ^ 0x5503588B;
									num ^= 0x41C06AC2;
									_19C46BFE value20 = _78DA3BAD;
									num %= 1069229230;
									dictionary34[key34] = value20;
									if (num >= 1183915472)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary35 = _37ED57E7;
									num *= 1287282142;
									int key35 = (int)num + -1347721127;
									_19C46BFE value21 = _562978D7;
									num ^= 0x4DF842FE;
									dictionary35[(uint)key35] = value21;
									num = 588989933 * num;
									_37ED57E7[num - 2801034496u] = _28F05C6A;
									if (1838494641 > num)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary36 = _37ED57E7;
									num = 0x44E17D45 | num;
									int key36 = (int)num ^ -420119232;
									_19C46BFE value22 = _6DC22504;
									num |= 0x174913BE;
									dictionary36[(uint)key36] = value22;
									if (num < 1620141331)
									{
										goto end_IL_009a;
									}
									num = 434339776 % num;
									Dictionary<uint, _19C46BFE> dictionary37 = _37ED57E7;
									num |= 0x4B0C4933;
									int key37 = (int)num + -1542422477;
									num ^= 0x279440C3;
									dictionary37[(uint)key37] = _56F74966;
									Dictionary<uint, _19C46BFE> dictionary38 = _37ED57E7;
									uint key38 = num ^ 0x7C7B3F17;
									num = 1818318118 % num;
									dictionary38[key38] = _3C2D1285;
									num = 2041193433 / num;
									if (num >= 1785094533)
									{
										goto IL_003e;
									}
									Dictionary<uint, _19C46BFE> dictionary39 = _37ED57E7;
									uint key39 = num ^ 0x29;
									num %= 195839964;
									num = 1285517025 % num;
									_19C46BFE value23 = _6C632EE4;
									num /= 1132074852;
									dictionary39[key39] = value23;
									num = 198705940 + num;
									_37ED57E7[num ^ 0xBD8033D] = _25121C24;
									num = 195388332 + num;
									Dictionary<uint, _19C46BFE> dictionary40 = _37ED57E7;
									uint key40 = num ^ 0x177D66EA;
									num /= 2010712108;
									_19C46BFE value24 = _163950BA;
									num = 1999784642u >> (int)num;
									dictionary40[key40] = value24;
									num = 1007565853 + num;
									if (1413379857 > num)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary41 = _37ED57E7;
									int key41 = (int)num ^ -1287616780;
									num = 626206917u >> (int)num;
									num = 0x143448BE | num;
									dictionary41[(uint)key41] = _76A86CFF;
									if (num > 1491014512)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary42 = _37ED57E7;
									num >>= 23;
									uint key42 = num ^ 4;
									num += 1108685340;
									num = 606035089 + num;
									_19C46BFE value25 = _620F74F5;
									num = 0x708E705A & num;
									dictionary42[key42] = value25;
									num = 1157004411 + num;
									Dictionary<uint, _19C46BFE> dictionary43 = _37ED57E7;
									num = 887629883 * num;
									dictionary43[num + 2194507108u] = _34042A95;
									if (1336555105 + num == 0)
									{
										goto IL_003e;
									}
									Dictionary<uint, _19C46BFE> dictionary44 = _37ED57E7;
									num /= 1523537761;
									uint key43 = num + 45;
									num /= 1275860557;
									dictionary44[key43] = _77F911BF;
									Dictionary<uint, _19C46BFE> dictionary45 = _37ED57E7;
									uint key44 = num + 47;
									num = 0x506439D4 | num;
									_19C46BFE value26 = _2AF82BD4;
									num = 1218662935 - num;
									dictionary45[key44] = value26;
									num = 1468606786u >> (int)num;
									num = 950172104u >> (int)num;
									Dictionary<uint, _19C46BFE> dictionary46 = _37ED57E7;
									int key45 = (int)num + -3711561;
									num <<= 23;
									num = 1305222889 % num;
									dictionary46[(uint)key45] = _14D24103;
									num -= 225906115;
									if ((num & 0x2E134F2E) == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary47 = _37ED57E7;
									uint key46 = num - 64295157;
									num -= 765859677;
									dictionary47[key46] = _4EA5585B;
									num &= 0x13B831A9;
									if (num > 1994808818)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary48 = _37ED57E7;
									num &= 0x70B4C7C;
									int key47 = (int)num + -34078678;
									num ^= 0x3FEE0417;
									num = (uint)(1769086016 << (int)num);
									dictionary48[(uint)key47] = _5DBC7F12;
									num &= 0x69A2583C;
									if (num * 1391091760 != 0)
									{
										goto end_IL_009a;
									}
									num = (uint)(435568604 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary49 = _37ED57E7;
									num -= 141718488;
									int key48 = (int)num + -293850065;
									num &= 0x43EF6E04;
									num = 0x2E591EF1 & num;
									_19C46BFE value27 = _4DB576CF;
									num = (uint)(918696047 << (int)num);
									dictionary49[(uint)key48] = value27;
									num = (uint)(930370291 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary50 = _37ED57E7;
									uint key49 = num ^ 0x29798034;
									num %= 775308047;
									dictionary50[key49] = _1F3A06D2;
									num &= 0x1C6C648F;
									num >>= 26;
									Dictionary<uint, _19C46BFE> dictionary51 = _37ED57E7;
									uint key50 = num ^ 0x37;
									num = 1081165750u >> (int)num;
									_19C46BFE value28 = _3CB70A58;
									num = 244336950u >> (int)num;
									dictionary51[key50] = value28;
									Dictionary<uint, _19C46BFE> dictionary52 = _37ED57E7;
									uint key51 = num ^ 0x74B4;
									_19C46BFE value29 = _31842681;
									num = (uint)(733553425 << (int)num);
									dictionary52[key51] = value29;
									if (1429938177 > num)
									{
										goto end_IL_009a;
									}
									num <<= 13;
									Dictionary<uint, _19C46BFE> dictionary53 = _37ED57E7;
									int key52 = (int)num - -1853325367;
									num /= 2106213629;
									dictionary53[(uint)key52] = _1F923095;
									num = 1071320316 % num;
									if (num / 1906716996 != 0)
									{
										goto end_IL_009a;
									}
									num = (uint)(1083125410 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary54 = _37ED57E7;
									num -= 785594918;
									int key53 = (int)num + -297530436;
									num = 0x77B40F08 | num;
									_19C46BFE value30 = _1D221342;
									num = 383468118 + num;
									dictionary54[(uint)key53] = value30;
									num += 166685441;
									if (num == 555245058)
									{
										goto end_IL_009a;
									}
									num = 0x6A734F0B & num;
									Dictionary<uint, _19C46BFE> dictionary55 = _37ED57E7;
									num *= 2138860930;
									uint key54 = num - 1050370125;
									num &= 0x3E372355;
									num += 983715428;
									dictionary55[key54] = _18C71B02;
									if (424700261 / num != 0)
									{
										goto IL_003e;
									}
									num /= 589759711;
									Dictionary<uint, _19C46BFE> dictionary56 = _37ED57E7;
									num = 505043241 * num;
									uint key55 = num ^ 0x5A4F0B41;
									num |= 0x15D938B3;
									_19C46BFE value31 = _06A60CD1;
									num = 656157374 - num;
									dictionary56[key55] = value31;
									num = 1326866975 + num;
									if (num + 555551450 == 0)
									{
										goto end_IL_009a;
									}
									num &= 0x6B4D0005;
									Dictionary<uint, _19C46BFE> dictionary57 = _37ED57E7;
									uint key56 = num - 37814213;
									_19C46BFE value32 = _06B941F1;
									num *= 1010023;
									dictionary57[key56] = value32;
									num += 2098528315;
									if ((0x541C292E ^ num) == 0)
									{
										goto end_IL_009a;
									}
									num = 0x53131FB1 ^ num;
									Dictionary<uint, _19C46BFE> dictionary58 = _37ED57E7;
									num = 310510288u >> (int)num;
									int key57 = (int)num + -303172;
									num = 1905027746 / num;
									num = (uint)(736238716 << (int)num);
									_19C46BFE value33 = _08952BA9;
									num = 1810843166 - num;
									dictionary58[(uint)key57] = value33;
									num = 1612186990 - num;
									Dictionary<uint, _19C46BFE> dictionary59 = _37ED57E7;
									int key58 = (int)num + -2090512147;
									num = 679243045u >> (int)num;
									dictionary59[(uint)key58] = _082D12F7;
									num ^= 0x66FE5AA6;
									Dictionary<uint, _19C46BFE> dictionary60 = _37ED57E7;
									int key59 = (int)num + -1727951516;
									num = 0x13CA772E ^ num;
									_19C46BFE value34 = _3CB70A58;
									num ^= 0x47E7462D;
									dictionary60[(uint)key59] = value34;
									Dictionary<uint, _19C46BFE> dictionary61 = _37ED57E7;
									uint key60 = num - 852706202;
									num ^= 0x27F64B64;
									_19C46BFE value35 = _4DB576CF;
									num = 1232937791 * num;
									dictionary61[key60] = value35;
									num = 1078872177u >> (int)num;
									if (1484274155 == num)
									{
										break;
									}
									num = 0x6C49418D | num;
									Dictionary<uint, _19C46BFE> dictionary62 = _37ED57E7;
									num &= 0x16421B0E;
									uint key61 = num ^ 0x440094E;
									num = 1746893320u >> (int)num;
									_19C46BFE value36 = _08952BA9;
									num >>= 24;
									dictionary62[key61] = value36;
									num >>= 14;
									Dictionary<uint, _19C46BFE> dictionary63 = _37ED57E7;
									int key62 = (int)num - -65;
									num &= 0x79B55DFF;
									_19C46BFE value37 = _620F74F5;
									num &= 0x59D306A1;
									dictionary63[(uint)key62] = value37;
									num = 1314219517 - num;
									if (715404369 * num == 0)
									{
										goto end_IL_009a;
									}
									num = 0x263B6C69 | num;
									Dictionary<uint, _19C46BFE> dictionary64 = _37ED57E7;
									num *= 1540449150;
									int key63 = (int)num + -1691220292;
									num -= 1358699416;
									num /= 1794971908;
									_19C46BFE value38 = _08952BA9;
									num *= 1905086893;
									dictionary64[(uint)key63] = value38;
									num <<= 13;
									Dictionary<uint, _19C46BFE> dictionary65 = _37ED57E7;
									uint key64 = num ^ 0x43;
									num /= 337148987;
									num >>= 8;
									dictionary65[key64] = _224B291D;
									num = 0x3C3F4736 & num;
									num = 1293118181 - num;
									Dictionary<uint, _19C46BFE> dictionary66 = _37ED57E7;
									int key65 = (int)num + -1293118113;
									num <<= 20;
									num = 0x7A0B2AD5 ^ num;
									_19C46BFE value39 = _4DB576CF;
									num = 0x136A278F ^ num;
									dictionary66[(uint)key65] = value39;
									num = (uint)(966866825 << (int)num);
									num = 329847810 + num;
									Dictionary<uint, _19C46BFE> dictionary67 = _37ED57E7;
									num = 741108096 + num;
									uint key66 = num - 1674935613;
									num = 691431241 * num;
									dictionary67[key66] = _1BA85A41;
									num = 1375622470u >> (int)num;
									num += 1821064348;
									Dictionary<uint, _19C46BFE> dictionary68 = _37ED57E7;
									num = 0xE70350F ^ num;
									uint key67 = num ^ 0x62FB6452;
									num = 348725705 % num;
									num = 0x3E37516A ^ num;
									num = 0x15E7A83 ^ num;
									_19C46BFE value40 = _348D306A;
									num += 1936132121;
									dictionary68[key67] = value40;
									num = 1048458792u >> (int)num;
									if (num >= 2115833770)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary69 = _37ED57E7;
									num %= 1276732930;
									uint key68 = num ^ 0x58;
									num = 0x51BF195E & num;
									_19C46BFE value41 = _78DA3BAD;
									num -= 1677787240;
									dictionary69[key68] = value41;
									num = 1727617324 - num;
									if (950618864 == num)
									{
										goto end_IL_009a;
									}
									num = 2134863409 / num;
									Dictionary<uint, _19C46BFE> dictionary70 = _37ED57E7;
									num = 1882745658 * num;
									uint key69 = num ^ 0x48;
									num = 0x11FF0834 ^ num;
									dictionary70[key69] = _7E6B08A7;
									Dictionary<uint, _19C46BFE> dictionary71 = _37ED57E7;
									uint key70 = num - 301926379;
									num *= 849501667;
									num = 1335064539 % num;
									num = 470883412 / num;
									_19C46BFE value42 = _18C71B02;
									num *= 109525640;
									dictionary71[key70] = value42;
									if (1166744692 - num == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary72 = _37ED57E7;
									num = 0x3D550A4B ^ num;
									int key71 = (int)num + -1028983297;
									num = 0x6E610929 | num;
									_19C46BFE value43 = _1FC105EF;
									num |= 0x12986FC5;
									dictionary72[(uint)key71] = value43;
									Dictionary<uint, _19C46BFE> dictionary73 = _37ED57E7;
									uint key72 = num ^ 0x7FFD6FA4;
									num <<= 14;
									_19C46BFE value44 = _4F1657F9;
									num = 1473393096 + num;
									dictionary73[key72] = value44;
									num >>= 28;
									if ((0xF407E21 ^ num) == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary74 = _37ED57E7;
									num += 1335259740;
									uint key73 = num ^ 0x4F96722B;
									_19C46BFE value45 = _1FC105EF;
									num = 443032535u >> (int)num;
									dictionary74[key73] = value45;
									Dictionary<uint, _19C46BFE> dictionary75 = _37ED57E7;
									num = 675032159 - num;
									int key74 = (int)num + -671570891;
									num = 1000229580 + num;
									num = 0x7FCC04E9 & num;
									num = 85813810 / num;
									dictionary75[(uint)key74] = _28F05C6A;
									num = 1459036647 - num;
									Dictionary<uint, _19C46BFE> dictionary76 = _37ED57E7;
									uint key75 = num ^ 0x56F721A9;
									num /= 531593809;
									dictionary76[key75] = _562978D7;
									num <<= 5;
									if ((0x535F5351 & num) == 0)
									{
										break;
									}
									num = 0x6EC61374 & num;
									Dictionary<uint, _19C46BFE> dictionary77 = _37ED57E7;
									num |= 0x70FB2DC3;
									int key76 = (int)num + -1895509364;
									num <<= 22;
									num >>= 27;
									dictionary77[(uint)key76] = _163950BA;
									Dictionary<uint, _19C46BFE> dictionary78 = _37ED57E7;
									num |= 0x642D0BCF;
									uint key77 = num - 1680673663;
									num ^= 0x706F59A0;
									num += 1784939059;
									_19C46BFE value46 = _562978D7;
									num = 56580540 % num;
									dictionary78[key77] = value46;
									num ^= 0x3F09504E;
									num %= 1533021293;
									Dictionary<uint, _19C46BFE> dictionary79 = _37ED57E7;
									num *= 2052413635;
									uint key78 = num ^ 0x2A4EC307;
									num %= 1885564367;
									_19C46BFE value47 = _1D221342;
									num = 1080363175u >> (int)num;
									dictionary79[key78] = value47;
									num >>= 31;
									num += 2069893206;
									Dictionary<uint, _19C46BFE> dictionary80 = _37ED57E7;
									uint key79 = num - 2069893124;
									num = 431499730 + num;
									_19C46BFE value48 = _154C653A;
									num += 671841892;
									dictionary80[key79] = value48;
									num <<= 4;
									if (1933710792 - num == 0)
									{
										goto IL_006c;
									}
									num = 0x2EF23473 & num;
									Dictionary<uint, _19C46BFE> dictionary81 = _37ED57E7;
									uint key80 = num - 36831213;
									num ^= 0x722300AF;
									num = 1043228521 + num;
									_19C46BFE value49 = _381C352C;
									num = 1539713398 * num;
									dictionary81[key80] = value49;
									Dictionary<uint, _19C46BFE> dictionary82 = _37ED57E7;
									uint key81 = num ^ 0x750030C4;
									num = 958014085 * num;
									num >>= 19;
									_19C46BFE value50 = _1FC105EF;
									num = 0x72AC78E8 ^ num;
									dictionary82[key81] = value50;
									num = 1044917523 / num;
									Dictionary<uint, _19C46BFE> dictionary83 = _37ED57E7;
									num = 545269759 + num;
									uint key82 = num - 545269674;
									num = 0x7D693B4A & num;
									num = 1766734883 / num;
									num = 87834087u >> (int)num;
									dictionary83[key82] = _562978D7;
									Dictionary<uint, _19C46BFE> dictionary84 = _37ED57E7;
									num = 969294758u >> (int)num;
									uint key83 = num + 83;
									num = 545864867 * num;
									num |= 0x2175576F;
									dictionary84[key83] = _25121C24;
									num = 212552003 - num;
									if ((num ^ 0x2D6015EE) == 0)
									{
										goto IL_003e;
									}
									num = 0x4ADF0E35 ^ num;
									Dictionary<uint, _19C46BFE> dictionary85 = _37ED57E7;
									num <<= 13;
									int key84 = (int)num ^ -1947459497;
									num <<= 31;
									num /= 416222636;
									dictionary85[(uint)key84] = _78DA3BAD;
									num -= 1801650904;
									num |= 0x62325793;
									Dictionary<uint, _19C46BFE> dictionary86 = _37ED57E7;
									int key85 = (int)num - -155254941;
									num = 1750078920u >> (int)num;
									num = 2075276656u >> (int)num;
									dictionary86[(uint)key85] = _163950BA;
									num = (uint)(1299013236 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary87 = _37ED57E7;
									int key86 = (int)num ^ -1125646247;
									num = 899045959 + num;
									num >>= 15;
									num <<= 26;
									_19C46BFE value51 = _154C653A;
									num = 1260589526 % num;
									dictionary87[(uint)key86] = value51;
									num %= 187773171;
									Dictionary<uint, _19C46BFE> dictionary88 = _37ED57E7;
									num = 39144074 + num;
									uint key87 = num - 173094484;
									num &= 0x30D3B2E;
									dictionary88[key87] = _3CB70A58;
									num = 184642129 + num;
									num /= 1266693971;
									Dictionary<uint, _19C46BFE> dictionary89 = _37ED57E7;
									uint key88 = num ^ 0x5B;
									num &= 0xCCE32C3;
									num = 0x412D1637 | num;
									_19C46BFE value52 = _4F1657F9;
									num &= 0x5C61698E;
									dictionary89[key88] = value52;
									if (19142301 == num)
									{
										goto IL_006c;
									}
									Dictionary<uint, _19C46BFE> dictionary90 = _37ED57E7;
									num = 1210612744 % num;
									uint key89 = num ^ 0x8077C5E;
									num = 0x43CD216D | num;
									num ^= 0x666651AA;
									dictionary90[key89] = _4EA5585B;
									if (num > 1848065986)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary91 = _37ED57E7;
									num += 1045920015;
									uint key90 = num ^ 0x6C00A589;
									num = 0x2C990BFF & num;
									num /= 1745175458;
									dictionary91[key90] = _28F05C6A;
									num = 401155802u >> (int)num;
									Dictionary<uint, _19C46BFE> dictionary92 = _37ED57E7;
									num ^= 0x1D8B3B4C;
									uint key91 = num ^ 0xA621DC8;
									num |= 0x6DD4078D;
									num += 1522806013;
									dictionary92[key91] = _1FC105EF;
									num /= 1972120074;
									Dictionary<uint, _19C46BFE> dictionary93 = _37ED57E7;
									uint key92 = num + 94;
									num = 0xE4678A1 & num;
									dictionary93[key92] = _78760B02;
									Dictionary<uint, _19C46BFE> dictionary94 = _37ED57E7;
									int key93 = (int)num - -95;
									num = 117198402 % num;
									num = 365057186u >> (int)num;
									dictionary94[(uint)key93] = _4DB576CF;
									num = 1179276874 * num;
									num = 0xB8507E6 | num;
									Dictionary<uint, _19C46BFE> dictionary95 = _37ED57E7;
									uint key94 = num ^ 0x5FEFE797;
									num <<= 29;
									dictionary95[key94] = _64351E3E;
									num /= 526781055;
									if ((0x6CC62C45 & num) == 0)
									{
										goto end_IL_009a;
									}
									num = 0xDEE0179 | num;
									Dictionary<uint, _19C46BFE> dictionary96 = _37ED57E7;
									num %= 744173655;
									uint key95 = num - 233701661;
									num &= 0x9524EE8;
									dictionary96[key95] = _3CB70A58;
									num = 2104119136u >> (int)num;
									if (1599826075 <= num)
									{
										goto IL_003e;
									}
									Dictionary<uint, _19C46BFE> dictionary97 = _37ED57E7;
									uint key96 = num ^ 0x7D6A2C;
									num = 0x5D5F1433 ^ num;
									num = 2038256154 * num;
									_19C46BFE value53 = _76A86CFF;
									num = 1935368816 / num;
									dictionary97[key96] = value53;
									Dictionary<uint, _19C46BFE> dictionary98 = _37ED57E7;
									uint key97 = num + 100;
									_19C46BFE value54 = _28F05C6A;
									num &= 0x144B218E;
									dictionary98[key97] = value54;
									num = (uint)(19416026 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary99 = _37ED57E7;
									num = 1156851169 * num;
									dictionary99[num + 2516966347u] = _4DB576CF;
									num <<= 30;
									Dictionary<uint, _19C46BFE> dictionary100 = _37ED57E7;
									num = 1781400574u >> (int)num;
									uint key98 = num - 1781400472;
									num -= 595028256;
									num += 829966463;
									dictionary100[key98] = _4DB576CF;
									num = 1266120165 - num;
									num += 255801477;
									Dictionary<uint, _19C46BFE> dictionary101 = _37ED57E7;
									num |= 0x101A147F;
									uint key99 = num + 224403688;
									num = 672404201 - num;
									num = 0x115B402F | num;
									dictionary101[key99] = _1BA85A41;
									num = 1763538667 / num;
									if (num == 419178349)
									{
										break;
									}
									num = 1326801089 + num;
									Dictionary<uint, _19C46BFE> dictionary102 = _37ED57E7;
									num = 1391936293 - num;
									uint key100 = num ^ 0x3E1E20B;
									num = 0x49070EE0 | num;
									_19C46BFE value55 = _4B320761;
									num ^= 0x24CC2E8E;
									dictionary102[key100] = value55;
									Dictionary<uint, _19C46BFE> dictionary103 = _37ED57E7;
									num >>= 14;
									int key101 = (int)num + -113734;
									num = 0xDB60CE7 & num;
									num *= 1252016123;
									_19C46BFE value56 = _4DB576CF;
									num = 1513108477u >> (int)num;
									dictionary103[(uint)key101] = value56;
									if (836910530 < num)
									{
										goto end_IL_009a;
									}
									num |= 0x1276595A;
									Dictionary<uint, _19C46BFE> dictionary104 = _37ED57E7;
									uint key102 = num - 309745904;
									num = 267917194 % num;
									num >>= 5;
									dictionary104[key102] = _6DC22504;
									Dictionary<uint, _19C46BFE> dictionary105 = _37ED57E7;
									uint key103 = num ^ 0x7FC0D7;
									num = 1956596952 * num;
									_19C46BFE value57 = _1F3A06D2;
									num = 484001654u >> (int)num;
									dictionary105[key103] = value57;
									Dictionary<uint, _19C46BFE> dictionary106 = _37ED57E7;
									num = 1115816964 * num;
									uint key104 = num + 1905330836;
									num ^= 0x16EE1F3C;
									dictionary106[key104] = _6DC22504;
									num <<= 19;
									if ((num ^ 0x3CD80498) == 0)
									{
										break;
									}
									num |= 0x34F856F6;
									Dictionary<uint, _19C46BFE> dictionary107 = _37ED57E7;
									num /= 1164184225;
									uint key105 = num ^ 0x6C;
									num >>= 15;
									_19C46BFE value58 = _348D306A;
									num <<= 13;
									dictionary107[key105] = value58;
									num = 0x26D85B20 & num;
									Dictionary<uint, _19C46BFE> dictionary108 = _37ED57E7;
									num = 0x48D32119 & num;
									uint key106 = num ^ 0x6E;
									num = 2126931503u >> (int)num;
									_19C46BFE value59 = _28F05C6A;
									num = 0x78FA3316 | num;
									dictionary108[key106] = value59;
									num = 1805394216 - num;
									Dictionary<uint, _19C46BFE> dictionary109 = _37ED57E7;
									int key107 = (int)num ^ -325211770;
									num >>= 0;
									num <<= 10;
									_19C46BFE value60 = _224B291D;
									num = 0x413E38CB & num;
									dictionary109[(uint)key107] = value60;
									num = 1385173692 - num;
									num = 858198593 * num;
									Dictionary<uint, _19C46BFE> dictionary110 = _37ED57E7;
									num = 1048250229 % num;
									uint key108 = num ^ 0x3E7B0705;
									num = (uint)(868624169 << (int)num);
									num <<= 1;
									dictionary110[key108] = _748B5AA0;
									num |= 0x6B0C694E;
									if (1079866634 * num == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary111 = _37ED57E7;
									num = 156181324 + num;
									int key109 = (int)num - -191132631;
									num = 271399439 - num;
									num = 365121163 * num;
									_19C46BFE value61 = _04D16CFA;
									num -= 1328045486;
									dictionary111[(uint)key109] = value61;
									num = 469895285 + num;
									num = 1120477687 % num;
									Dictionary<uint, _19C46BFE> dictionary112 = _37ED57E7;
									num *= 123278627;
									uint key110 = num - 824698707;
									num = (uint)(435503824 << (int)num);
									num ^= 0x4942B6;
									_19C46BFE value62 = _1FC105EF;
									num = 1301446098 % num;
									dictionary112[key110] = value62;
									num >>= 17;
									if (982523652 < num)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary113 = _37ED57E7;
									num >>= 16;
									uint key111 = num + 115;
									num = 1401048760 - num;
									num -= 96697313;
									dictionary113[key111] = _3CB70A58;
									if (1178352639 >= num)
									{
										goto IL_006c;
									}
									num = 1331129481 + num;
									Dictionary<uint, _19C46BFE> dictionary114 = _37ED57E7;
									int key112 = (int)num ^ -1659486444;
									num >>= 3;
									num += 402417250;
									dictionary114[(uint)key112] = _224B291D;
									num >>= 28;
									Dictionary<uint, _19C46BFE> dictionary115 = _37ED57E7;
									uint key113 = num + 115;
									num <<= 15;
									num = 2053340418 % num;
									_19C46BFE value63 = _34042A95;
									num *= 413144533;
									dictionary115[key113] = value63;
									if (704644422 > num)
									{
										goto end_IL_009a;
									}
									num |= 0x25A31E04;
									Dictionary<uint, _19C46BFE> dictionary116 = _37ED57E7;
									uint key114 = num ^ 0x7FEB3ED8;
									num |= 0x5A381D60;
									num = 0x4B0B4716 | num;
									num = 498801145 - num;
									_19C46BFE value64 = _224B291D;
									num -= 720202392;
									dictionary116[key114] = value64;
									if (1119505138 == num)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary117 = _37ED57E7;
									uint key115 = num ^ 0x72D22F14;
									num = (uint)(1773678795 << (int)num);
									dictionary117[key115] = _76A86CFF;
									num |= 0x1F0B59CA;
									if (2012441839 <= num)
									{
										break;
									}
									num &= 0x14200774;
									Dictionary<uint, _19C46BFE> dictionary118 = _37ED57E7;
									num |= 0x16702DE5;
									uint key116 = num ^ 0x16702F8D;
									num = 221935359 / num;
									num |= 0x7D235550;
									num = 1606757513u >> (int)num;
									_19C46BFE value65 = _348D306A;
									num = 0x102E0C00 & num;
									dictionary118[key116] = value65;
									if ((0x16B70B61 & num) == 0)
									{
										break;
									}
									num = 682038979 - num;
									Dictionary<uint, _19C46BFE> dictionary119 = _37ED57E7;
									uint key117 = num ^ 0x28A70ABA;
									num = 1915101708 % num;
									num = (uint)(813989498 << (int)num);
									_19C46BFE value66 = _1F3A06D2;
									num = (uint)(607076692 << (int)num);
									dictionary119[key117] = value66;
									num /= 1168586411;
									num = 0x3DA85DFD ^ num;
									Dictionary<uint, _19C46BFE> dictionary120 = _37ED57E7;
									num -= 1993566179;
									dictionary120[num ^ 0xC6D4F660u] = _77F911BF;
									if (1735667630 << (int)num == 0)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary121 = _37ED57E7;
									uint key118 = num + 959122017;
									num = 760565507 / num;
									_19C46BFE value67 = _2C0F1316;
									num = 1780692209 * num;
									dictionary121[key118] = value67;
									num = 0x5C0D61BF ^ num;
									num |= 0x3E6617F4;
									Dictionary<uint, _19C46BFE> dictionary122 = _37ED57E7;
									uint key119 = num ^ 0x7E6F7783;
									num = 598746770u >> (int)num;
									num = 0x31594EDB ^ num;
									_19C46BFE value68 = _224B291D;
									num = (uint)(273628251 << (int)num);
									dictionary122[key119] = value68;
									num = 0x16EF7A66 & num;
									if (num == 2090949001)
									{
										goto IL_003e;
									}
									num <<= 14;
									Dictionary<uint, _19C46BFE> dictionary123 = _37ED57E7;
									uint key120 = num + 125;
									num = 0x75F634D1 ^ num;
									dictionary123[key120] = _32565EA6;
									num /= 73023938;
									if (num * 1250125859 == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary124 = _37ED57E7;
									uint key121 = num + 99;
									num -= 1926828466;
									_19C46BFE value69 = _562978D7;
									num = 555175662 / num;
									dictionary124[key121] = value69;
									num = 0x67E034C4 | num;
									Dictionary<uint, _19C46BFE> dictionary125 = _37ED57E7;
									int key122 = (int)num + -1742746693;
									num = 1642268053 % num;
									num >>= 3;
									dictionary125[(uint)key122] = _01BE1822;
									num = 249190724u >> (int)num;
									if (num > 1015550273)
									{
										goto IL_003e;
									}
									num ^= 0x765A4B7F;
									Dictionary<uint, _19C46BFE> dictionary126 = _37ED57E7;
									num = 1492975873 * num;
									int key123 = (int)num ^ -683142839;
									num ^= 0x794B0439;
									_19C46BFE value70 = _67880719;
									num = 1797088562 - num;
									dictionary126[(uint)key123] = value70;
									num >>= 3;
									if (1105872479 >>> (int)num == 0)
									{
										break;
									}
									_37ED57E7[num + 3898390169u] = _348D306A;
									if (1558515018 >>> (int)num == 0)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary127 = _37ED57E7;
									uint key124 = num ^ 0x17A3496A;
									num *= 1727137673;
									num <<= 19;
									_19C46BFE value71 = _61F0475A;
									num /= 1605510592;
									dictionary127[key124] = value71;
									num = 4339215 * num;
									Dictionary<uint, _19C46BFE> dictionary128 = _37ED57E7;
									uint key125 = num + 131;
									num -= 1880125821;
									_19C46BFE value72 = _4DB576CF;
									num = 0x148B05F0 | num;
									dictionary128[key125] = value72;
									num <<= 12;
									num = 1987131081 + num;
									Dictionary<uint, _19C46BFE> dictionary129 = _37ED57E7;
									uint key126 = num ^ 0x6F70664D;
									num = 1995517914 / num;
									num >>= 15;
									dictionary129[key126] = _06A60CD1;
									num = 1537159818 - num;
									if (num + 1296769263 == 0)
									{
										goto end_IL_009a;
									}
									num ^= 0x52EA5C01;
									Dictionary<uint, _19C46BFE> dictionary130 = _37ED57E7;
									num *= 727135261;
									int key127 = (int)num - -687947462;
									num = 0x226919EA & num;
									num = 2013485128 * num;
									num >>= 7;
									_19C46BFE value73 = _16E87D4E;
									num %= 1692427886;
									dictionary130[(uint)key127] = value73;
									num %= 1710906807;
									num = 0x16440591 ^ num;
									Dictionary<uint, _19C46BFE> dictionary131 = _37ED57E7;
									uint key128 = num - 369206232;
									num |= 0x5D73463C;
									dictionary131[key128] = _14D24103;
									Dictionary<uint, _19C46BFE> dictionary132 = _37ED57E7;
									int key129 = (int)num + -1601431031;
									num -= 659360027;
									num = 0x6D4C4210 ^ num;
									_19C46BFE value74 = _39050D2A;
									num ^= 0x75EE5199;
									dictionary132[(uint)key129] = value74;
									_37ED57E7[num + 3749392798u] = _224B291D;
									num = 764356712 + num;
									num = (uint)(1857636434 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary133 = _37ED57E7;
									uint key130 = num ^ 0x21480089;
									num = 205591284 * num;
									dictionary133[key130] = _77F911BF;
									Dictionary<uint, _19C46BFE> dictionary134 = _37ED57E7;
									int key131 = (int)num ^ -929038198;
									num += 819859548;
									dictionary134[(uint)key131] = _753C322B;
									num = 1050049309u >> (int)num;
									Dictionary<uint, _19C46BFE> dictionary135 = _37ED57E7;
									int key132 = (int)num - -136;
									num = (uint)(1191792453 << (int)num);
									dictionary135[(uint)key132] = _4DB576CF;
									if (1918255752 >>> (int)num == 0)
									{
										break;
									}
									num = 834802966 - num;
									Dictionary<uint, _19C46BFE> dictionary136 = _37ED57E7;
									num = 361516500u >> (int)num;
									uint key133 = num ^ 0x56BD;
									_19C46BFE value75 = _64351E3E;
									num = 1409113873 * num;
									dictionary136[key133] = value75;
									num >>= 26;
									num %= 739471861;
									Dictionary<uint, _19C46BFE> dictionary137 = _37ED57E7;
									num &= 0x2C1B0AAB;
									uint key134 = num ^ 0x85;
									num = 0x11227FB0 & num;
									_19C46BFE value76 = _76A86CFF;
									num = 0x7D683549 | num;
									dictionary137[key134] = value76;
									if (num == 1796348350)
									{
										goto IL_009a;
									}
									num += 2137681556;
									Dictionary<uint, _19C46BFE> dictionary138 = _37ED57E7;
									uint key135 = num + 53304497;
									num = 1650136114 - num;
									dictionary138[key135] = _1FC105EF;
									num = 2105028915 + num;
									if (num < 32916103)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary139 = _37ED57E7;
									num = 1728775090u >> (int)num;
									uint key136 = num ^ 0x670B8C;
									num = 552152524u >> (int)num;
									num = 745625638 * num;
									_19C46BFE value77 = _64351E3E;
									num >>= 12;
									dictionary139[key136] = value77;
									num -= 155390433;
									if (314860958 > num)
									{
										goto end_IL_009a;
									}
									num &= 0x24C67EC0;
									Dictionary<uint, _19C46BFE> dictionary140 = _37ED57E7;
									num = 0x57EB00CC & num;
									uint key137 = num ^ 0x48200D0;
									num /= 714016919;
									num = 706555264 + num;
									dictionary140[key137] = _1BA85A41;
									if (492138440 >>> (int)num == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary141 = _37ED57E7;
									num ^= 0x11DA7B80;
									uint key138 = num ^ 0x3BC75691;
									num ^= 0x3EEF29C1;
									dictionary141[key138] = _04D16CFA;
									num = 1091063165 / num;
									Dictionary<uint, _19C46BFE> dictionary142 = _37ED57E7;
									num = (uint)(933784272 << (int)num);
									uint key139 = num + 2035482770;
									num = 0x68F541EB | num;
									num = 407652044 % num;
									dictionary142[key139] = _348D306A;
									num = 599087218 + num;
									Dictionary<uint, _19C46BFE> dictionary143 = _37ED57E7;
									num = 0x22920A27 & num;
									uint key140 = num - 536873363;
									num = 217064572 * num;
									dictionary143[key140] = _67880719;
									num = 0x7E1078F6 | num;
									num = (uint)(680789134 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary144 = _37ED57E7;
									int key141 = (int)num + -2147483500;
									num /= 1555309538;
									num %= 1102020556;
									dictionary144[(uint)key141] = _5B994F51;
									num += 1789074705;
									Dictionary<uint, _19C46BFE> dictionary145 = _37ED57E7;
									uint key142 = num - 1789074557;
									num |= 0x3AFA01EA;
									_19C46BFE value78 = _224B291D;
									num = 0x4AE47030 & num;
									dictionary145[key142] = value78;
									num = 0xA165EB1 & num;
									Dictionary<uint, _19C46BFE> dictionary146 = _37ED57E7;
									uint key143 = num ^ 0xA0010A6;
									num >>= 29;
									num = 0x683C39CF & num;
									dictionary146[key143] = _4EA5585B;
									if ((0x256D53AB ^ num) == 0)
									{
										goto end_IL_009a;
									}
									num = 0x55E50122 ^ num;
									Dictionary<uint, _19C46BFE> dictionary147 = _37ED57E7;
									num *= 835151946;
									int key144 = (int)num + -1075192637;
									_19C46BFE value79 = _78760B02;
									num >>= 6;
									dictionary147[(uint)key144] = value79;
									num = (uint)(1179745564 << (int)num);
									if (num <= 1452087371)
									{
										goto end_IL_009a;
									}
									num = 1304036446 * num;
									Dictionary<uint, _19C46BFE> dictionary148 = _37ED57E7;
									num /= 2061636120;
									dictionary148[num - 4294967144u] = _46E26DC8;
									num ^= 0x3A661B9D;
									if (618348006 >= num)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary149 = _37ED57E7;
									uint key145 = num ^ 0x3A661B04;
									num *= 1219312612;
									num = (uint)(302131472 << (int)num);
									_19C46BFE value80 = _163950BA;
									num = 1953630525u >> (int)num;
									dictionary149[key145] = value80;
									num = 337738859u >> (int)num;
									if ((0x5D5756C ^ num) == 0)
									{
										goto end_IL_009a;
									}
									num = 0x1E6A0B6C & num;
									Dictionary<uint, _19C46BFE> dictionary150 = _37ED57E7;
									num <<= 13;
									uint key146 = num ^ 0x9A;
									num -= 714939322;
									_19C46BFE value81 = _77F911BF;
									num = 641139812 + num;
									dictionary150[key146] = value81;
									num = 95620390 + num;
									if (num >= 1567715141)
									{
										goto end_IL_009a;
									}
									num = 0x59E4139C | num;
									Dictionary<uint, _19C46BFE> dictionary151 = _37ED57E7;
									num = 1234919092 % num;
									int key147 = (int)num + -1234918937;
									num >>= 24;
									num = 625243967 - num;
									dictionary151[(uint)key147] = _348D306A;
									if (num << 20 == 0)
									{
										break;
									}
									num |= 0x31657F41;
									_37ED57E7[num - 895844187] = _67880719;
									num %= 194144846;
									Dictionary<uint, _19C46BFE> dictionary152 = _37ED57E7;
									uint key148 = num ^ 0x71BD622;
									num = 188841980 % num;
									_19C46BFE value82 = _348D306A;
									num -= 1108162912;
									dictionary152[key148] = value82;
									num = 0x15C2447B & num;
									Dictionary<uint, _19C46BFE> dictionary153 = _37ED57E7;
									num *= 1518273146;
									uint key149 = num ^ 0x32D044F4;
									num = 2125534154 * num;
									dictionary153[key149] = _1FC105EF;
									if ((num & 0x7C6237D0) == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary154 = _37ED57E7;
									int key150 = (int)num + -112449797;
									num += 1377969241;
									num -= 398482263;
									dictionary154[(uint)key150] = _1FC105EF;
									num <<= 19;
									num = (uint)(986843502 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary155 = _37ED57E7;
									int key151 = (int)num + -986843342;
									num -= 351041865;
									num = 936072403u >> (int)num;
									_19C46BFE value83 = _620F74F5;
									num *= 1544909886;
									dictionary155[(uint)key151] = value83;
									Dictionary<uint, _19C46BFE> dictionary156 = _37ED57E7;
									int key152 = (int)num ^ -993317739;
									num = 1492334859 % num;
									num = 429148631 * num;
									_19C46BFE value84 = _4EA5585B;
									num = 1835358784 * num;
									dictionary156[(uint)key152] = value84;
									if (num == 1478648004)
									{
										goto end_IL_009a;
									}
									num >>= 8;
									Dictionary<uint, _19C46BFE> dictionary157 = _37ED57E7;
									uint key153 = num ^ 0x2747E3;
									num %= 1509952986;
									num = 0x4AC4799B | num;
									num >>= 23;
									dictionary157[key153] = _18C71B02;
									if (1212508186 == num)
									{
										break;
									}
									num &= 0x16C85A2F;
									Dictionary<uint, _19C46BFE> dictionary158 = _37ED57E7;
									uint key154 = num + 158;
									_19C46BFE value85 = _4DB576CF;
									num = 1484349540 - num;
									dictionary158[key154] = value85;
									Dictionary<uint, _19C46BFE> dictionary159 = _37ED57E7;
									uint key155 = num ^ 0x587960FB;
									num = (uint)(606809780 << (int)num);
									dictionary159[key155] = _28F05C6A;
									num = 1031148977u >> (int)num;
									if (num + 814964008 == 0)
									{
										goto end_IL_009a;
									}
									num = (uint)(542211420 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary160 = _37ED57E7;
									int key156 = (int)num ^ -88604507;
									num = 203030554 * num;
									num = 797001433 % num;
									dictionary160[(uint)key156] = _4DB576CF;
									if ((num & 0x54EE4DC5) == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary161 = _37ED57E7;
									num = 1194865478 % num;
									uint key157 = num ^ 0x17B6ECCB;
									num /= 592871022;
									_19C46BFE value86 = _34042A95;
									num = 91978466 + num;
									dictionary161[key157] = value86;
									num += 222775556;
									num -= 2027519157;
									Dictionary<uint, _19C46BFE> dictionary162 = _37ED57E7;
									int key158 = (int)num - -1712765302;
									num = 554634007u >> (int)num;
									num = 0x9032B34 ^ num;
									num = 0x390030AA | num;
									dictionary162[(uint)key158] = _348D306A;
									if (2087145212 % num == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary163 = _37ED57E7;
									num >>= 4;
									uint key159 = num ^ 0x3903313;
									num ^= 0x18E67BDA;
									_19C46BFE value87 = _6DC22504;
									num /= 1690117954;
									dictionary163[key159] = value87;
									num %= 1481209198;
									if (num << 24 != 0)
									{
										goto IL_009a;
									}
									num <<= 18;
									Dictionary<uint, _19C46BFE> dictionary164 = _37ED57E7;
									uint key160 = num ^ 0xA9;
									num %= 1973161719;
									dictionary164[key160] = _64351E3E;
									num *= 1601391062;
									if (num / 1099199775 != 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary165 = _37ED57E7;
									int key161 = (int)num - -170;
									num = 0x328547F1 ^ num;
									num %= 535302262;
									num ^= 0x79EB550F;
									dictionary165[(uint)key161] = _77F911BF;
									num = 724196852 * num;
									if (52712812 == num)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary166 = _37ED57E7;
									num %= 1424494959;
									uint key162 = num ^ 0x11A1FA3B;
									num &= 0xF82653F;
									dictionary166[key162] = _64351E3E;
									if ((0x5F6C1B42 ^ num) == 0)
									{
										goto IL_003e;
									}
									num = 312682797 * num;
									Dictionary<uint, _19C46BFE> dictionary167 = _37ED57E7;
									uint key163 = num - 488862244;
									num = 1057781864 % num;
									_19C46BFE value88 = _224B291D;
									num <<= 13;
									dictionary167[key163] = value88;
									num = 1988298038 * num;
									Dictionary<uint, _19C46BFE> dictionary168 = _37ED57E7;
									uint key164 = num - 1539702611;
									num = 0x5B881D2E & num;
									num = 1804998761u >> (int)num;
									_19C46BFE value89 = _4DB576CF;
									num = 1207636448 * num;
									dictionary168[key164] = value89;
									num = 1349654758 % num;
									num = 1566073570u >> (int)num;
									Dictionary<uint, _19C46BFE> dictionary169 = _37ED57E7;
									int key165 = (int)num + -24469725;
									num = 0x22697B9A | num;
									num <<= 21;
									_19C46BFE value90 = _748B5AA0;
									num += 105715482;
									dictionary169[(uint)key165] = value90;
									num = 0x6A945E1C ^ num;
									Dictionary<uint, _19C46BFE> dictionary170 = _37ED57E7;
									uint key166 = num - 322521175;
									num |= 0xDB16288;
									num -= 850528608;
									num %= 2000972555;
									dictionary170[key166] = _348D306A;
									if (75394766 > num)
									{
										goto IL_006c;
									}
									_37ED57E7[num ^ 0x75C2F793] = _64351E3E;
									num /= 1896690996;
									Dictionary<uint, _19C46BFE> dictionary171 = _37ED57E7;
									num = 570102548 + num;
									int key167 = (int)num + -570102372;
									num = 0x2C521CFE & num;
									num &= 0x11D41C2A;
									_19C46BFE value91 = _446A73F3;
									num = 1985372290 / num;
									dictionary171[(uint)key167] = value91;
									num = 122251871u >> (int)num;
									Dictionary<uint, _19C46BFE> dictionary172 = _37ED57E7;
									num += 3097029;
									uint key168 = num - 3096852;
									num |= 0x5C915CD7;
									dictionary172[key168] = _01BE1822;
									Dictionary<uint, _19C46BFE> dictionary173 = _37ED57E7;
									num = 1422732362 + num;
									int key169 = (int)num ^ -1316189550;
									num = 1876453465 * num;
									num /= 1812989067;
									dictionary173[(uint)key169] = _28F05C6A;
									num %= 1328641146;
									_37ED57E7[num ^ 0xB5] = _1D221342;
									num = 2074417095 * num;
									if (num <= 35864204)
									{
										goto IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary174 = _37ED57E7;
									uint key170 = num ^ 0x7BA51772;
									num = 291397592 - num;
									dictionary174[key170] = _163950BA;
									Dictionary<uint, _19C46BFE> dictionary175 = _37ED57E7;
									num ^= 0x358E66CD;
									int key171 = (int)num - -1606996442;
									num = 229119732 % num;
									num = 523780528 % num;
									num /= 1358782268;
									dictionary175[(uint)key171] = _32565EA6;
									num = 0x32141730 | num;
									if (1016805557 + num == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary176 = _37ED57E7;
									num = 37829636 / num;
									uint key172 = num ^ 0xB7;
									num -= 1263154964;
									_19C46BFE value92 = _01BE1822;
									num = 195244496 - num;
									dictionary176[key172] = value92;
									num = 0x12641BEA & num;
									num %= 183894946;
									Dictionary<uint, _19C46BFE> dictionary177 = _37ED57E7;
									num = 1949846750 / num;
									uint key173 = num ^ 0xB7;
									num -= 486292393;
									num -= 1888030384;
									num = 0x131729C4 ^ num;
									_19C46BFE value93 = _748B5AA0;
									num -= 1314279515;
									dictionary177[key173] = value93;
									Dictionary<uint, _19C46BFE> dictionary178 = _37ED57E7;
									int key174 = (int)num + -320293726;
									num = 2065443769u >> (int)num;
									num &= 0x52E654AE;
									num <<= 3;
									_19C46BFE value94 = _18C71B02;
									num -= 149372315;
									dictionary178[(uint)key174] = value94;
									num = 0x5DFB40E6 ^ num;
									Dictionary<uint, _19C46BFE> dictionary179 = _37ED57E7;
									num = 0x7CF32919 ^ num;
									int key175 = (int)num - -703550032;
									_19C46BFE value95 = _753C322B;
									num = (uint)(451770851 << (int)num);
									dictionary179[(uint)key175] = value95;
									Dictionary<uint, _19C46BFE> dictionary180 = _37ED57E7;
									uint key176 = num + 1243116731;
									num += 1723296389;
									dictionary180[key176] = _1BA85A41;
									num = 1003759469 - num;
									Dictionary<uint, _19C46BFE> dictionary181 = _37ED57E7;
									int key177 = (int)num + -523579436;
									num = 1170820366 * num;
									num <<= 27;
									dictionary181[(uint)key177] = _562978D7;
									Dictionary<uint, _19C46BFE> dictionary182 = _37ED57E7;
									num ^= 0x1F8F23FE;
									int key178 = (int)num ^ -1618009277;
									num -= 1525633972;
									num = 0x4AF4253E ^ num;
									num |= 0x3BAC32F4;
									dictionary182[(uint)key178] = _5B994F51;
									Dictionary<uint, _19C46BFE> dictionary183 = _37ED57E7;
									num %= 1537478403;
									uint key179 = num - 1072690998;
									num = (uint)(1616865142 << (int)num);
									_19C46BFE value96 = _5DBC7F12;
									num = (uint)(538082163 << (int)num);
									dictionary183[key179] = value96;
									num = 1308895842 - num;
									Dictionary<uint, _19C46BFE> dictionary184 = _37ED57E7;
									num = 659908352 + num;
									int key180 = (int)num + -1430721840;
									num = 1622878144 + num;
									dictionary184[(uint)key180] = _753C322B;
									if (num <= 1912037738)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary185 = _37ED57E7;
									uint key181 = num + 1241367313;
									num = (uint)(2064587387 << (int)num);
									dictionary185[key181] = _753C322B;
									num >>= 24;
									Dictionary<uint, _19C46BFE> dictionary186 = _37ED57E7;
									uint key182 = num ^ 0x4C;
									num = 0x22195E22 | num;
									num = 2063425358u >> (int)num;
									num = 1703494071 % num;
									dictionary186[key182] = _2AF82BD4;
									num /= 2019778902;
									if (596263584 < num)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary187 = _37ED57E7;
									num = (uint)(1241779745 << (int)num);
									uint key183 = num - 1241779551;
									num += 1706121525;
									dictionary187[key183] = _7E6B08A7;
									Dictionary<uint, _19C46BFE> dictionary188 = _37ED57E7;
									num = 0x22D478C2 | num;
									uint key184 = num + 1342865645;
									num /= 1423929504;
									dictionary188[key184] = _348D306A;
									num = 1644122687 * num;
									if (584977485 > num)
									{
										goto IL_003e;
									}
									num = 94192510 / num;
									Dictionary<uint, _19C46BFE> dictionary189 = _37ED57E7;
									num = (uint)(795110244 << (int)num);
									int key185 = (int)num + -795110048;
									num = (uint)(402531126 << (int)num);
									num <<= 11;
									dictionary189[(uint)key185] = _2AF82BD4;
									num = 465534199 * num;
									num = 0x3CCC33A5 ^ num;
									Dictionary<uint, _19C46BFE> dictionary190 = _37ED57E7;
									num <<= 16;
									int key186 = (int)num + -866451259;
									num |= 0x11866D9F;
									num <<= 31;
									num = 1540177983 % num;
									_19C46BFE value97 = _28F05C6A;
									num %= 711930323;
									dictionary190[(uint)key186] = value97;
									num *= 55978817;
									Dictionary<uint, _19C46BFE> dictionary191 = _37ED57E7;
									num ^= 0x62E05E24;
									uint key187 = num + 1426461897;
									num = 2027647697 % num;
									dictionary191[key187] = _1F3A06D2;
									if (181031706 == num)
									{
										goto IL_003e;
									}
									Dictionary<uint, _19C46BFE> dictionary192 = _37ED57E7;
									num >>= 10;
									int key188 = (int)num + -1979925;
									num %= 124462689;
									num = 1136621498u >> (int)num;
									num <<= 14;
									dictionary192[(uint)key188] = _32565EA6;
									if (528886560 <= num)
									{
										goto IL_003e;
									}
									Dictionary<uint, _19C46BFE> dictionary193 = _37ED57E7;
									int key189 = (int)num + -65336;
									num = 1433025569u >> (int)num;
									num = 0x197D042C ^ num;
									dictionary193[(uint)key189] = _14D24103;
									num >>= 1;
									if (1502442104 << (int)num == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary194 = _37ED57E7;
									uint key190 = num ^ 0x260B9CCF;
									num |= 0x5E7A2708;
									dictionary194[key190] = _753C322B;
									if (num >> 18 == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary195 = _37ED57E7;
									num %= 734929590;
									uint key191 = num - 652179672;
									num = 0x36F64A09 & num;
									num = 2494887u >> (int)num;
									_19C46BFE value98 = _753C322B;
									num *= 144126931;
									dictionary195[key191] = value98;
									if (num < 1413823778)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary196 = _37ED57E7;
									num <<= 20;
									uint key192 = num ^ 0x1A5000CB;
									num = (uint)(746805280 << (int)num);
									num |= 0x24406DE7;
									num = (uint)(560337975 << (int)num);
									dictionary196[key192] = _34042A95;
									if (num <= 997009897)
									{
										break;
									}
									num = (uint)(1856182588 << (int)num);
									Dictionary<uint, _19C46BFE> dictionary197 = _37ED57E7;
									num = 0x22393017 & num;
									uint key193 = num ^ 0x222110D8;
									num *= 1419727601;
									_19C46BFE value99 = _67880719;
									num = 0x620A411F ^ num;
									dictionary197[key193] = value99;
									num >>= 14;
									if (num == 1183996154)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary198 = _37ED57E7;
									uint key194 = num ^ 0x9A2E;
									num = (uint)(1765414512 << (int)num);
									num |= 0x5AB644C;
									dictionary198[key194] = _4DB576CF;
									num = 0x6E045605 & num;
									Dictionary<uint, _19C46BFE> dictionary199 = _37ED57E7;
									num = 546447339 - num;
									int key195 = (int)num ^ -728643287;
									num = (uint)(858745562 << (int)num);
									_19C46BFE value100 = _01BE1822;
									num -= 427187639;
									dictionary199[(uint)key195] = value100;
									num = 1800995226 * num;
									Dictionary<uint, _19C46BFE> dictionary200 = _37ED57E7;
									num = 0x5C10D27 ^ num;
									int key196 = (int)num + -27162366;
									num = 460406717 * num;
									num = 2052915717 % num;
									num = 0x7DBC24DA ^ num;
									dictionary200[(uint)key196] = _6DC22504;
									num /= 1727269224;
									if (num >= 752169320)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary201 = _37ED57E7;
									num <<= 20;
									uint key197 = num ^ 0xD0;
									num ^= 0x1F630567;
									_19C46BFE value101 = _3C2D1285;
									num = 644092138 - num;
									dictionary201[key197] = value101;
									if ((0xE573829 ^ num) == 0)
									{
										goto end_IL_009a;
									}
									Dictionary<uint, _19C46BFE> dictionary202 = _37ED57E7;
									int key198 = (int)num + -117508786;
									num = 343551399u >> (int)num;
									num = 689061528 - num;
									dictionary202[(uint)key198] = _163950BA;
									num |= 0x223665E4;
									Dictionary<uint, _19C46BFE> dictionary203 = _37ED57E7;
									uint key199 = num ^ 0x26B6FD36;
									num -= 124004225;
									num -= 2108501488;
									_19C46BFE value102 = _163950BA;
									num *= 1341331022;
									dictionary203[key199] = value102;
									num |= 0x45707D6C;
									num = 128018766u >> (int)num;
									Dictionary<uint, _19C46BFE> dictionary204 = _37ED57E7;
									uint key200 = num ^ 0x1E56;
									num = 1470250190 / num;
									dictionary204[key200] = _753C322B;
									if (num == 682647273)
									{
										break;
									}
									Dictionary<uint, _19C46BFE> dictionary205 = _37ED57E7;
									uint key201 = num - 187967;
									num *= 1252996826;
									num %= 1481998123;
									_19C46BFE value103 = _06A60CD1;
									num /= 544808375;
									dictionary205[key201] = value103;
									num = 0x767A3CE0 | num;
									if ((0x24E95B82 & num) == 0)
									{
										continue;
									}
									goto IL_37d8;
								}
								goto end_IL_003e;
								IL_37d8:
								num += 1074748895;
								Dictionary<uint, _19C46BFE> dictionary206 = _37ED57E7;
								int key202 = (int)num ^ -1232496108;
								_19C46BFE value104 = _3CB70A58;
								num %= 883767059;
								dictionary206[(uint)key202] = value104;
								Dictionary<uint, _19C46BFE> dictionary207 = _37ED57E7;
								num = 1004567572 / num;
								uint key203 = num ^ 0xD4;
								num = 702050039 - num;
								_19C46BFE value105 = _14D24103;
								num = 1989896034 / num;
								dictionary207[key203] = value105;
								Dictionary<uint, _19C46BFE> dictionary208 = _37ED57E7;
								int key204 = (int)num - -213;
								_19C46BFE value106 = _1F3A06D2;
								num = 0x625220B8 & num;
								dictionary208[(uint)key204] = value106;
								if (2093971869 == num)
								{
									break;
								}
								Dictionary<uint, _19C46BFE> dictionary209 = _37ED57E7;
								uint key205 = num + 216;
								num <<= 31;
								num = 1370695643 - num;
								_19C46BFE value107 = _348D306A;
								num = 0x43272355 & num;
								dictionary209[key205] = value107;
								num %= 1428583402;
								if (1918189364 / num != 0)
								{
									Dictionary<uint, _19C46BFE> dictionary210 = _37ED57E7;
									num = 0x656507C | num;
									int key206 = (int)num + -1199010468;
									num |= 0x706805;
									num %= 818033434;
									num &= 0x40202BC2;
									dictionary210[(uint)key206] = _1BA85A41;
									num = 1908037983 * num;
									Dictionary<uint, _19C46BFE> dictionary211 = _37ED57E7;
									int key207 = (int)num + -1354105252;
									num = 0x1A191498 & num;
									dictionary211[(uint)key207] = _08952BA9;
									num -= 1706648346;
									if (832204736 <= num)
									{
										Dictionary<uint, _19C46BFE> dictionary212 = _37ED57E7;
										uint key208 = num + 1437164509;
										num ^= 0x785B7663;
										num = 0x64E55873 & num;
										dictionary212[key208] = _1BA85A41;
										num |= 0x36927CCF;
										Dictionary<uint, _19C46BFE> dictionary213 = _37ED57E7;
										uint key209 = num - 1989639171;
										num = 1969184320 * num;
										num += 1727674513;
										dictionary213[key209] = _5B994F51;
										num = 1549671850 - num;
										num = 0x5A9715FF ^ num;
										Dictionary<uint, _19C46BFE> dictionary214 = _37ED57E7;
										num <<= 29;
										int key210 = (int)num - -1073742045;
										num = 0xF9179F5 & num;
										num = (uint)(561930493 << (int)num);
										_19C46BFE value108 = _163950BA;
										num -= 1658213093;
										dictionary214[(uint)key210] = value108;
										if (num >> 2 == 0)
										{
											goto IL_0087;
										}
										num |= 0x2BD55A7D;
										Dictionary<uint, _19C46BFE> dictionary215 = _37ED57E7;
										int key211 = (int)num ^ -1073914205;
										num += 514421916;
										num %= 1487160454;
										_19C46BFE value109 = _154C653A;
										num = 1793227398 * num;
										dictionary215[(uint)key211] = value109;
										num |= 0x75B769A1;
										Dictionary<uint, _19C46BFE> dictionary216 = _37ED57E7;
										uint key212 = num ^ 0x75BFFD30;
										num = 0x106E495E ^ num;
										num ^= 0x140D174E;
										dictionary216[key212] = _1FC105EF;
										Dictionary<uint, _19C46BFE> dictionary217 = _37ED57E7;
										int key213 = (int)num + -1910285087;
										num += 1696285350;
										_19C46BFE value110 = _4F1657F9;
										num = (uint)(529943855 << (int)num);
										dictionary217[(uint)key213] = value110;
										num = (uint)(665471422 << (int)num);
										if (num == 456273657)
										{
											goto end_IL_003e;
										}
										num >>= 5;
										Dictionary<uint, _19C46BFE> dictionary218 = _37ED57E7;
										uint key214 = num ^ 0x13D52AC;
										num = (uint)(2052997022 << (int)num);
										dictionary218[key214] = _5B994F51;
										num = 1780890310u >> (int)num;
										if (num < 482177763)
										{
											break;
										}
										num = 853566409 % num;
										Dictionary<uint, _19C46BFE> dictionary219 = _37ED57E7;
										int key215 = (int)num + -853566183;
										num = 1312979883 % num;
										num = 0x20C333CA ^ num;
										num = 0x27B719D7 | num;
										_19C46BFE value111 = _78DA3BAD;
										num = 0x1D162E64 & num;
										dictionary219[(uint)key215] = value111;
										if (num <= 1533966408)
										{
											Dictionary<uint, _19C46BFE> dictionary220 = _37ED57E7;
											uint key216 = num - 487992193;
											num |= 0x6174123D;
											num &= 0x601D2F4F;
											_19C46BFE value112 = _154C653A;
											num = 0x7E6A34FA | num;
											dictionary220[key216] = value112;
											num = 1811687652 / num;
											Dictionary<uint, _19C46BFE> dictionary221 = _37ED57E7;
											num = 2070028955 - num;
											int key217 = (int)num + -2070028727;
											num ^= 0x474C5D57;
											_19C46BFE value113 = _01BE1822;
											num /= 1273246394;
											dictionary221[(uint)key217] = value113;
											if (num >= 1463254967)
											{
												break;
											}
											num <<= 25;
											Dictionary<uint, _19C46BFE> dictionary222 = _37ED57E7;
											num -= 1290732257;
											int key218 = (int)num - -1290732486;
											num = 979528213u >> (int)num;
											_19C46BFE value114 = _348D306A;
											num = 951742279 - num;
											dictionary222[(uint)key218] = value114;
											num ^= 0x1D6A36F7;
											if (922102810 < num)
											{
												break;
											}
											Dictionary<uint, _19C46BFE> dictionary223 = _37ED57E7;
											uint key219 = num - 634411210;
											num &= 0x59AC22BC;
											_19C46BFE value115 = _154C653A;
											num &= 0x738857D3;
											dictionary223[key219] = value115;
											if (561788382 % num != 0)
											{
												num >>= 29;
												Dictionary<uint, _19C46BFE> dictionary224 = _37ED57E7;
												num &= 0x58CA7231;
												uint key220 = num + 231;
												num = (uint)(1436439038 << (int)num);
												dictionary224[key220] = _753C322B;
												num = 1232237192 - num;
												if (139800583 >= num)
												{
													goto end_IL_003e;
												}
												Dictionary<uint, _19C46BFE> dictionary225 = _37ED57E7;
												int key221 = (int)num - -204202078;
												num = (uint)(1902592478 << (int)num);
												num = 1346712843 + num;
												num += 631965493;
												dictionary225[(uint)key221] = _381C352C;
												num |= 0x136A1DF0;
												num /= 505291777;
												Dictionary<uint, _19C46BFE> dictionary226 = _37ED57E7;
												int key222 = (int)num - -233;
												num = 0x3EDA2439 | num;
												num -= 1405373440;
												_19C46BFE value116 = _2AF82BD4;
												num /= 875305551;
												dictionary226[(uint)key222] = value116;
												num ^= 0x3951782C;
												if ((num ^ 0x155205E1) == 0)
												{
													continue;
												}
												num = 735200558 - num;
												Dictionary<uint, _19C46BFE> dictionary227 = _37ED57E7;
												num = 0x47FB354F ^ num;
												int key223 = (int)num ^ -1250166621;
												num &= 0x21245CC6;
												dictionary227[(uint)key223] = _7E6B08A7;
												num = 0x365653D1 & num;
												if (num % 809185243 == 0)
												{
													break;
												}
												Dictionary<uint, _19C46BFE> dictionary228 = _37ED57E7;
												int key224 = (int)num + -536891221;
												num <<= 8;
												num <<= 20;
												dictionary228[(uint)key224] = _082D12F7;
												num = 0x38917FA4 | num;
												if (num * 1368467928 == 0)
												{
													break;
												}
												Dictionary<uint, _19C46BFE> dictionary229 = _37ED57E7;
												num -= 879691117;
												dictionary229[num ^ 0x4227ADB] = _224B291D;
												if (num == 103951905)
												{
													break;
												}
												Dictionary<uint, _19C46BFE> dictionary230 = _37ED57E7;
												num &= 0x259F7EA3;
												uint key225 = num ^ 0x4027ACE;
												num = 179246164 % num;
												dictionary230[key225] = _7E6B08A7;
												if (num == 1424916479)
												{
													goto end_IL_003e;
												}
												num += 1325273251;
												Dictionary<uint, _19C46BFE> dictionary231 = _37ED57E7;
												num ^= 0x317A154A;
												int key226 = (int)num + -1624384781;
												num = 428355842 * num;
												num -= 371340852;
												_19C46BFE value117 = _748B5AA0;
												num += 67398529;
												dictionary231[(uint)key226] = value117;
												num <<= 13;
												Dictionary<uint, _19C46BFE> dictionary232 = _37ED57E7;
												num = 1883988540 % num;
												uint key227 = num - 1883988301;
												num <<= 30;
												num = 0x25F821FE ^ num;
												_19C46BFE value118 = _64351E3E;
												num = 204932390 - num;
												dictionary232[key227] = value118;
												num *= 1820475665;
												Dictionary<uint, _19C46BFE> dictionary233 = _37ED57E7;
												num <<= 16;
												uint key228 = num - 1034419984;
												num *= 837288214;
												num -= 1911693193;
												dictionary233[key228] = _64351E3E;
												Dictionary<uint, _19C46BFE> dictionary234 = _37ED57E7;
												uint key229 = num + 2105679994;
												num *= 1515604497;
												dictionary234[key229] = _154C653A;
												num %= 1409169115;
												num %= 2097890717;
												Dictionary<uint, _19C46BFE> dictionary235 = _37ED57E7;
												uint key230 = num ^ 0x4B384D15;
												num = 0x22596F2C ^ num;
												num = 1684809412 - num;
												_19C46BFE value119 = _64351E3E;
												num /= 1488530866;
												dictionary235[key230] = value119;
												num = 607599505 / num;
												if (2034397133 < num)
												{
													break;
												}
												num = 1984066525 / num;
												Dictionary<uint, _19C46BFE> dictionary236 = _37ED57E7;
												uint key231 = num ^ 0xF5;
												num = 0x33343A92 ^ num;
												num /= 1960801753;
												dictionary236[key231] = _16E87D4E;
												num >>= 16;
												Dictionary<uint, _19C46BFE> dictionary237 = _37ED57E7;
												num %= 1473338678;
												int key232 = (int)num - -244;
												num ^= 0x351178B6;
												num = 0x768176C4 | num;
												dictionary237[(uint)key232] = _6DC22504;
												if (1793535939 >= num)
												{
													goto end_IL_003e;
												}
												Dictionary<uint, _19C46BFE> dictionary238 = _37ED57E7;
												num /= 378883613;
												uint key233 = num ^ 0xF0;
												num = 341861824 % num;
												num -= 482887920;
												_19C46BFE value120 = _348D306A;
												num = 0xFA81CE8 | num;
												dictionary238[key233] = value120;
												num /= 2018733101;
												Dictionary<uint, _19C46BFE> dictionary239 = _37ED57E7;
												num = (uint)(997590996 << (int)num);
												uint key234 = num - 1995181746;
												num = 1689323716 % num;
												_19C46BFE value121 = _77F911BF;
												num -= 1936277687;
												dictionary239[key234] = value121;
												num = 1633489096 * num;
												Dictionary<uint, _19C46BFE> dictionary240 = _37ED57E7;
												num ^= 0x7F4118FC;
												int key235 = (int)num - -384892451;
												_19C46BFE value122 = _562978D7;
												num &= 0x79B645C9;
												dictionary240[(uint)key235] = value122;
												if (num < 984165385)
												{
													goto IL_0087;
												}
												num &= 0x71562D3E;
												Dictionary<uint, _19C46BFE> dictionary241 = _37ED57E7;
												num ^= 0x66E85ABA;
												uint key236 = num ^ 0x7EE5A42;
												num /= 678699871;
												dictionary241[key236] = _06A60CD1;
												num += 1969639434;
												Dictionary<uint, _19C46BFE> dictionary242 = _37ED57E7;
												uint key237 = num ^ 0x756650F3;
												num >>= 31;
												dictionary242[key237] = _4DB576CF;
												num = 0x1BA751C8 | num;
												if (689064182 < num)
												{
													goto end_IL_003e;
												}
												num -= 173437534;
												Dictionary<uint, _19C46BFE> dictionary243 = _37ED57E7;
												uint key238 = num ^ 0x1150DF90;
												_19C46BFE value123 = _5B994F51;
												num <<= 19;
												dictionary243[key238] = value123;
												if (1738960817 == num)
												{
													goto end_IL_003e;
												}
												num %= 1812991625;
												Dictionary<uint, _19C46BFE> dictionary244 = _37ED57E7;
												uint key239 = num - 590340595;
												num >>= 24;
												num ^= 0x563C42F7;
												_19C46BFE value124 = _78760B02;
												num = 2041917117 + num;
												dictionary244[key239] = value124;
												num = 112789278u >> (int)num;
												Dictionary<uint, _19C46BFE> dictionary245 = _37ED57E7;
												num = 0x56FC3A5D ^ num;
												int key240 = (int)num + -1459369989;
												num /= 817237713;
												num = 0x3CED63CE ^ num;
												_19C46BFE value125 = _6DC22504;
												num = (uint)(1378776362 << (int)num);
												dictionary245[(uint)key240] = value125;
												num -= 816447873;
												if (num << 30 == 0)
												{
													break;
												}
												num = (uint)(750994942 << (int)num);
												Dictionary<uint, _19C46BFE> dictionary246 = _37ED57E7;
												num = 493307109 + num;
												uint key241 = num ^ 0x1D674418;
												_19C46BFE value126 = _348D306A;
												num /= 1885210530;
												dictionary246[key241] = value126;
												if (1818972400 == num)
												{
													break;
												}
												Dictionary<uint, _19C46BFE> dictionary247 = _37ED57E7;
												uint key242 = num ^ 0xFE;
												num = (uint)(55575982 << (int)num);
												dictionary247[key242] = _348D306A;
												if (202781089 + num != 0)
												{
													num ^= 0x32B952E1;
													Dictionary<uint, _19C46BFE> dictionary248 = _37ED57E7;
													num &= 0x539458E2;
													uint key243 = num ^ 0x118050BD;
													num >>= 11;
													num = 927341200 - num;
													num *= 1913587560;
													_19C46BFE value127 = _76A86CFF;
													num = 1720667212u >> (int)num;
													dictionary248[key243] = value127;
													return;
												}
											}
										}
									}
									goto IL_003e;
								}
								goto IL_006c;
								continue;
								end_IL_009a:
								break;
							}
							break;
						}
						break;
					}
					goto end_IL_0025;
					continue;
					end_IL_003e:
					break;
				}
				continue;
				end_IL_0025:
				break;
			}
		}
	}
}

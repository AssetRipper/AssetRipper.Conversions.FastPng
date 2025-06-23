using System;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng;

internal static partial class GlobalVariableInitializers
{
	private static int Get_Avx2WmemEnabledWeakValue()
	{
		return 0;
	}

	internal static void Initialize_Avx2WmemEnabledWeakValue()
	{
		GlobalVariables.Avx2WmemEnabledWeakValue = Get_Avx2WmemEnabledWeakValue();
	}

	private static InlineArray_29_oeds4ea Get_String_uxbkrtb()
	{
		return InlineArrayHelper.Create<InlineArray_29_oeds4ea, char>("../../../../Samples\\fpng.cpp\0".ToCharacterSpan());
	}

	internal static void Initialize_String_uxbkrtb()
	{
		GlobalVariables.String_uxbkrtb = Get_String_uxbkrtb();
	}

	private static InlineArray_2_oeds4ea Get_String_kdrammb()
	{
		return InlineArrayHelper.Create<InlineArray_2_oeds4ea, char>("0\0".ToCharacterSpan());
	}

	internal static void Initialize_String_kdrammb()
	{
		GlobalVariables.String_kdrammb = Get_String_kdrammb();
	}

	private static InlineArray_32_oeds4ea Get_String_bik4erc()
	{
		return InlineArrayHelper.Create<InlineArray_32_oeds4ea, char>("temp_buf_ofs <= temp_buf.size()\0".ToCharacterSpan());
	}

	internal static void Initialize_String_bik4erc()
	{
		GlobalVariables.String_bik4erc = Get_String_bik4erc();
	}

	private static InlineArray_40_oeds4ea Get_String_dqvhqxc()
	{
		return InlineArrayHelper.Create<InlineArray_40_oeds4ea, char>("(out_ofs + zlib_size) <= out_buf.size()\0".ToCharacterSpan());
	}

	internal static void Initialize_String_dqvhqxc()
	{
		GlobalVariables.String_dqvhqxc = Get_String_dqvhqxc();
	}

	private static InlineArray_5_w3otm9c Get_s_color_type()
	{
		return InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>(new byte[5] { 0, 0, 4, 2, 6 });
	}

	internal static void Initialize_s_color_type()
	{
		GlobalVariables.s_color_type = Get_s_color_type();
	}

	private static InlineArray_17_w3otm9c Get_String_nz3h57a()
	{
		return InlineArrayHelper.Create<InlineArray_17_w3otm9c, byte>(new byte[17]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 73, 69,
			78, 68, 174, 66, 96, 130, 0
		});
	}

	internal static void Initialize_String_nz3h57a()
	{
		GlobalVariables.String_nz3h57a = Get_String_nz3h57a();
	}

	private static InlineArray_4_vjlif9a Get_g_crc32_4()
	{
		InlineArray_4_vjlif9a buffer = default(InlineArray_4_vjlif9a);
		Span<InlineArray_256_vqkfj7a> span = buffer.AsSpan<InlineArray_4_vjlif9a, InlineArray_256_vqkfj7a>();
		span[0] = InlineArrayHelper.Create<InlineArray_256_vqkfj7a, int>(new int[256]
		{
			0, 1996959894, -301047508, -1727442502, 124634137, 1886057615, -379345611, -1637575261, 249268274, 2044508324,
			-522852066, -1747789432, 162941995, 2125561021, -407360249, -1866523247, 498536548, 1789927666, -205950648, -2067906082,
			450548861, 1843258603, -187386543, -2083289657, 325883990, 1684777152, -43845254, -1973040660, 335633487, 1661365465,
			-99664541, -1928851979, 997073096, 1281953886, -715111964, -1570279054, 1006888145, 1258607687, -770865667, -1526024853,
			901097722, 1119000684, -608450090, -1396901568, 853044451, 1172266101, -589951537, -1412350631, 651767980, 1373503546,
			-925412992, -1076862698, 565507253, 1454621731, -809855591, -1195530993, 671266974, 1594198024, -972236366, -1324619484,
			795835527, 1483230225, -1050600021, -1234817731, 1994146192, 31158534, -1731059524, -271249366, 1907459465, 112637215,
			-1614814043, -390540237, 2013776290, 251722036, -1777751922, -519137256, 2137656763, 141376813, -1855689577, -429695999,
			1802195444, 476864866, -2056965928, -228458418, 1812370925, 453092731, -2113342271, -183516073, 1706088902, 314042704,
			-1950435094, -54949764, 1658658271, 366619977, -1932296973, -69972891, 1303535960, 984961486, -1547960204, -725929758,
			1256170817, 1037604311, -1529756563, -740887301, 1131014506, 879679996, -1385723834, -631195440, 1141124467, 855842277,
			-1442165665, -586318647, 1342533948, 654459306, -1106571248, -921952122, 1466479909, 544179635, -1184443383, -832445281,
			1591671054, 702138776, -1328506846, -942167884, 1504918807, 783551873, -1212326853, -1061524307, -306674912, -1698712650,
			62317068, 1957810842, -355121351, -1647151185, 81470997, 1943803523, -480048366, -1805370492, 225274430, 2053790376,
			-468791541, -1828061283, 167816743, 2097651377, -267414716, -2029476910, 503444072, 1762050814, -144550051, -2140837941,
			426522225, 1852507879, -19653770, -1982649376, 282753626, 1742555852, -105259153, -1900089351, 397917763, 1622183637,
			-690576408, -1580100738, 953729732, 1340076626, -776247311, -1497606297, 1068828381, 1219638859, -670225446, -1358292148,
			906185462, 1090812512, -547295293, -1469587627, 829329135, 1181335161, -882789492, -1134132454, 628085408, 1382605366,
			-871598187, -1156888829, 570562233, 1426400815, -977650754, -1296233688, 733239954, 1555261956, -1026031705, -1244606671,
			752459403, 1541320221, -1687895376, -328994266, 1969922972, 40735498, -1677130071, -351390145, 1913087877, 83908371,
			-1782625662, -491226604, 2075208622, 213261112, -1831694693, -438977011, 2094854071, 198958881, -2032938284, -237706686,
			1759359992, 534414190, -2118248755, -155638181, 1873836001, 414664567, -2012718362, -15766928, 1711684554, 285281116,
			-1889165569, -127750551, 1634467795, 376229701, -1609899400, -686959890, 1308918612, 956543938, -1486412191, -799009033,
			1231636301, 1047427035, -1362007478, -640263460, 1088359270, 936918000, -1447252397, -558129467, 1202900863, 817233897,
			-1111625188, -893730166, 1404277552, 615818150, -1160759803, -841546093, 1423857449, 601450431, -1285129682, -1000256840,
			1567103746, 711928724, -1274298825, -1022587231, 1510334235, 755167117
		});
		span[1] = InlineArrayHelper.Create<InlineArray_256_vqkfj7a, int>(new int[256]
		{
			0, 421212481, 842424962, 724390851, 1684849924, 2105013317, 1448781702, 1329698503, -925267448, -775767223,
			-84940662, -470492725, -1397403892, -1246855603, -1635570290, -2020074289, 1254232657, 1406739216, 2029285587, 1643069842,
			783210325, 934667796, 479770071, 92505238, -2112120743, -1694455528, -1339163941, -1456026726, -428384931, -9671652,
			-733921313, -849736034, -1786501982, -1935731229, -1481488864, -1096190111, -236396122, -386674457, -1008827612, -624577947,
			1566420650, 1145479147, 1869335592, 1987116393, 959540142, 539646703, 185010476, 303839341, -549046541, -966981710,
			-311405455, -194288336, -1154812937, -1573797194, -1994616459, -1878548428, 396344571, 243568058, 631889529, 1018359608,
			1945336319, 1793607870, 1103436669, 1490954812, -260485371, -379421116, -1034998393, -615244602, -1810527743, -1928414400,
			-1507596157, -1086793278, 950060301, 565965900, 177645455, 328046286, 1556873225, 1171730760, 1861902987, 2011255754,
			-1162125996, -1549767659, -2004009002, -1852436841, -556296112, -942888687, -320734510, -168113261, 1919080284, 1803150877,
			1079293406, 1498383519, 370020952, 253043481, 607678682, 1025720731, 1711106983, 2095471334, 1472923941, 1322268772,
			26324643, 411738082, 866634785, 717028704, -1390091857, -1270886162, -1626176723, -2046184852, -918018901, -799861270,
			-75610583, -496666776, 792689142, 908347575, 487136116, 68299317, 1263779058, 1380486579, 2036719216, 1618931505,
			-404294658, -16923969, -707751556, -859070403, -2088093958, -1701771333, -1313057672, -1465424583, 998479947, 580430090,
			162921161, 279890824, 1609522511, 1190423566, 1842954189, 1958874764, -212200893, -364829950, -1049857855, -663273088,
			-1758013625, -1909594618, -1526680123, -1139047292, 1900120602, 1750776667, 1131931800, 1517083097, 355290910, 204897887,
			656092572, 1040194781, -1181220846, -1602014893, -1951505776, -1833610287, -571161322, -990907305, -272455788, -153512235,
			-1375224599, -1222865496, -1674453397, -2060783830, -898926099, -747616084, -128115857, -515495378, 1725839073, 2143618976,
			1424512099, 1307796770, 45282277, 464110244, 813994343, 698327078, -456806728, -35741703, -688665542, -806814341,
			-2136380484, -1716364547, -1298200258, -1417398145, 740041904, 889656817, 506086962, 120682355, 1215357364, 1366020341,
			2051441462, 1667084919, -872753330, -756947441, -104024628, -522746739, -1349119414, -1232264437, -1650429752, -2068102775,
			52649286, 439905287, 823476164, 672009861, 1733269570, 2119477507, 1434057408, 1281543041, -2126985953, -1742474146,
			-1290885219, -1441425700, -447479781, -61918886, -681418087, -830909480, 1239502615, 1358593622, 2077699477, 1657543892,
			764250643, 882293586, 532408465, 111204816, 1585378284, 1197851309, 1816695150, 1968414767, 974272232, 587794345,
			136598634, 289367339, -1767409180, -1883486043, -1533994138, -1115018713, -221528864, -338653791, -1057104286, -639176925,
			347922877, 229101820, 646611775, 1066513022, 1892689081, 1774917112, 1122387515, 1543337850, -597333067, -981574924,
			-296548041, -146261898, -1207325007, -1592614928, -1975530445, -1826292366
		});
		span[2] = InlineArrayHelper.Create<InlineArray_256_vqkfj7a, int>(new int[256]
		{
			0, 29518391, 59036782, 38190681, 118073564, 114017003, 76381362, 89069189, 236147128, 265370511,
			228034006, 206958561, 152762724, 148411219, 178138378, 190596925, 472294256, 501532999, 530741022, 509615401,
			456068012, 451764635, 413917122, 426358261, 305525448, 334993663, 296822438, 275991697, 356276756, 352202787,
			381193850, 393929805, 944588512, 965684439, 1003065998, 973863097, 1061482044, 1049003019, 1019230802, 1023561829,
			912136024, 933002607, 903529270, 874031361, 827834244, 815125939, 852716522, 856752605, 611050896, 631869351,
			669987326, 640506825, 593644876, 580921211, 551983394, 556069653, 712553512, 733666847, 704405574, 675154545,
			762387700, 749958851, 787859610, 792175277, 1889177024, 1901651959, 1931368878, 1927033753, 2006131996, 1985040171,
			1947726194, 1976933189, 2122964088, 2135668303, 2098006038, 2093965857, 2038461604, 2017599123, 2047123658, 2076625661,
			1824272048, 1836991623, 1866005214, 1861914857, 1807058540, 1786244187, 1748062722, 1777547317, 1655668488, 1668093247,
			1630251878, 1625932113, 1705433044, 1684323811, 1713505210, 1742760333, 1222101792, 1226154263, 1263738702, 1251046777,
			1339974652, 1310460363, 1281013650, 1301863845, 1187289752, 1191637167, 1161842422, 1149379777, 1103966788, 1074747507,
			1112139306, 1133218845, 1425107024, 1429406311, 1467333694, 1454888457, 1408811148, 1379576507, 1350309090, 1371438805,
			1524775400, 1528845279, 1499917702, 1487177649, 1575719220, 1546255107, 1584350554, 1605185389, -516613248, -520654409,
			-491663378, -478960167, -432229540, -402728597, -440899790, -461763323, -282703304, -287039473, -324886954, -312413087,
			-399514908, -370308909, -341100918, -362193731, -49039120, -53357881, -23630690, -11204951, -98955220, -69699045,
			-107035582, -128143755, -218044088, -222133377, -259769050, -247048431, -200719980, -171234397, -141715974, -162529331,
			-646423200, -658884777, -620984050, -616635591, -562956868, -541876341, -571137582, -600355867, -680850216, -693541137,
			-722478922, -718425471, -798841852, -777990605, -739872662, -769385891, -983630320, -996371417, -958780802, -954711991,
			-1034463540, -1013629701, -1043103070, -1072568171, -884101208, -896547425, -926319674, -922021391, -867956876, -846828221,
			-809446630, -838682323, -1850763712, -1871840137, -1842658770, -1813436391, -1767489892, -1755032405, -1792873742, -1797226299,
			-1615017992, -1635865137, -1674046570, -1644529247, -1732939996, -1720253165, -1691239606, -1695297155, -1920387792, -1941217529,
			-1911692962, -1882223767, -1971282452, -1958545445, -1996207742, -2000280651, -2087033720, -2108158273, -2145472282, -2116232495,
			-2070688684, -2058246557, -2028529606, -2032831987, -1444753248, -1474250089, -1436154674, -1415287047, -1360299908, -1356262837,
			-1385190382, -1397897691, -1477345000, -1506546897, -1535814282, -1514717375, -1594349116, -1590017037, -1552089686, -1564567651,
			-1245416496, -1274668569, -1237276738, -1216164471, -1295131892, -1290817221, -1320611998, -1333041835, -1143528856, -1173010337,
			-1202457082, -1181639631, -1126266188, -1122180989, -1084596518, -1097321235
		});
		span[3] = InlineArrayHelper.Create<InlineArray_256_vqkfj7a, int>(new int[256]
		{
			0, -1195612315, -1442199413, 313896942, -1889364137, 937357362, 627793884, -1646839623, -978048785, 2097696650,
			1874714724, -687765759, 1255587768, -227878691, -522225869, 1482887254, 1343838111, -391827206, -99573996, 1118632049,
			-545537848, 1741137837, 1970407491, -842109146, -1783791760, 756094997, 1067759611, -2028416866, 449832999, -1569484990,
			-1329192788, 142231497, -1607291074, 412010587, 171665333, -1299775280, 793786473, -1746116852, -2057703198, 1038456711,
			1703315409, -583343948, -812691622, 1999841343, -354152314, 1381529571, 1089329165, -128860312, -265553759, 1217896388,
			1512189994, -492939441, 2135519222, -940242797, -717183107, 1845280792, 899665998, -1927039189, -1617553211, 657096608,
			-1157806311, 37822588, 284462994, -1471616777, -1693165507, 598228824, 824021174, -1985873965, 343330666, -1396004849,
			-1098971167, 113467524, 1587572946, -434366537, -190203815, 1276501820, -775755899, 1769898208, 2076913422, -1015592853,
			-888336478, 1941006535, 1627703081, -642211764, 1148164341, -53215344, -295284610, 1457141531, 247015245, -1241169880,
			-1531908154, 470583459, -2116308966, 963106687, 735213713, -1821499404, 992409347, -2087022490, -1859174520, 697522413,
			-1270587308, 217581361, 508405983, -1494102086, -23928852, 1177467017, 1419450215, -332959742, 1911572667, -917753890,
			-604405712, 1665525589, 1799331996, -746338311, -1053399017, 2039091058, -463652917, 1558270126, 1314193216, -152528859,
			-1366587277, 372764438, 75645176, -1136777315, 568925988, -1722451903, -1948198993, 861712586, -312887749, 1441124702,
			1196457648, -1304107, 1648042348, -628668919, -936187417, 1888390786, 686661332, -1873675855, -2098964897, 978858298,
			-1483798141, 523464422, 226935048, -1254447507, -1119821404, 100435649, 390670639, -1342878134, 841119475, -1969352298,
			-1741963656, 546822429, 2029308235, -1068978642, -755170880, 1782671013, -141140452, 1328167289, 1570739863, -450629134,
			1298864389, -170426784, -412954226, 1608431339, -1039561134, 2058742071, 1744848601, -792976964, -1998638614, 811816591,
			584513889, -1704288764, 129869501, -1090403880, -1380684234, 352848211, 494030490, -1513215489, -1216641519, 264757620,
			-1844389427, 715964072, 941166918, -2136639965, -658086283, 1618608400, 1926213374, -898381413, 1470427426, -283601337,
			-38979159, 1158766284, 1984818694, -823031453, -599513459, 1693991400, -114329263, 1100160564, 1395044826, -342174017,
			-1275476247, 189112716, 435162722, -1588827897, 1016811966, -2077804837, -1768777419, 774831696, 643086745, -1628905732,
			-1940033262, 887166583, -1456066866, 294275499, 54519365, -1149009632, -471821962, 1532818963, 1240029693, -246071656,
			1820460577, -734109372, -963916118, 2117577167, -696303304, 1858283101, 2088143283, -993333546, 1495127663, -509497078,
			-216785180, 1269332353, 332098007, -1418260814, -1178427044, 25085497, -1666580864, 605395429, 916469259, -1910746770,
			-2040129881, 1054503362, 745528876, -1798063799, 151290352, -1313282411, -1559410309, 464596510, 1137851976, -76654291,
			-371460413, 1365741990, -860837601, 1946996346, 1723425172, -570095887
		});
		return buffer;
	}

	internal static void Initialize_g_crc32_4()
	{
		GlobalVariables.g_crc32_4 = Get_g_crc32_4();
	}

	private static InlineArray_10_oeds4ea Get_String_uc52kza()
	{
		return InlineArrayHelper.Create<InlineArray_10_oeds4ea, char>("pPrev_src\0".ToCharacterSpan());
	}

	internal static void Initialize_String_uc52kza()
	{
		GlobalVariables.String_uc52kza = Get_String_uc52kza();
	}

	private static InlineArray_22_oeds4ea Get_String_9hewgtd()
	{
		return InlineArrayHelper.Create<InlineArray_22_oeds4ea, char>("(l) >= 0 && (l) <= 16\0".ToCharacterSpan());
	}

	internal static void Initialize_String_9hewgtd()
	{
		GlobalVariables.String_9hewgtd = Get_String_9hewgtd();
	}

	private static InlineArray_20_oeds4ea Get_String_ooiduua()
	{
		return InlineArrayHelper.Create<InlineArray_20_oeds4ea, char>("(b) < (1ULL << (l))\0".ToCharacterSpan());
	}

	internal static void Initialize_String_ooiduua()
	{
		GlobalVariables.String_ooiduua = Get_String_ooiduua();
	}

	private static InlineArray_19_oeds4ea Get_String_mggwlgb()
	{
		return InlineArrayHelper.Create<InlineArray_19_oeds4ea, char>("bit_buf_size <= 64\0".ToCharacterSpan());
	}

	internal static void Initialize_String_mggwlgb()
	{
		GlobalVariables.String_mggwlgb = Get_String_mggwlgb();
	}

	private static InlineArray_256_oeds4ea Get_g_defl_len_sym()
	{
		return InlineArrayHelper.Create<InlineArray_256_oeds4ea, short>(new short[256]
		{
			257, 258, 259, 260, 261, 262, 263, 264, 265, 265,
			266, 266, 267, 267, 268, 268, 269, 269, 269, 269,
			270, 270, 270, 270, 271, 271, 271, 271, 272, 272,
			272, 272, 273, 273, 273, 273, 273, 273, 273, 273,
			274, 274, 274, 274, 274, 274, 274, 274, 275, 275,
			275, 275, 275, 275, 275, 275, 276, 276, 276, 276,
			276, 276, 276, 276, 277, 277, 277, 277, 277, 277,
			277, 277, 277, 277, 277, 277, 277, 277, 277, 277,
			278, 278, 278, 278, 278, 278, 278, 278, 278, 278,
			278, 278, 278, 278, 278, 278, 279, 279, 279, 279,
			279, 279, 279, 279, 279, 279, 279, 279, 279, 279,
			279, 279, 280, 280, 280, 280, 280, 280, 280, 280,
			280, 280, 280, 280, 280, 280, 280, 280, 281, 281,
			281, 281, 281, 281, 281, 281, 281, 281, 281, 281,
			281, 281, 281, 281, 281, 281, 281, 281, 281, 281,
			281, 281, 281, 281, 281, 281, 281, 281, 281, 281,
			282, 282, 282, 282, 282, 282, 282, 282, 282, 282,
			282, 282, 282, 282, 282, 282, 282, 282, 282, 282,
			282, 282, 282, 282, 282, 282, 282, 282, 282, 282,
			282, 282, 283, 283, 283, 283, 283, 283, 283, 283,
			283, 283, 283, 283, 283, 283, 283, 283, 283, 283,
			283, 283, 283, 283, 283, 283, 283, 283, 283, 283,
			283, 283, 283, 283, 284, 284, 284, 284, 284, 284,
			284, 284, 284, 284, 284, 284, 284, 284, 284, 284,
			284, 284, 284, 284, 284, 284, 284, 284, 284, 284,
			284, 284, 284, 284, 284, 285
		});
	}

	internal static void Initialize_g_defl_len_sym()
	{
		GlobalVariables.g_defl_len_sym = Get_g_defl_len_sym();
	}

	private static InlineArray_19_oeds4ea Get_String_bjvsuxc()
	{
		return InlineArrayHelper.Create<InlineArray_19_oeds4ea, char>("src_ofs == h * bpl\0".ToCharacterSpan());
	}

	internal static void Initialize_String_bjvsuxc()
	{
		GlobalVariables.String_bjvsuxc = Get_String_bjvsuxc();
	}

	private static InlineArray_28_oeds4ea Get_String_hsgehfc()
	{
		return InlineArrayHelper.Create<InlineArray_28_oeds4ea, char>("total_codes <= codes.size()\0".ToCharacterSpan());
	}

	internal static void Initialize_String_hsgehfc()
	{
		GlobalVariables.String_hsgehfc = Get_String_hsgehfc();
	}

	private static InlineArray_18_oeds4ea Get_String_vpte4cc()
	{
		return InlineArrayHelper.Create<InlineArray_18_oeds4ea, char>("bit_buf_size <= 7\0".ToCharacterSpan());
	}

	internal static void Initialize_String_vpte4cc()
	{
		GlobalVariables.String_vpte4cc = Get_String_vpte4cc();
	}

	private static InlineArray_76_oeds4ea Get_String_df5ko9b()
	{
		return InlineArrayHelper.Create<InlineArray_76_oeds4ea, char>("dh.m_huff_codes[1][dist_sym] == 0 && dh.m_huff_code_sizes[1][dist_sym] == 1\0".ToCharacterSpan());
	}

	internal static void Initialize_String_df5ko9b()
	{
		GlobalVariables.String_df5ko9b = Get_String_df5ko9b();
	}

	private static InlineArray_22_oeds4ea Get_String_isj2lib()
	{
		return InlineArrayHelper.Create<InlineArray_22_oeds4ea, char>("(l) >= 1 && (l) <= 16\0".ToCharacterSpan());
	}

	internal static void Initialize_String_isj2lib()
	{
		GlobalVariables.String_isj2lib = Get_String_isj2lib();
	}

	private static InlineArray_17_vqkfj7a Get_g_bitmasks()
	{
		return InlineArrayHelper.Create<InlineArray_17_vqkfj7a, int>(new int[17]
		{
			0, 1, 3, 7, 15, 31, 63, 127, 255, 511,
			1023, 2047, 4095, 8191, 16383, 32767, 65535
		});
	}

	internal static void Initialize_g_bitmasks()
	{
		GlobalVariables.g_bitmasks = Get_g_bitmasks();
	}

	private static InlineArray_256_w3otm9c Get_g_defl_len_extra()
	{
		return InlineArrayHelper.Create<InlineArray_256_w3otm9c, byte>(new byte[256]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 1, 1, 1, 1, 2, 2, 2, 2,
			2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
			2, 2, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 3, 3, 4, 4, 4, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 4, 4, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 0
		});
	}

	internal static void Initialize_g_defl_len_extra()
	{
		GlobalVariables.g_defl_len_extra = Get_g_defl_len_extra();
	}

	private static InlineArray_19_oeds4ea Get_String_2ej5tjb()
	{
		return InlineArrayHelper.Create<InlineArray_19_oeds4ea, char>("bits_to_shift < 64\0".ToCharacterSpan());
	}

	internal static void Initialize_String_2ej5tjb()
	{
		GlobalVariables.String_2ej5tjb = Get_String_2ej5tjb();
	}

	private static InlineArray_16_w3otm9c Get_String_7b7kt9c()
	{
		return InlineArrayHelper.Create<InlineArray_16_w3otm9c, byte>("vector too long\0"u8);
	}

	internal static void Initialize_String_7b7kt9c()
	{
		GlobalVariables.String_7b7kt9c = Get_String_7b7kt9c();
	}

	private unsafe static rtti_TypeDescriptor30 Get_R0_AVbad_array_new_length()
	{
		rtti_TypeDescriptor30 result = default(rtti_TypeDescriptor30);
		ref void* field_ = ref result.field_0;
		field_ = GlobalVariablePointers._7type_info;
		result.field_1 = null;
		ref InlineArray_31_w3otm9c field_2 = ref result.field_2;
		field_2 = InlineArrayHelper.Create<InlineArray_31_w3otm9c, byte>(".?AVbad_array_new_length@std@@\0"u8);
		return result;
	}

	internal static void Initialize_R0_AVbad_array_new_length()
	{
		GlobalVariables.R0_AVbad_array_new_length = Get_R0_AVbad_array_new_length();
	}

	private unsafe static eh_CatchableType Get_CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24()
	{
		eh_CatchableType result = new eh_CatchableType
		{
			field_0 = 0
		};
		ref int field_ = ref result.field_1;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVbad_array_new_length);
		result.field_2 = 0;
		result.field_3 = -1;
		result.field_4 = 0;
		result.field_5 = 24;
		ref int field_2 = ref result.field_6;
		field_2 = PointerIndices.GetIndex((delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Constructor_7fjuj3c));
		return result;
	}

	internal static void Initialize_CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24()
	{
		GlobalVariables.CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24 = Get_CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24();
	}

	private unsafe static rtti_TypeDescriptor19 Get_R0_AVbad_alloc()
	{
		rtti_TypeDescriptor19 result = default(rtti_TypeDescriptor19);
		ref void* field_ = ref result.field_0;
		field_ = GlobalVariablePointers._7type_info;
		result.field_1 = null;
		ref InlineArray_20_w3otm9c field_2 = ref result.field_2;
		field_2 = InlineArrayHelper.Create<InlineArray_20_w3otm9c, byte>(".?AVbad_alloc@std@@\0"u8);
		return result;
	}

	internal static void Initialize_R0_AVbad_alloc()
	{
		GlobalVariables.R0_AVbad_alloc = Get_R0_AVbad_alloc();
	}

	private unsafe static eh_CatchableType Get_CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24()
	{
		eh_CatchableType result = new eh_CatchableType
		{
			field_0 = 16
		};
		ref int field_ = ref result.field_1;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVbad_alloc);
		result.field_2 = 0;
		result.field_3 = -1;
		result.field_4 = 0;
		result.field_5 = 24;
		ref int field_2 = ref result.field_6;
		field_2 = PointerIndices.GetIndex((delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_alloc_Constructor_3vdoaxb));
		return result;
	}

	internal static void Initialize_CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24()
	{
		GlobalVariables.CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24 = Get_CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24();
	}

	private unsafe static rtti_TypeDescriptor19 Get_R0_AVexception()
	{
		rtti_TypeDescriptor19 result = default(rtti_TypeDescriptor19);
		ref void* field_ = ref result.field_0;
		field_ = GlobalVariablePointers._7type_info;
		result.field_1 = null;
		ref InlineArray_20_w3otm9c field_2 = ref result.field_2;
		field_2 = InlineArrayHelper.Create<InlineArray_20_w3otm9c, byte>(".?AVexception@std@@\0"u8);
		return result;
	}

	internal static void Initialize_R0_AVexception()
	{
		GlobalVariables.R0_AVexception = Get_R0_AVexception();
	}

	private unsafe static eh_CatchableType Get_CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24()
	{
		eh_CatchableType result = new eh_CatchableType
		{
			field_0 = 0
		};
		ref int field_ = ref result.field_1;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVexception);
		result.field_2 = 0;
		result.field_3 = -1;
		result.field_4 = 0;
		result.field_5 = 24;
		ref int field_2 = ref result.field_6;
		field_2 = PointerIndices.GetIndex((delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.exception_Constructor_ikocrpb));
		return result;
	}

	internal static void Initialize_CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24()
	{
		GlobalVariables.CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24 = Get_CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24();
	}

	private unsafe static eh_CatchableTypeArray_3 Get_CTA3_AVbad_array_new_length_std()
	{
		eh_CatchableTypeArray_3 result = new eh_CatchableTypeArray_3
		{
			field_0 = 3
		};
		ref InlineArray_3_vqkfj7a field_ = ref result.field_1;
		InlineArray_3_vqkfj7a buffer = default(InlineArray_3_vqkfj7a);
		Span<int> span = buffer.AsSpan<InlineArray_3_vqkfj7a, int>();
		span[0] = PointerIndices.GetIndex(GlobalVariablePointers.CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24);
		span[1] = PointerIndices.GetIndex(GlobalVariablePointers.CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24);
		span[2] = PointerIndices.GetIndex(GlobalVariablePointers.CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24);
		field_ = buffer;
		return result;
	}

	internal static void Initialize_CTA3_AVbad_array_new_length_std()
	{
		GlobalVariables.CTA3_AVbad_array_new_length_std = Get_CTA3_AVbad_array_new_length_std();
	}

	private unsafe static eh_ThrowInfo Get_TI3_AVbad_array_new_length_std()
	{
		eh_ThrowInfo result = new eh_ThrowInfo
		{
			field_0 = 0
		};
		ref int field_ = ref result.field_1;
		field_ = PointerIndices.GetIndex((delegate*<void*, void>)(&GlobalFunctionImplementations.bad_array_new_length_Destructor));
		result.field_2 = 0;
		ref int field_2 = ref result.field_3;
		field_2 = PointerIndices.GetIndex(GlobalVariablePointers.CTA3_AVbad_array_new_length_std);
		return result;
	}

	internal static void Initialize_TI3_AVbad_array_new_length_std()
	{
		GlobalVariables.TI3_AVbad_array_new_length_std = Get_TI3_AVbad_array_new_length_std();
	}

	private static InlineArray_21_w3otm9c Get_String_gudorqc()
	{
		return InlineArrayHelper.Create<InlineArray_21_w3otm9c, byte>("bad array new length\0"u8);
	}

	internal static void Initialize_String_gudorqc()
	{
		GlobalVariables.String_gudorqc = Get_String_gudorqc();
	}

	private unsafe static Struct Get_Variable_4yxjuqa()
	{
		Struct result = default(Struct);
		ref InlineArray_3_gbfuvwd field_ = ref result.field_0;
		InlineArray_3_gbfuvwd buffer = default(InlineArray_3_gbfuvwd);
		Span<nint> span = buffer.AsSpan<InlineArray_3_gbfuvwd, nint>();
		unchecked
		{
			span[0] = (nint)GlobalVariablePointers.R4bad_array_new_length;
			span[1] = (nint)(delegate*<void*, int, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Delete);
			span[2] = (nint)(delegate*<void*, void*>)(&GlobalFunctionImplementations.what);
			field_ = buffer;
			return result;
		}
	}

	internal static void Initialize_Variable_4yxjuqa()
	{
		GlobalVariables.Variable_4yxjuqa = Get_Variable_4yxjuqa();
	}

	private unsafe static rtti_CompleteObjectLocator Get_R4bad_array_new_length()
	{
		rtti_CompleteObjectLocator result = new rtti_CompleteObjectLocator
		{
			field_0 = 1,
			field_1 = 0,
			field_2 = 0
		};
		ref int field_ = ref result.field_3;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVbad_array_new_length);
		ref int field_2 = ref result.field_4;
		field_2 = PointerIndices.GetIndex(GlobalVariablePointers.R3bad_array_new_length);
		ref int field_3 = ref result.field_5;
		field_3 = PointerIndices.GetIndex(GlobalVariablePointers.R4bad_array_new_length);
		return result;
	}

	internal static void Initialize_R4bad_array_new_length()
	{
		GlobalVariables.R4bad_array_new_length = Get_R4bad_array_new_length();
	}

	private unsafe static rtti_ClassHierarchyDescriptor Get_R3bad_array_new_length()
	{
		rtti_ClassHierarchyDescriptor result = new rtti_ClassHierarchyDescriptor
		{
			field_0 = 0,
			field_1 = 0,
			field_2 = 3
		};
		ref int field_ = ref result.field_3;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R2bad_array_new_length);
		return result;
	}

	internal static void Initialize_R3bad_array_new_length()
	{
		GlobalVariables.R3bad_array_new_length = Get_R3bad_array_new_length();
	}

	private unsafe static InlineArray_4_vqkfj7a Get_R2bad_array_new_length()
	{
		InlineArray_4_vqkfj7a buffer = default(InlineArray_4_vqkfj7a);
		Span<int> span = buffer.AsSpan<InlineArray_4_vqkfj7a, int>();
		span[0] = PointerIndices.GetIndex(GlobalVariablePointers.R1A_9w7p7zd);
		span[1] = PointerIndices.GetIndex(GlobalVariablePointers.R1A_vzsilob);
		span[2] = PointerIndices.GetIndex(GlobalVariablePointers.R1A_bbqer2a);
		span[3] = 0;
		return buffer;
	}

	internal static void Initialize_R2bad_array_new_length()
	{
		GlobalVariables.R2bad_array_new_length = Get_R2bad_array_new_length();
	}

	private unsafe static rtti_BaseClassDescriptor Get_R1A_9w7p7zd()
	{
		rtti_BaseClassDescriptor result = default(rtti_BaseClassDescriptor);
		ref int field_ = ref result.field_0;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVbad_array_new_length);
		result.field_1 = 2;
		result.field_2 = 0;
		result.field_3 = -1;
		result.field_4 = 0;
		result.field_5 = 64;
		ref int field_2 = ref result.field_6;
		field_2 = PointerIndices.GetIndex(GlobalVariablePointers.R3bad_array_new_length);
		return result;
	}

	internal static void Initialize_R1A_9w7p7zd()
	{
		GlobalVariables.R1A_9w7p7zd = Get_R1A_9w7p7zd();
	}

	private unsafe static rtti_BaseClassDescriptor Get_R1A_vzsilob()
	{
		rtti_BaseClassDescriptor result = default(rtti_BaseClassDescriptor);
		ref int field_ = ref result.field_0;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVbad_alloc);
		result.field_1 = 1;
		result.field_2 = 0;
		result.field_3 = -1;
		result.field_4 = 0;
		result.field_5 = 64;
		ref int field_2 = ref result.field_6;
		field_2 = PointerIndices.GetIndex(GlobalVariablePointers.R3bad_alloc);
		return result;
	}

	internal static void Initialize_R1A_vzsilob()
	{
		GlobalVariables.R1A_vzsilob = Get_R1A_vzsilob();
	}

	private unsafe static rtti_ClassHierarchyDescriptor Get_R3bad_alloc()
	{
		rtti_ClassHierarchyDescriptor result = new rtti_ClassHierarchyDescriptor
		{
			field_0 = 0,
			field_1 = 0,
			field_2 = 2
		};
		ref int field_ = ref result.field_3;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R2bad_alloc);
		return result;
	}

	internal static void Initialize_R3bad_alloc()
	{
		GlobalVariables.R3bad_alloc = Get_R3bad_alloc();
	}

	private unsafe static InlineArray_3_vqkfj7a Get_R2bad_alloc()
	{
		InlineArray_3_vqkfj7a buffer = default(InlineArray_3_vqkfj7a);
		Span<int> span = buffer.AsSpan<InlineArray_3_vqkfj7a, int>();
		span[0] = PointerIndices.GetIndex(GlobalVariablePointers.R1A_vzsilob);
		span[1] = PointerIndices.GetIndex(GlobalVariablePointers.R1A_bbqer2a);
		span[2] = 0;
		return buffer;
	}

	internal static void Initialize_R2bad_alloc()
	{
		GlobalVariables.R2bad_alloc = Get_R2bad_alloc();
	}

	private unsafe static rtti_BaseClassDescriptor Get_R1A_bbqer2a()
	{
		rtti_BaseClassDescriptor result = default(rtti_BaseClassDescriptor);
		ref int field_ = ref result.field_0;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVexception);
		result.field_1 = 0;
		result.field_2 = 0;
		result.field_3 = -1;
		result.field_4 = 0;
		result.field_5 = 64;
		ref int field_2 = ref result.field_6;
		field_2 = PointerIndices.GetIndex(GlobalVariablePointers.R3exception);
		return result;
	}

	internal static void Initialize_R1A_bbqer2a()
	{
		GlobalVariables.R1A_bbqer2a = Get_R1A_bbqer2a();
	}

	private unsafe static rtti_ClassHierarchyDescriptor Get_R3exception()
	{
		rtti_ClassHierarchyDescriptor result = new rtti_ClassHierarchyDescriptor
		{
			field_0 = 0,
			field_1 = 0,
			field_2 = 1
		};
		ref int field_ = ref result.field_3;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R2exception);
		return result;
	}

	internal static void Initialize_R3exception()
	{
		GlobalVariables.R3exception = Get_R3exception();
	}

	private unsafe static InlineArray_2_vqkfj7a Get_R2exception()
	{
		InlineArray_2_vqkfj7a buffer = default(InlineArray_2_vqkfj7a);
		Span<int> span = buffer.AsSpan<InlineArray_2_vqkfj7a, int>();
		span[0] = PointerIndices.GetIndex(GlobalVariablePointers.R1A_bbqer2a);
		span[1] = 0;
		return buffer;
	}

	internal static void Initialize_R2exception()
	{
		GlobalVariables.R2exception = Get_R2exception();
	}

	private unsafe static Struct Get_Variable_zdor9mc()
	{
		Struct result = default(Struct);
		ref InlineArray_3_gbfuvwd field_ = ref result.field_0;
		InlineArray_3_gbfuvwd buffer = default(InlineArray_3_gbfuvwd);
		Span<nint> span = buffer.AsSpan<InlineArray_3_gbfuvwd, nint>();
		unchecked
		{
			span[0] = (nint)GlobalVariablePointers.R4bad_alloc;
			span[1] = (nint)(delegate*<void*, int, void*>)(&GlobalFunctionImplementations.bad_alloc_Delete);
			span[2] = (nint)(delegate*<void*, void*>)(&GlobalFunctionImplementations.what);
			field_ = buffer;
			return result;
		}
	}

	internal static void Initialize_Variable_zdor9mc()
	{
		GlobalVariables.Variable_zdor9mc = Get_Variable_zdor9mc();
	}

	private unsafe static rtti_CompleteObjectLocator Get_R4bad_alloc()
	{
		rtti_CompleteObjectLocator result = new rtti_CompleteObjectLocator
		{
			field_0 = 1,
			field_1 = 0,
			field_2 = 0
		};
		ref int field_ = ref result.field_3;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVbad_alloc);
		ref int field_2 = ref result.field_4;
		field_2 = PointerIndices.GetIndex(GlobalVariablePointers.R3bad_alloc);
		ref int field_3 = ref result.field_5;
		field_3 = PointerIndices.GetIndex(GlobalVariablePointers.R4bad_alloc);
		return result;
	}

	internal static void Initialize_R4bad_alloc()
	{
		GlobalVariables.R4bad_alloc = Get_R4bad_alloc();
	}

	private unsafe static Struct Get_Variable_x4f2ufc()
	{
		Struct result = default(Struct);
		ref InlineArray_3_gbfuvwd field_ = ref result.field_0;
		InlineArray_3_gbfuvwd buffer = default(InlineArray_3_gbfuvwd);
		Span<nint> span = buffer.AsSpan<InlineArray_3_gbfuvwd, nint>();
		unchecked
		{
			span[0] = (nint)GlobalVariablePointers.R4exception;
			span[1] = (nint)(delegate*<void*, int, void*>)(&GlobalFunctionImplementations.exception_Delete);
			span[2] = (nint)(delegate*<void*, void*>)(&GlobalFunctionImplementations.what);
			field_ = buffer;
			return result;
		}
	}

	internal static void Initialize_Variable_x4f2ufc()
	{
		GlobalVariables.Variable_x4f2ufc = Get_Variable_x4f2ufc();
	}

	private unsafe static rtti_CompleteObjectLocator Get_R4exception()
	{
		rtti_CompleteObjectLocator result = new rtti_CompleteObjectLocator
		{
			field_0 = 1,
			field_1 = 0,
			field_2 = 0
		};
		ref int field_ = ref result.field_3;
		field_ = PointerIndices.GetIndex(GlobalVariablePointers.R0_AVexception);
		ref int field_2 = ref result.field_4;
		field_2 = PointerIndices.GetIndex(GlobalVariablePointers.R3exception);
		ref int field_3 = ref result.field_5;
		field_3 = PointerIndices.GetIndex(GlobalVariablePointers.R4exception);
		return result;
	}

	internal static void Initialize_R4exception()
	{
		GlobalVariables.R4exception = Get_R4exception();
	}

	private static InlineArray_18_w3otm9c Get_String_ja3ma5d()
	{
		return InlineArrayHelper.Create<InlineArray_18_w3otm9c, byte>("Unknown exception\0"u8);
	}

	internal static void Initialize_String_ja3ma5d()
	{
		GlobalVariables.String_ja3ma5d = Get_String_ja3ma5d();
	}

	private static InlineArray_19_w3otm9c Get_g_defl_packed_code_size_syms_swizzle()
	{
		return InlineArrayHelper.Create<InlineArray_19_w3otm9c, byte>(new byte[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		});
	}

	internal static void Initialize_g_defl_packed_code_size_syms_swizzle()
	{
		GlobalVariables.g_defl_packed_code_size_syms_swizzle = Get_g_defl_packed_code_size_syms_swizzle();
	}

	private static InlineArray_31_oeds4ea Get_String_erkdsbd()
	{
		return InlineArrayHelper.Create<InlineArray_31_oeds4ea, char>("code < DEFL_MAX_HUFF_SYMBOLS_2\0".ToCharacterSpan());
	}

	internal static void Initialize_String_erkdsbd()
	{
		GlobalVariables.String_erkdsbd = Get_String_erkdsbd();
	}

	private static InlineArray_4_w3otm9c Get_String_o9ulvgb()
	{
		return InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 2, 3, 7, 0 });
	}

	internal static void Initialize_String_o9ulvgb()
	{
		GlobalVariables.String_o9ulvgb = Get_String_o9ulvgb();
	}

	private static InlineArray_62_w3otm9c Get_g_dyn_huff_3()
	{
		return InlineArrayHelper.Create<InlineArray_62_w3otm9c, byte>(new byte[62]
		{
			120, 1, 237, 195, 3, 176, 110, 89, 122, 128,
			225, 247, 251, 214, 218, 248, 113, 124, 173, 190,
			109, 12, 50, 201, 196, 182, 109, 219, 182, 109,
			219, 182, 109, 219, 201, 36, 147, 153, 105, 235,
			246, 53, 142, 207, 143, 141, 181, 214, 151, 93,
			117, 170, 78, 117, 117, 58, 206, 77, 210, 217,
			169, 122
		});
	}

	internal static void Initialize_g_dyn_huff_3()
	{
		GlobalVariables.g_dyn_huff_3 = Get_g_dyn_huff_3();
	}

	private static InlineArray_288_chfa5zb Get_g_dyn_huff_3_codes()
	{
		InlineArray_288_chfa5zb buffer = default(InlineArray_288_chfa5zb);
		Span<anon> span = buffer.AsSpan<InlineArray_288_chfa5zb, anon>();
		span[0] = new anon
		{
			field_0 = 2,
			field_1 = 0
		};
		span[1] = new anon
		{
			field_0 = 4,
			field_1 = 2
		};
		span[2] = new anon
		{
			field_0 = 4,
			field_1 = 10
		};
		span[3] = new anon
		{
			field_0 = 5,
			field_1 = 14
		};
		span[4] = new anon
		{
			field_0 = 5,
			field_1 = 30
		};
		span[5] = new anon
		{
			field_0 = 6,
			field_1 = 25
		};
		span[6] = new anon
		{
			field_0 = 6,
			field_1 = 57
		};
		span[7] = new anon
		{
			field_0 = 6,
			field_1 = 5
		};
		span[8] = new anon
		{
			field_0 = 6,
			field_1 = 37
		};
		span[9] = new anon
		{
			field_0 = 7,
			field_1 = 3
		};
		span[10] = new anon
		{
			field_0 = 7,
			field_1 = 67
		};
		span[11] = new anon
		{
			field_0 = 7,
			field_1 = 35
		};
		span[12] = new anon
		{
			field_0 = 7,
			field_1 = 99
		};
		span[13] = new anon
		{
			field_0 = 8,
			field_1 = 11
		};
		span[14] = new anon
		{
			field_0 = 8,
			field_1 = 139
		};
		span[15] = new anon
		{
			field_0 = 8,
			field_1 = 75
		};
		span[16] = new anon
		{
			field_0 = 8,
			field_1 = 203
		};
		span[17] = new anon
		{
			field_0 = 8,
			field_1 = 43
		};
		span[18] = new anon
		{
			field_0 = 8,
			field_1 = 171
		};
		span[19] = new anon
		{
			field_0 = 8,
			field_1 = 107
		};
		span[20] = new anon
		{
			field_0 = 9,
			field_1 = 135
		};
		span[21] = new anon
		{
			field_0 = 9,
			field_1 = 391
		};
		span[22] = new anon
		{
			field_0 = 9,
			field_1 = 71
		};
		span[23] = new anon
		{
			field_0 = 9,
			field_1 = 327
		};
		span[24] = new anon
		{
			field_0 = 9,
			field_1 = 199
		};
		span[25] = new anon
		{
			field_0 = 9,
			field_1 = 455
		};
		span[26] = new anon
		{
			field_0 = 9,
			field_1 = 39
		};
		span[27] = new anon
		{
			field_0 = 9,
			field_1 = 295
		};
		span[28] = new anon
		{
			field_0 = 9,
			field_1 = 167
		};
		span[29] = new anon
		{
			field_0 = 9,
			field_1 = 423
		};
		span[30] = new anon
		{
			field_0 = 9,
			field_1 = 103
		};
		span[31] = new anon
		{
			field_0 = 10,
			field_1 = 183
		};
		span[32] = new anon
		{
			field_0 = 9,
			field_1 = 359
		};
		span[33] = new anon
		{
			field_0 = 10,
			field_1 = 695
		};
		span[34] = new anon
		{
			field_0 = 10,
			field_1 = 439
		};
		span[35] = new anon
		{
			field_0 = 10,
			field_1 = 951
		};
		span[36] = new anon
		{
			field_0 = 10,
			field_1 = 119
		};
		span[37] = new anon
		{
			field_0 = 10,
			field_1 = 631
		};
		span[38] = new anon
		{
			field_0 = 10,
			field_1 = 375
		};
		span[39] = new anon
		{
			field_0 = 10,
			field_1 = 887
		};
		span[40] = new anon
		{
			field_0 = 10,
			field_1 = 247
		};
		span[41] = new anon
		{
			field_0 = 10,
			field_1 = 759
		};
		span[42] = new anon
		{
			field_0 = 10,
			field_1 = 503
		};
		span[43] = new anon
		{
			field_0 = 11,
			field_1 = 975
		};
		span[44] = new anon
		{
			field_0 = 11,
			field_1 = 1999
		};
		span[45] = new anon
		{
			field_0 = 11,
			field_1 = 47
		};
		span[46] = new anon
		{
			field_0 = 11,
			field_1 = 1071
		};
		span[47] = new anon
		{
			field_0 = 12,
			field_1 = 1199
		};
		span[48] = new anon
		{
			field_0 = 11,
			field_1 = 559
		};
		span[49] = new anon
		{
			field_0 = 12,
			field_1 = 3247
		};
		span[50] = new anon
		{
			field_0 = 12,
			field_1 = 687
		};
		span[51] = new anon
		{
			field_0 = 11,
			field_1 = 1583
		};
		span[52] = new anon
		{
			field_0 = 12,
			field_1 = 2735
		};
		span[53] = new anon
		{
			field_0 = 12,
			field_1 = 1711
		};
		span[54] = new anon
		{
			field_0 = 12,
			field_1 = 3759
		};
		span[55] = new anon
		{
			field_0 = 12,
			field_1 = 431
		};
		span[56] = new anon
		{
			field_0 = 12,
			field_1 = 2479
		};
		span[57] = new anon
		{
			field_0 = 12,
			field_1 = 1455
		};
		span[58] = new anon
		{
			field_0 = 12,
			field_1 = 3503
		};
		span[59] = new anon
		{
			field_0 = 12,
			field_1 = 943
		};
		span[60] = new anon
		{
			field_0 = 12,
			field_1 = 2991
		};
		span[61] = new anon
		{
			field_0 = 12,
			field_1 = 1967
		};
		span[62] = new anon
		{
			field_0 = 12,
			field_1 = 4015
		};
		span[63] = new anon
		{
			field_0 = 12,
			field_1 = 111
		};
		span[64] = new anon
		{
			field_0 = 12,
			field_1 = 2159
		};
		span[65] = new anon
		{
			field_0 = 12,
			field_1 = 1135
		};
		span[66] = new anon
		{
			field_0 = 12,
			field_1 = 3183
		};
		span[67] = new anon
		{
			field_0 = 12,
			field_1 = 623
		};
		span[68] = new anon
		{
			field_0 = 12,
			field_1 = 2671
		};
		span[69] = new anon
		{
			field_0 = 12,
			field_1 = 1647
		};
		span[70] = new anon
		{
			field_0 = 12,
			field_1 = 3695
		};
		span[71] = new anon
		{
			field_0 = 12,
			field_1 = 367
		};
		span[72] = new anon
		{
			field_0 = 12,
			field_1 = 2415
		};
		span[73] = new anon
		{
			field_0 = 12,
			field_1 = 1391
		};
		span[74] = new anon
		{
			field_0 = 12,
			field_1 = 3439
		};
		span[75] = new anon
		{
			field_0 = 12,
			field_1 = 879
		};
		span[76] = new anon
		{
			field_0 = 12,
			field_1 = 2927
		};
		span[77] = new anon
		{
			field_0 = 12,
			field_1 = 1903
		};
		span[78] = new anon
		{
			field_0 = 12,
			field_1 = 3951
		};
		span[79] = new anon
		{
			field_0 = 12,
			field_1 = 239
		};
		span[80] = new anon
		{
			field_0 = 12,
			field_1 = 2287
		};
		span[81] = new anon
		{
			field_0 = 12,
			field_1 = 1263
		};
		span[82] = new anon
		{
			field_0 = 12,
			field_1 = 3311
		};
		span[83] = new anon
		{
			field_0 = 12,
			field_1 = 751
		};
		span[84] = new anon
		{
			field_0 = 12,
			field_1 = 2799
		};
		span[85] = new anon
		{
			field_0 = 12,
			field_1 = 1775
		};
		span[86] = new anon
		{
			field_0 = 12,
			field_1 = 3823
		};
		span[87] = new anon
		{
			field_0 = 12,
			field_1 = 495
		};
		span[88] = new anon
		{
			field_0 = 12,
			field_1 = 2543
		};
		span[89] = new anon
		{
			field_0 = 12,
			field_1 = 1519
		};
		span[90] = new anon
		{
			field_0 = 12,
			field_1 = 3567
		};
		span[91] = new anon
		{
			field_0 = 12,
			field_1 = 1007
		};
		span[92] = new anon
		{
			field_0 = 12,
			field_1 = 3055
		};
		span[93] = new anon
		{
			field_0 = 12,
			field_1 = 2031
		};
		span[94] = new anon
		{
			field_0 = 12,
			field_1 = 4079
		};
		span[95] = new anon
		{
			field_0 = 12,
			field_1 = 31
		};
		span[96] = new anon
		{
			field_0 = 12,
			field_1 = 2079
		};
		span[97] = new anon
		{
			field_0 = 12,
			field_1 = 1055
		};
		span[98] = new anon
		{
			field_0 = 12,
			field_1 = 3103
		};
		span[99] = new anon
		{
			field_0 = 12,
			field_1 = 543
		};
		span[100] = new anon
		{
			field_0 = 12,
			field_1 = 2591
		};
		span[101] = new anon
		{
			field_0 = 12,
			field_1 = 1567
		};
		span[102] = new anon
		{
			field_0 = 12,
			field_1 = 3615
		};
		span[103] = new anon
		{
			field_0 = 12,
			field_1 = 287
		};
		span[104] = new anon
		{
			field_0 = 12,
			field_1 = 2335
		};
		span[105] = new anon
		{
			field_0 = 12,
			field_1 = 1311
		};
		span[106] = new anon
		{
			field_0 = 12,
			field_1 = 3359
		};
		span[107] = new anon
		{
			field_0 = 12,
			field_1 = 799
		};
		span[108] = new anon
		{
			field_0 = 12,
			field_1 = 2847
		};
		span[109] = new anon
		{
			field_0 = 12,
			field_1 = 1823
		};
		span[110] = new anon
		{
			field_0 = 12,
			field_1 = 3871
		};
		span[111] = new anon
		{
			field_0 = 12,
			field_1 = 159
		};
		span[112] = new anon
		{
			field_0 = 12,
			field_1 = 2207
		};
		span[113] = new anon
		{
			field_0 = 12,
			field_1 = 1183
		};
		span[114] = new anon
		{
			field_0 = 12,
			field_1 = 3231
		};
		span[115] = new anon
		{
			field_0 = 12,
			field_1 = 671
		};
		span[116] = new anon
		{
			field_0 = 12,
			field_1 = 2719
		};
		span[117] = new anon
		{
			field_0 = 12,
			field_1 = 1695
		};
		span[118] = new anon
		{
			field_0 = 12,
			field_1 = 3743
		};
		span[119] = new anon
		{
			field_0 = 12,
			field_1 = 415
		};
		span[120] = new anon
		{
			field_0 = 12,
			field_1 = 2463
		};
		span[121] = new anon
		{
			field_0 = 12,
			field_1 = 1439
		};
		span[122] = new anon
		{
			field_0 = 12,
			field_1 = 3487
		};
		span[123] = new anon
		{
			field_0 = 12,
			field_1 = 927
		};
		span[124] = new anon
		{
			field_0 = 12,
			field_1 = 2975
		};
		span[125] = new anon
		{
			field_0 = 12,
			field_1 = 1951
		};
		span[126] = new anon
		{
			field_0 = 12,
			field_1 = 3999
		};
		span[127] = new anon
		{
			field_0 = 12,
			field_1 = 95
		};
		span[128] = new anon
		{
			field_0 = 12,
			field_1 = 2143
		};
		span[129] = new anon
		{
			field_0 = 12,
			field_1 = 1119
		};
		span[130] = new anon
		{
			field_0 = 12,
			field_1 = 3167
		};
		span[131] = new anon
		{
			field_0 = 12,
			field_1 = 607
		};
		span[132] = new anon
		{
			field_0 = 12,
			field_1 = 2655
		};
		span[133] = new anon
		{
			field_0 = 12,
			field_1 = 1631
		};
		span[134] = new anon
		{
			field_0 = 12,
			field_1 = 3679
		};
		span[135] = new anon
		{
			field_0 = 12,
			field_1 = 351
		};
		span[136] = new anon
		{
			field_0 = 12,
			field_1 = 2399
		};
		span[137] = new anon
		{
			field_0 = 12,
			field_1 = 1375
		};
		span[138] = new anon
		{
			field_0 = 12,
			field_1 = 3423
		};
		span[139] = new anon
		{
			field_0 = 12,
			field_1 = 863
		};
		span[140] = new anon
		{
			field_0 = 12,
			field_1 = 2911
		};
		span[141] = new anon
		{
			field_0 = 12,
			field_1 = 1887
		};
		span[142] = new anon
		{
			field_0 = 12,
			field_1 = 3935
		};
		span[143] = new anon
		{
			field_0 = 12,
			field_1 = 223
		};
		span[144] = new anon
		{
			field_0 = 12,
			field_1 = 2271
		};
		span[145] = new anon
		{
			field_0 = 12,
			field_1 = 1247
		};
		span[146] = new anon
		{
			field_0 = 12,
			field_1 = 3295
		};
		span[147] = new anon
		{
			field_0 = 12,
			field_1 = 735
		};
		span[148] = new anon
		{
			field_0 = 12,
			field_1 = 2783
		};
		span[149] = new anon
		{
			field_0 = 12,
			field_1 = 1759
		};
		span[150] = new anon
		{
			field_0 = 12,
			field_1 = 3807
		};
		span[151] = new anon
		{
			field_0 = 12,
			field_1 = 479
		};
		span[152] = new anon
		{
			field_0 = 12,
			field_1 = 2527
		};
		span[153] = new anon
		{
			field_0 = 12,
			field_1 = 1503
		};
		span[154] = new anon
		{
			field_0 = 12,
			field_1 = 3551
		};
		span[155] = new anon
		{
			field_0 = 12,
			field_1 = 991
		};
		span[156] = new anon
		{
			field_0 = 12,
			field_1 = 3039
		};
		span[157] = new anon
		{
			field_0 = 12,
			field_1 = 2015
		};
		span[158] = new anon
		{
			field_0 = 12,
			field_1 = 4063
		};
		span[159] = new anon
		{
			field_0 = 12,
			field_1 = 63
		};
		span[160] = new anon
		{
			field_0 = 12,
			field_1 = 2111
		};
		span[161] = new anon
		{
			field_0 = 12,
			field_1 = 1087
		};
		span[162] = new anon
		{
			field_0 = 12,
			field_1 = 3135
		};
		span[163] = new anon
		{
			field_0 = 12,
			field_1 = 575
		};
		span[164] = new anon
		{
			field_0 = 12,
			field_1 = 2623
		};
		span[165] = new anon
		{
			field_0 = 12,
			field_1 = 1599
		};
		span[166] = new anon
		{
			field_0 = 12,
			field_1 = 3647
		};
		span[167] = new anon
		{
			field_0 = 12,
			field_1 = 319
		};
		span[168] = new anon
		{
			field_0 = 12,
			field_1 = 2367
		};
		span[169] = new anon
		{
			field_0 = 12,
			field_1 = 1343
		};
		span[170] = new anon
		{
			field_0 = 12,
			field_1 = 3391
		};
		span[171] = new anon
		{
			field_0 = 12,
			field_1 = 831
		};
		span[172] = new anon
		{
			field_0 = 12,
			field_1 = 2879
		};
		span[173] = new anon
		{
			field_0 = 12,
			field_1 = 1855
		};
		span[174] = new anon
		{
			field_0 = 12,
			field_1 = 3903
		};
		span[175] = new anon
		{
			field_0 = 12,
			field_1 = 191
		};
		span[176] = new anon
		{
			field_0 = 12,
			field_1 = 2239
		};
		span[177] = new anon
		{
			field_0 = 12,
			field_1 = 1215
		};
		span[178] = new anon
		{
			field_0 = 12,
			field_1 = 3263
		};
		span[179] = new anon
		{
			field_0 = 12,
			field_1 = 703
		};
		span[180] = new anon
		{
			field_0 = 12,
			field_1 = 2751
		};
		span[181] = new anon
		{
			field_0 = 12,
			field_1 = 1727
		};
		span[182] = new anon
		{
			field_0 = 12,
			field_1 = 3775
		};
		span[183] = new anon
		{
			field_0 = 12,
			field_1 = 447
		};
		span[184] = new anon
		{
			field_0 = 12,
			field_1 = 2495
		};
		span[185] = new anon
		{
			field_0 = 12,
			field_1 = 1471
		};
		span[186] = new anon
		{
			field_0 = 12,
			field_1 = 3519
		};
		span[187] = new anon
		{
			field_0 = 12,
			field_1 = 959
		};
		span[188] = new anon
		{
			field_0 = 12,
			field_1 = 3007
		};
		span[189] = new anon
		{
			field_0 = 12,
			field_1 = 1983
		};
		span[190] = new anon
		{
			field_0 = 12,
			field_1 = 4031
		};
		span[191] = new anon
		{
			field_0 = 12,
			field_1 = 127
		};
		span[192] = new anon
		{
			field_0 = 12,
			field_1 = 2175
		};
		span[193] = new anon
		{
			field_0 = 12,
			field_1 = 1151
		};
		span[194] = new anon
		{
			field_0 = 12,
			field_1 = 3199
		};
		span[195] = new anon
		{
			field_0 = 12,
			field_1 = 639
		};
		span[196] = new anon
		{
			field_0 = 12,
			field_1 = 2687
		};
		span[197] = new anon
		{
			field_0 = 12,
			field_1 = 1663
		};
		span[198] = new anon
		{
			field_0 = 12,
			field_1 = 3711
		};
		span[199] = new anon
		{
			field_0 = 12,
			field_1 = 383
		};
		span[200] = new anon
		{
			field_0 = 12,
			field_1 = 2431
		};
		span[201] = new anon
		{
			field_0 = 12,
			field_1 = 1407
		};
		span[202] = new anon
		{
			field_0 = 12,
			field_1 = 3455
		};
		span[203] = new anon
		{
			field_0 = 12,
			field_1 = 895
		};
		span[204] = new anon
		{
			field_0 = 12,
			field_1 = 2943
		};
		span[205] = new anon
		{
			field_0 = 11,
			field_1 = 303
		};
		span[206] = new anon
		{
			field_0 = 12,
			field_1 = 1919
		};
		span[207] = new anon
		{
			field_0 = 12,
			field_1 = 3967
		};
		span[208] = new anon
		{
			field_0 = 11,
			field_1 = 1327
		};
		span[209] = new anon
		{
			field_0 = 12,
			field_1 = 255
		};
		span[210] = new anon
		{
			field_0 = 11,
			field_1 = 815
		};
		span[211] = new anon
		{
			field_0 = 11,
			field_1 = 1839
		};
		span[212] = new anon
		{
			field_0 = 11,
			field_1 = 175
		};
		span[213] = new anon
		{
			field_0 = 10,
			field_1 = 1015
		};
		span[214] = new anon
		{
			field_0 = 10,
			field_1 = 15
		};
		span[215] = new anon
		{
			field_0 = 10,
			field_1 = 527
		};
		span[216] = new anon
		{
			field_0 = 10,
			field_1 = 271
		};
		span[217] = new anon
		{
			field_0 = 10,
			field_1 = 783
		};
		span[218] = new anon
		{
			field_0 = 10,
			field_1 = 143
		};
		span[219] = new anon
		{
			field_0 = 10,
			field_1 = 655
		};
		span[220] = new anon
		{
			field_0 = 10,
			field_1 = 399
		};
		span[221] = new anon
		{
			field_0 = 10,
			field_1 = 911
		};
		span[222] = new anon
		{
			field_0 = 10,
			field_1 = 79
		};
		span[223] = new anon
		{
			field_0 = 10,
			field_1 = 591
		};
		span[224] = new anon
		{
			field_0 = 9,
			field_1 = 231
		};
		span[225] = new anon
		{
			field_0 = 10,
			field_1 = 335
		};
		span[226] = new anon
		{
			field_0 = 9,
			field_1 = 487
		};
		span[227] = new anon
		{
			field_0 = 9,
			field_1 = 23
		};
		span[228] = new anon
		{
			field_0 = 9,
			field_1 = 279
		};
		span[229] = new anon
		{
			field_0 = 9,
			field_1 = 151
		};
		span[230] = new anon
		{
			field_0 = 9,
			field_1 = 407
		};
		span[231] = new anon
		{
			field_0 = 9,
			field_1 = 87
		};
		span[232] = new anon
		{
			field_0 = 9,
			field_1 = 343
		};
		span[233] = new anon
		{
			field_0 = 9,
			field_1 = 215
		};
		span[234] = new anon
		{
			field_0 = 9,
			field_1 = 471
		};
		span[235] = new anon
		{
			field_0 = 9,
			field_1 = 55
		};
		span[236] = new anon
		{
			field_0 = 8,
			field_1 = 235
		};
		span[237] = new anon
		{
			field_0 = 8,
			field_1 = 27
		};
		span[238] = new anon
		{
			field_0 = 8,
			field_1 = 155
		};
		span[239] = new anon
		{
			field_0 = 8,
			field_1 = 91
		};
		span[240] = new anon
		{
			field_0 = 8,
			field_1 = 219
		};
		span[241] = new anon
		{
			field_0 = 8,
			field_1 = 59
		};
		span[242] = new anon
		{
			field_0 = 8,
			field_1 = 187
		};
		span[243] = new anon
		{
			field_0 = 8,
			field_1 = 123
		};
		span[244] = new anon
		{
			field_0 = 7,
			field_1 = 19
		};
		span[245] = new anon
		{
			field_0 = 7,
			field_1 = 83
		};
		span[246] = new anon
		{
			field_0 = 7,
			field_1 = 51
		};
		span[247] = new anon
		{
			field_0 = 7,
			field_1 = 115
		};
		span[248] = new anon
		{
			field_0 = 6,
			field_1 = 21
		};
		span[249] = new anon
		{
			field_0 = 6,
			field_1 = 53
		};
		span[250] = new anon
		{
			field_0 = 6,
			field_1 = 13
		};
		span[251] = new anon
		{
			field_0 = 6,
			field_1 = 45
		};
		span[252] = new anon
		{
			field_0 = 5,
			field_1 = 1
		};
		span[253] = new anon
		{
			field_0 = 5,
			field_1 = 17
		};
		span[254] = new anon
		{
			field_0 = 5,
			field_1 = 9
		};
		span[255] = new anon
		{
			field_0 = 4,
			field_1 = 6
		};
		span[256] = new anon
		{
			field_0 = 12,
			field_1 = 2303
		};
		span[257] = new anon
		{
			field_0 = 6,
			field_1 = 29
		};
		span[258] = default(anon);
		span[259] = default(anon);
		span[260] = new anon
		{
			field_0 = 8,
			field_1 = 251
		};
		span[261] = default(anon);
		span[262] = default(anon);
		span[263] = new anon
		{
			field_0 = 8,
			field_1 = 7
		};
		span[264] = default(anon);
		span[265] = new anon
		{
			field_0 = 10,
			field_1 = 847
		};
		span[266] = default(anon);
		span[267] = new anon
		{
			field_0 = 10,
			field_1 = 207
		};
		span[268] = new anon
		{
			field_0 = 12,
			field_1 = 1279
		};
		span[269] = new anon
		{
			field_0 = 10,
			field_1 = 719
		};
		span[270] = new anon
		{
			field_0 = 12,
			field_1 = 3327
		};
		span[271] = new anon
		{
			field_0 = 12,
			field_1 = 767
		};
		span[272] = new anon
		{
			field_0 = 12,
			field_1 = 2815
		};
		span[273] = new anon
		{
			field_0 = 12,
			field_1 = 1791
		};
		span[274] = new anon
		{
			field_0 = 12,
			field_1 = 3839
		};
		span[275] = new anon
		{
			field_0 = 12,
			field_1 = 511
		};
		span[276] = new anon
		{
			field_0 = 12,
			field_1 = 2559
		};
		span[277] = new anon
		{
			field_0 = 12,
			field_1 = 1535
		};
		span[278] = new anon
		{
			field_0 = 9,
			field_1 = 311
		};
		span[279] = new anon
		{
			field_0 = 12,
			field_1 = 3583
		};
		span[280] = new anon
		{
			field_0 = 12,
			field_1 = 1023
		};
		span[281] = new anon
		{
			field_0 = 12,
			field_1 = 3071
		};
		span[282] = new anon
		{
			field_0 = 10,
			field_1 = 463
		};
		span[283] = new anon
		{
			field_0 = 12,
			field_1 = 2047
		};
		span[284] = new anon
		{
			field_0 = 6,
			field_1 = 61
		};
		span[285] = new anon
		{
			field_0 = 12,
			field_1 = 4095
		};
		span[286] = default(anon);
		span[287] = default(anon);
		return buffer;
	}

	internal static void Initialize_g_dyn_huff_3_codes()
	{
		GlobalVariables.g_dyn_huff_3_codes = Get_g_dyn_huff_3_codes();
	}

	private static InlineArray_61_w3otm9c Get_g_dyn_huff_4()
	{
		return InlineArrayHelper.Create<InlineArray_61_w3otm9c, byte>(new byte[61]
		{
			120, 1, 229, 196, 99, 180, 37, 103, 218, 128,
			225, 251, 121, 171, 106, 243, 216, 231, 180, 109,
			196, 182, 51, 51, 73, 6, 201, 216, 182, 109,
			219, 182, 17, 140, 98, 219, 102, 219, 60, 125,
			172, 205, 170, 122, 159, 111, 213, 143, 179, 214,
			94, 189, 58, 153, 104, 166, 103, 190, 247, 199,
			117
		});
	}

	internal static void Initialize_g_dyn_huff_4()
	{
		GlobalVariables.g_dyn_huff_4 = Get_g_dyn_huff_4();
	}

	private static InlineArray_288_mcnvamb Get_g_dyn_huff_4_codes()
	{
		InlineArray_288_mcnvamb buffer = default(InlineArray_288_mcnvamb);
		Span<anon_11> span = buffer.AsSpan<InlineArray_288_mcnvamb, anon_11>();
		span[0] = new anon_11
		{
			field_0 = 2,
			field_1 = 0
		};
		span[1] = new anon_11
		{
			field_0 = 4,
			field_1 = 2
		};
		span[2] = new anon_11
		{
			field_0 = 5,
			field_1 = 6
		};
		span[3] = new anon_11
		{
			field_0 = 6,
			field_1 = 30
		};
		span[4] = new anon_11
		{
			field_0 = 6,
			field_1 = 62
		};
		span[5] = new anon_11
		{
			field_0 = 6,
			field_1 = 1
		};
		span[6] = new anon_11
		{
			field_0 = 7,
			field_1 = 41
		};
		span[7] = new anon_11
		{
			field_0 = 7,
			field_1 = 105
		};
		span[8] = new anon_11
		{
			field_0 = 7,
			field_1 = 25
		};
		span[9] = new anon_11
		{
			field_0 = 7,
			field_1 = 89
		};
		span[10] = new anon_11
		{
			field_0 = 7,
			field_1 = 57
		};
		span[11] = new anon_11
		{
			field_0 = 7,
			field_1 = 121
		};
		span[12] = new anon_11
		{
			field_0 = 8,
			field_1 = 117
		};
		span[13] = new anon_11
		{
			field_0 = 8,
			field_1 = 245
		};
		span[14] = new anon_11
		{
			field_0 = 8,
			field_1 = 13
		};
		span[15] = new anon_11
		{
			field_0 = 8,
			field_1 = 141
		};
		span[16] = new anon_11
		{
			field_0 = 8,
			field_1 = 77
		};
		span[17] = new anon_11
		{
			field_0 = 8,
			field_1 = 205
		};
		span[18] = new anon_11
		{
			field_0 = 8,
			field_1 = 45
		};
		span[19] = new anon_11
		{
			field_0 = 8,
			field_1 = 173
		};
		span[20] = new anon_11
		{
			field_0 = 8,
			field_1 = 109
		};
		span[21] = new anon_11
		{
			field_0 = 8,
			field_1 = 237
		};
		span[22] = new anon_11
		{
			field_0 = 8,
			field_1 = 29
		};
		span[23] = new anon_11
		{
			field_0 = 8,
			field_1 = 157
		};
		span[24] = new anon_11
		{
			field_0 = 8,
			field_1 = 93
		};
		span[25] = new anon_11
		{
			field_0 = 8,
			field_1 = 221
		};
		span[26] = new anon_11
		{
			field_0 = 8,
			field_1 = 61
		};
		span[27] = new anon_11
		{
			field_0 = 9,
			field_1 = 83
		};
		span[28] = new anon_11
		{
			field_0 = 9,
			field_1 = 339
		};
		span[29] = new anon_11
		{
			field_0 = 9,
			field_1 = 211
		};
		span[30] = new anon_11
		{
			field_0 = 9,
			field_1 = 467
		};
		span[31] = new anon_11
		{
			field_0 = 9,
			field_1 = 51
		};
		span[32] = new anon_11
		{
			field_0 = 9,
			field_1 = 307
		};
		span[33] = new anon_11
		{
			field_0 = 9,
			field_1 = 179
		};
		span[34] = new anon_11
		{
			field_0 = 9,
			field_1 = 435
		};
		span[35] = new anon_11
		{
			field_0 = 9,
			field_1 = 115
		};
		span[36] = new anon_11
		{
			field_0 = 9,
			field_1 = 371
		};
		span[37] = new anon_11
		{
			field_0 = 9,
			field_1 = 243
		};
		span[38] = new anon_11
		{
			field_0 = 9,
			field_1 = 499
		};
		span[39] = new anon_11
		{
			field_0 = 9,
			field_1 = 11
		};
		span[40] = new anon_11
		{
			field_0 = 9,
			field_1 = 267
		};
		span[41] = new anon_11
		{
			field_0 = 9,
			field_1 = 139
		};
		span[42] = new anon_11
		{
			field_0 = 9,
			field_1 = 395
		};
		span[43] = new anon_11
		{
			field_0 = 9,
			field_1 = 75
		};
		span[44] = new anon_11
		{
			field_0 = 9,
			field_1 = 331
		};
		span[45] = new anon_11
		{
			field_0 = 9,
			field_1 = 203
		};
		span[46] = new anon_11
		{
			field_0 = 9,
			field_1 = 459
		};
		span[47] = new anon_11
		{
			field_0 = 9,
			field_1 = 43
		};
		span[48] = new anon_11
		{
			field_0 = 9,
			field_1 = 299
		};
		span[49] = new anon_11
		{
			field_0 = 10,
			field_1 = 7
		};
		span[50] = new anon_11
		{
			field_0 = 10,
			field_1 = 519
		};
		span[51] = new anon_11
		{
			field_0 = 10,
			field_1 = 263
		};
		span[52] = new anon_11
		{
			field_0 = 10,
			field_1 = 775
		};
		span[53] = new anon_11
		{
			field_0 = 10,
			field_1 = 135
		};
		span[54] = new anon_11
		{
			field_0 = 10,
			field_1 = 647
		};
		span[55] = new anon_11
		{
			field_0 = 10,
			field_1 = 391
		};
		span[56] = new anon_11
		{
			field_0 = 10,
			field_1 = 903
		};
		span[57] = new anon_11
		{
			field_0 = 10,
			field_1 = 71
		};
		span[58] = new anon_11
		{
			field_0 = 10,
			field_1 = 583
		};
		span[59] = new anon_11
		{
			field_0 = 10,
			field_1 = 327
		};
		span[60] = new anon_11
		{
			field_0 = 10,
			field_1 = 839
		};
		span[61] = new anon_11
		{
			field_0 = 10,
			field_1 = 199
		};
		span[62] = new anon_11
		{
			field_0 = 10,
			field_1 = 711
		};
		span[63] = new anon_11
		{
			field_0 = 10,
			field_1 = 455
		};
		span[64] = new anon_11
		{
			field_0 = 10,
			field_1 = 967
		};
		span[65] = new anon_11
		{
			field_0 = 10,
			field_1 = 39
		};
		span[66] = new anon_11
		{
			field_0 = 10,
			field_1 = 551
		};
		span[67] = new anon_11
		{
			field_0 = 10,
			field_1 = 295
		};
		span[68] = new anon_11
		{
			field_0 = 10,
			field_1 = 807
		};
		span[69] = new anon_11
		{
			field_0 = 10,
			field_1 = 167
		};
		span[70] = new anon_11
		{
			field_0 = 10,
			field_1 = 679
		};
		span[71] = new anon_11
		{
			field_0 = 10,
			field_1 = 423
		};
		span[72] = new anon_11
		{
			field_0 = 10,
			field_1 = 935
		};
		span[73] = new anon_11
		{
			field_0 = 10,
			field_1 = 103
		};
		span[74] = new anon_11
		{
			field_0 = 10,
			field_1 = 615
		};
		span[75] = new anon_11
		{
			field_0 = 11,
			field_1 = 463
		};
		span[76] = new anon_11
		{
			field_0 = 11,
			field_1 = 1487
		};
		span[77] = new anon_11
		{
			field_0 = 11,
			field_1 = 975
		};
		span[78] = new anon_11
		{
			field_0 = 10,
			field_1 = 359
		};
		span[79] = new anon_11
		{
			field_0 = 10,
			field_1 = 871
		};
		span[80] = new anon_11
		{
			field_0 = 10,
			field_1 = 231
		};
		span[81] = new anon_11
		{
			field_0 = 11,
			field_1 = 1999
		};
		span[82] = new anon_11
		{
			field_0 = 11,
			field_1 = 47
		};
		span[83] = new anon_11
		{
			field_0 = 11,
			field_1 = 1071
		};
		span[84] = new anon_11
		{
			field_0 = 11,
			field_1 = 559
		};
		span[85] = new anon_11
		{
			field_0 = 10,
			field_1 = 743
		};
		span[86] = new anon_11
		{
			field_0 = 10,
			field_1 = 487
		};
		span[87] = new anon_11
		{
			field_0 = 11,
			field_1 = 1583
		};
		span[88] = new anon_11
		{
			field_0 = 11,
			field_1 = 303
		};
		span[89] = new anon_11
		{
			field_0 = 11,
			field_1 = 1327
		};
		span[90] = new anon_11
		{
			field_0 = 11,
			field_1 = 815
		};
		span[91] = new anon_11
		{
			field_0 = 11,
			field_1 = 1839
		};
		span[92] = new anon_11
		{
			field_0 = 11,
			field_1 = 175
		};
		span[93] = new anon_11
		{
			field_0 = 11,
			field_1 = 1199
		};
		span[94] = new anon_11
		{
			field_0 = 11,
			field_1 = 687
		};
		span[95] = new anon_11
		{
			field_0 = 11,
			field_1 = 1711
		};
		span[96] = new anon_11
		{
			field_0 = 11,
			field_1 = 431
		};
		span[97] = new anon_11
		{
			field_0 = 11,
			field_1 = 1455
		};
		span[98] = new anon_11
		{
			field_0 = 11,
			field_1 = 943
		};
		span[99] = new anon_11
		{
			field_0 = 11,
			field_1 = 1967
		};
		span[100] = new anon_11
		{
			field_0 = 11,
			field_1 = 111
		};
		span[101] = new anon_11
		{
			field_0 = 11,
			field_1 = 1135
		};
		span[102] = new anon_11
		{
			field_0 = 11,
			field_1 = 623
		};
		span[103] = new anon_11
		{
			field_0 = 11,
			field_1 = 1647
		};
		span[104] = new anon_11
		{
			field_0 = 11,
			field_1 = 367
		};
		span[105] = new anon_11
		{
			field_0 = 11,
			field_1 = 1391
		};
		span[106] = new anon_11
		{
			field_0 = 11,
			field_1 = 879
		};
		span[107] = new anon_11
		{
			field_0 = 11,
			field_1 = 1903
		};
		span[108] = new anon_11
		{
			field_0 = 11,
			field_1 = 239
		};
		span[109] = new anon_11
		{
			field_0 = 11,
			field_1 = 1263
		};
		span[110] = new anon_11
		{
			field_0 = 11,
			field_1 = 751
		};
		span[111] = new anon_11
		{
			field_0 = 11,
			field_1 = 1775
		};
		span[112] = new anon_11
		{
			field_0 = 11,
			field_1 = 495
		};
		span[113] = new anon_11
		{
			field_0 = 11,
			field_1 = 1519
		};
		span[114] = new anon_11
		{
			field_0 = 11,
			field_1 = 1007
		};
		span[115] = new anon_11
		{
			field_0 = 11,
			field_1 = 2031
		};
		span[116] = new anon_11
		{
			field_0 = 11,
			field_1 = 31
		};
		span[117] = new anon_11
		{
			field_0 = 11,
			field_1 = 1055
		};
		span[118] = new anon_11
		{
			field_0 = 11,
			field_1 = 543
		};
		span[119] = new anon_11
		{
			field_0 = 11,
			field_1 = 1567
		};
		span[120] = new anon_11
		{
			field_0 = 11,
			field_1 = 287
		};
		span[121] = new anon_11
		{
			field_0 = 11,
			field_1 = 1311
		};
		span[122] = new anon_11
		{
			field_0 = 11,
			field_1 = 799
		};
		span[123] = new anon_11
		{
			field_0 = 11,
			field_1 = 1823
		};
		span[124] = new anon_11
		{
			field_0 = 11,
			field_1 = 159
		};
		span[125] = new anon_11
		{
			field_0 = 11,
			field_1 = 1183
		};
		span[126] = new anon_11
		{
			field_0 = 11,
			field_1 = 671
		};
		span[127] = new anon_11
		{
			field_0 = 11,
			field_1 = 1695
		};
		span[128] = new anon_11
		{
			field_0 = 11,
			field_1 = 415
		};
		span[129] = new anon_11
		{
			field_0 = 11,
			field_1 = 1439
		};
		span[130] = new anon_11
		{
			field_0 = 11,
			field_1 = 927
		};
		span[131] = new anon_11
		{
			field_0 = 11,
			field_1 = 1951
		};
		span[132] = new anon_11
		{
			field_0 = 11,
			field_1 = 95
		};
		span[133] = new anon_11
		{
			field_0 = 11,
			field_1 = 1119
		};
		span[134] = new anon_11
		{
			field_0 = 11,
			field_1 = 607
		};
		span[135] = new anon_11
		{
			field_0 = 11,
			field_1 = 1631
		};
		span[136] = new anon_11
		{
			field_0 = 11,
			field_1 = 351
		};
		span[137] = new anon_11
		{
			field_0 = 11,
			field_1 = 1375
		};
		span[138] = new anon_11
		{
			field_0 = 11,
			field_1 = 863
		};
		span[139] = new anon_11
		{
			field_0 = 11,
			field_1 = 1887
		};
		span[140] = new anon_11
		{
			field_0 = 11,
			field_1 = 223
		};
		span[141] = new anon_11
		{
			field_0 = 11,
			field_1 = 1247
		};
		span[142] = new anon_11
		{
			field_0 = 11,
			field_1 = 735
		};
		span[143] = new anon_11
		{
			field_0 = 11,
			field_1 = 1759
		};
		span[144] = new anon_11
		{
			field_0 = 11,
			field_1 = 479
		};
		span[145] = new anon_11
		{
			field_0 = 11,
			field_1 = 1503
		};
		span[146] = new anon_11
		{
			field_0 = 11,
			field_1 = 991
		};
		span[147] = new anon_11
		{
			field_0 = 11,
			field_1 = 2015
		};
		span[148] = new anon_11
		{
			field_0 = 11,
			field_1 = 63
		};
		span[149] = new anon_11
		{
			field_0 = 11,
			field_1 = 1087
		};
		span[150] = new anon_11
		{
			field_0 = 11,
			field_1 = 575
		};
		span[151] = new anon_11
		{
			field_0 = 11,
			field_1 = 1599
		};
		span[152] = new anon_11
		{
			field_0 = 11,
			field_1 = 319
		};
		span[153] = new anon_11
		{
			field_0 = 11,
			field_1 = 1343
		};
		span[154] = new anon_11
		{
			field_0 = 11,
			field_1 = 831
		};
		span[155] = new anon_11
		{
			field_0 = 11,
			field_1 = 1855
		};
		span[156] = new anon_11
		{
			field_0 = 11,
			field_1 = 191
		};
		span[157] = new anon_11
		{
			field_0 = 11,
			field_1 = 1215
		};
		span[158] = new anon_11
		{
			field_0 = 11,
			field_1 = 703
		};
		span[159] = new anon_11
		{
			field_0 = 11,
			field_1 = 1727
		};
		span[160] = new anon_11
		{
			field_0 = 11,
			field_1 = 447
		};
		span[161] = new anon_11
		{
			field_0 = 11,
			field_1 = 1471
		};
		span[162] = new anon_11
		{
			field_0 = 11,
			field_1 = 959
		};
		span[163] = new anon_11
		{
			field_0 = 11,
			field_1 = 1983
		};
		span[164] = new anon_11
		{
			field_0 = 11,
			field_1 = 127
		};
		span[165] = new anon_11
		{
			field_0 = 11,
			field_1 = 1151
		};
		span[166] = new anon_11
		{
			field_0 = 11,
			field_1 = 639
		};
		span[167] = new anon_11
		{
			field_0 = 11,
			field_1 = 1663
		};
		span[168] = new anon_11
		{
			field_0 = 11,
			field_1 = 383
		};
		span[169] = new anon_11
		{
			field_0 = 10,
			field_1 = 999
		};
		span[170] = new anon_11
		{
			field_0 = 10,
			field_1 = 23
		};
		span[171] = new anon_11
		{
			field_0 = 10,
			field_1 = 535
		};
		span[172] = new anon_11
		{
			field_0 = 10,
			field_1 = 279
		};
		span[173] = new anon_11
		{
			field_0 = 11,
			field_1 = 1407
		};
		span[174] = new anon_11
		{
			field_0 = 11,
			field_1 = 895
		};
		span[175] = new anon_11
		{
			field_0 = 11,
			field_1 = 1919
		};
		span[176] = new anon_11
		{
			field_0 = 11,
			field_1 = 255
		};
		span[177] = new anon_11
		{
			field_0 = 11,
			field_1 = 1279
		};
		span[178] = new anon_11
		{
			field_0 = 10,
			field_1 = 791
		};
		span[179] = new anon_11
		{
			field_0 = 10,
			field_1 = 151
		};
		span[180] = new anon_11
		{
			field_0 = 10,
			field_1 = 663
		};
		span[181] = new anon_11
		{
			field_0 = 10,
			field_1 = 407
		};
		span[182] = new anon_11
		{
			field_0 = 10,
			field_1 = 919
		};
		span[183] = new anon_11
		{
			field_0 = 10,
			field_1 = 87
		};
		span[184] = new anon_11
		{
			field_0 = 10,
			field_1 = 599
		};
		span[185] = new anon_11
		{
			field_0 = 10,
			field_1 = 343
		};
		span[186] = new anon_11
		{
			field_0 = 10,
			field_1 = 855
		};
		span[187] = new anon_11
		{
			field_0 = 10,
			field_1 = 215
		};
		span[188] = new anon_11
		{
			field_0 = 10,
			field_1 = 727
		};
		span[189] = new anon_11
		{
			field_0 = 10,
			field_1 = 471
		};
		span[190] = new anon_11
		{
			field_0 = 10,
			field_1 = 983
		};
		span[191] = new anon_11
		{
			field_0 = 10,
			field_1 = 55
		};
		span[192] = new anon_11
		{
			field_0 = 10,
			field_1 = 567
		};
		span[193] = new anon_11
		{
			field_0 = 10,
			field_1 = 311
		};
		span[194] = new anon_11
		{
			field_0 = 10,
			field_1 = 823
		};
		span[195] = new anon_11
		{
			field_0 = 10,
			field_1 = 183
		};
		span[196] = new anon_11
		{
			field_0 = 10,
			field_1 = 695
		};
		span[197] = new anon_11
		{
			field_0 = 10,
			field_1 = 439
		};
		span[198] = new anon_11
		{
			field_0 = 10,
			field_1 = 951
		};
		span[199] = new anon_11
		{
			field_0 = 10,
			field_1 = 119
		};
		span[200] = new anon_11
		{
			field_0 = 10,
			field_1 = 631
		};
		span[201] = new anon_11
		{
			field_0 = 10,
			field_1 = 375
		};
		span[202] = new anon_11
		{
			field_0 = 10,
			field_1 = 887
		};
		span[203] = new anon_11
		{
			field_0 = 10,
			field_1 = 247
		};
		span[204] = new anon_11
		{
			field_0 = 10,
			field_1 = 759
		};
		span[205] = new anon_11
		{
			field_0 = 10,
			field_1 = 503
		};
		span[206] = new anon_11
		{
			field_0 = 10,
			field_1 = 1015
		};
		span[207] = new anon_11
		{
			field_0 = 10,
			field_1 = 15
		};
		span[208] = new anon_11
		{
			field_0 = 10,
			field_1 = 527
		};
		span[209] = new anon_11
		{
			field_0 = 10,
			field_1 = 271
		};
		span[210] = new anon_11
		{
			field_0 = 10,
			field_1 = 783
		};
		span[211] = new anon_11
		{
			field_0 = 10,
			field_1 = 143
		};
		span[212] = new anon_11
		{
			field_0 = 10,
			field_1 = 655
		};
		span[213] = new anon_11
		{
			field_0 = 10,
			field_1 = 399
		};
		span[214] = new anon_11
		{
			field_0 = 9,
			field_1 = 171
		};
		span[215] = new anon_11
		{
			field_0 = 9,
			field_1 = 427
		};
		span[216] = new anon_11
		{
			field_0 = 9,
			field_1 = 107
		};
		span[217] = new anon_11
		{
			field_0 = 9,
			field_1 = 363
		};
		span[218] = new anon_11
		{
			field_0 = 9,
			field_1 = 235
		};
		span[219] = new anon_11
		{
			field_0 = 9,
			field_1 = 491
		};
		span[220] = new anon_11
		{
			field_0 = 9,
			field_1 = 27
		};
		span[221] = new anon_11
		{
			field_0 = 9,
			field_1 = 283
		};
		span[222] = new anon_11
		{
			field_0 = 9,
			field_1 = 155
		};
		span[223] = new anon_11
		{
			field_0 = 9,
			field_1 = 411
		};
		span[224] = new anon_11
		{
			field_0 = 9,
			field_1 = 91
		};
		span[225] = new anon_11
		{
			field_0 = 9,
			field_1 = 347
		};
		span[226] = new anon_11
		{
			field_0 = 9,
			field_1 = 219
		};
		span[227] = new anon_11
		{
			field_0 = 9,
			field_1 = 475
		};
		span[228] = new anon_11
		{
			field_0 = 9,
			field_1 = 59
		};
		span[229] = new anon_11
		{
			field_0 = 9,
			field_1 = 315
		};
		span[230] = new anon_11
		{
			field_0 = 9,
			field_1 = 187
		};
		span[231] = new anon_11
		{
			field_0 = 9,
			field_1 = 443
		};
		span[232] = new anon_11
		{
			field_0 = 8,
			field_1 = 189
		};
		span[233] = new anon_11
		{
			field_0 = 9,
			field_1 = 123
		};
		span[234] = new anon_11
		{
			field_0 = 8,
			field_1 = 125
		};
		span[235] = new anon_11
		{
			field_0 = 8,
			field_1 = 253
		};
		span[236] = new anon_11
		{
			field_0 = 8,
			field_1 = 3
		};
		span[237] = new anon_11
		{
			field_0 = 8,
			field_1 = 131
		};
		span[238] = new anon_11
		{
			field_0 = 8,
			field_1 = 67
		};
		span[239] = new anon_11
		{
			field_0 = 8,
			field_1 = 195
		};
		span[240] = new anon_11
		{
			field_0 = 8,
			field_1 = 35
		};
		span[241] = new anon_11
		{
			field_0 = 8,
			field_1 = 163
		};
		span[242] = new anon_11
		{
			field_0 = 8,
			field_1 = 99
		};
		span[243] = new anon_11
		{
			field_0 = 8,
			field_1 = 227
		};
		span[244] = new anon_11
		{
			field_0 = 8,
			field_1 = 19
		};
		span[245] = new anon_11
		{
			field_0 = 7,
			field_1 = 5
		};
		span[246] = new anon_11
		{
			field_0 = 7,
			field_1 = 69
		};
		span[247] = new anon_11
		{
			field_0 = 7,
			field_1 = 37
		};
		span[248] = new anon_11
		{
			field_0 = 7,
			field_1 = 101
		};
		span[249] = new anon_11
		{
			field_0 = 7,
			field_1 = 21
		};
		span[250] = new anon_11
		{
			field_0 = 7,
			field_1 = 85
		};
		span[251] = new anon_11
		{
			field_0 = 6,
			field_1 = 33
		};
		span[252] = new anon_11
		{
			field_0 = 6,
			field_1 = 17
		};
		span[253] = new anon_11
		{
			field_0 = 6,
			field_1 = 49
		};
		span[254] = new anon_11
		{
			field_0 = 5,
			field_1 = 22
		};
		span[255] = new anon_11
		{
			field_0 = 4,
			field_1 = 10
		};
		span[256] = new anon_11
		{
			field_0 = 12,
			field_1 = 2047
		};
		span[257] = default(anon_11);
		span[258] = new anon_11
		{
			field_0 = 6,
			field_1 = 9
		};
		span[259] = default(anon_11);
		span[260] = default(anon_11);
		span[261] = default(anon_11);
		span[262] = new anon_11
		{
			field_0 = 8,
			field_1 = 147
		};
		span[263] = default(anon_11);
		span[264] = default(anon_11);
		span[265] = new anon_11
		{
			field_0 = 7,
			field_1 = 53
		};
		span[266] = default(anon_11);
		span[267] = new anon_11
		{
			field_0 = 9,
			field_1 = 379
		};
		span[268] = default(anon_11);
		span[269] = new anon_11
		{
			field_0 = 9,
			field_1 = 251
		};
		span[270] = new anon_11
		{
			field_0 = 10,
			field_1 = 911
		};
		span[271] = new anon_11
		{
			field_0 = 10,
			field_1 = 79
		};
		span[272] = new anon_11
		{
			field_0 = 11,
			field_1 = 767
		};
		span[273] = new anon_11
		{
			field_0 = 10,
			field_1 = 591
		};
		span[274] = new anon_11
		{
			field_0 = 10,
			field_1 = 335
		};
		span[275] = new anon_11
		{
			field_0 = 10,
			field_1 = 847
		};
		span[276] = new anon_11
		{
			field_0 = 10,
			field_1 = 207
		};
		span[277] = new anon_11
		{
			field_0 = 10,
			field_1 = 719
		};
		span[278] = new anon_11
		{
			field_0 = 11,
			field_1 = 1791
		};
		span[279] = new anon_11
		{
			field_0 = 11,
			field_1 = 511
		};
		span[280] = new anon_11
		{
			field_0 = 9,
			field_1 = 507
		};
		span[281] = new anon_11
		{
			field_0 = 11,
			field_1 = 1535
		};
		span[282] = new anon_11
		{
			field_0 = 11,
			field_1 = 1023
		};
		span[283] = new anon_11
		{
			field_0 = 12,
			field_1 = 4095
		};
		span[284] = new anon_11
		{
			field_0 = 5,
			field_1 = 14
		};
		span[285] = default(anon_11);
		span[286] = default(anon_11);
		span[287] = default(anon_11);
		return buffer;
	}

	internal static void Initialize_g_dyn_huff_4_codes()
	{
		GlobalVariables.g_dyn_huff_4_codes = Get_g_dyn_huff_4_codes();
	}

	private static InlineArray_8_w3otm9c Get_s_png_sig()
	{
		return InlineArrayHelper.Create<InlineArray_8_w3otm9c, byte>(new byte[8] { 137, 80, 78, 71, 13, 10, 26, 10 });
	}

	internal static void Initialize_s_png_sig()
	{
		GlobalVariables.s_png_sig = Get_s_png_sig();
	}

	private static InlineArray_5_w3otm9c Get_String_qjc9xdd()
	{
		return InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>("IDAT\0"u8);
	}

	internal static void Initialize_String_qjc9xdd()
	{
		GlobalVariables.String_qjc9xdd = Get_String_qjc9xdd();
	}

	private static InlineArray_5_w3otm9c Get_String_p7olgfc()
	{
		return InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>("IEND\0"u8);
	}

	internal static void Initialize_String_p7olgfc()
	{
		GlobalVariables.String_p7olgfc = Get_String_p7olgfc();
	}

	private static InlineArray_5_w3otm9c Get_String_22lii4a()
	{
		return InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>("fdEC\0"u8);
	}

	internal static void Initialize_String_22lii4a()
	{
		GlobalVariables.String_22lii4a = Get_String_22lii4a();
	}

	private static InlineArray_26_oeds4ea Get_String_497patd()
	{
		return InlineArrayHelper.Create<InlineArray_26_oeds4ea, char>("src_len >= (zlib_len + 4)\0".ToCharacterSpan());
	}

	internal static void Initialize_String_497patd()
	{
		GlobalVariables.String_497patd = Get_String_497patd();
	}

	private static InlineArray_15_oeds4ea Get_String_aa3exrc()
	{
		return InlineArrayHelper.Create<InlineArray_15_oeds4ea, char>("l && (l <= 32)\0".ToCharacterSpan());
	}

	internal static void Initialize_String_aa3exrc()
	{
		GlobalVariables.String_aa3exrc = Get_String_aa3exrc();
	}

	private static InlineArray_40_oeds4ea Get_String_ktv524d()
	{
		return InlineArrayHelper.Create<InlineArray_40_oeds4ea, char>("bit_buf_size >= FPNG_DECODER_TABLE_BITS\0".ToCharacterSpan());
	}

	internal static void Initialize_String_ktv524d()
	{
		GlobalVariables.String_ktv524d = Get_String_ktv524d();
	}

	private static InlineArray_8_oeds4ea Get_String_mf9hyza()
	{
		return InlineArrayHelper.Create<InlineArray_8_oeds4ea, char>("l <= 32\0".ToCharacterSpan());
	}

	internal static void Initialize_String_mf9hyza()
	{
		GlobalVariables.String_mf9hyza = Get_String_mf9hyza();
	}

	private static InlineArray_31_vqkfj7a Get_s_length_range()
	{
		return InlineArrayHelper.Create<InlineArray_31_vqkfj7a, int>(new int[31]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258, 0,
			0
		});
	}

	internal static void Initialize_s_length_range()
	{
		GlobalVariables.s_length_range = Get_s_length_range();
	}

	private static InlineArray_31_vqkfj7a Get_s_length_extra()
	{
		return InlineArrayHelper.Create<InlineArray_31_vqkfj7a, int>(new int[31]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0, 0,
			0
		});
	}

	internal static void Initialize_s_length_extra()
	{
		GlobalVariables.s_length_extra = Get_s_length_extra();
	}

	private static InlineArray_38_oeds4ea Get_String_ftb25bb()
	{
		return InlineArrayHelper.Create<InlineArray_38_oeds4ea, char>("l && (l <= 32) && (bit_buf_size >= l)\0".ToCharacterSpan());
	}

	internal static void Initialize_String_ftb25bb()
	{
		GlobalVariables.String_ftb25bb = Get_String_ftb25bb();
	}

	private static InlineArray_31_oeds4ea Get_String_bahgbqd()
	{
		return InlineArrayHelper.Create<InlineArray_31_oeds4ea, char>("l <= 32 && (bit_buf_size >= l)\0".ToCharacterSpan());
	}

	internal static void Initialize_String_bahgbqd()
	{
		GlobalVariables.String_bahgbqd = Get_String_bahgbqd();
	}

	private static InlineArray_19_oeds4ea Get_String_a5rp7bb()
	{
		return InlineArrayHelper.Create<InlineArray_19_oeds4ea, char>("(run_len % 3) == 0\0".ToCharacterSpan());
	}

	internal static void Initialize_String_a5rp7bb()
	{
		GlobalVariables.String_a5rp7bb = Get_String_a5rp7bb();
	}

	private static InlineArray_259_oeds4ea Get_g_run_len3_to_4()
	{
		return InlineArrayHelper.Create<InlineArray_259_oeds4ea, short>(new short[259]
		{
			0, 0, 0, 4, 0, 0, 8, 0, 0, 12,
			0, 0, 16, 0, 0, 20, 0, 0, 24, 0,
			0, 28, 0, 0, 32, 0, 0, 36, 0, 0,
			40, 0, 0, 44, 0, 0, 48, 0, 0, 52,
			0, 0, 56, 0, 0, 60, 0, 0, 64, 0,
			0, 68, 0, 0, 72, 0, 0, 76, 0, 0,
			80, 0, 0, 84, 0, 0, 88, 0, 0, 92,
			0, 0, 96, 0, 0, 100, 0, 0, 104, 0,
			0, 108, 0, 0, 112, 0, 0, 116, 0, 0,
			120, 0, 0, 124, 0, 0, 128, 0, 0, 132,
			0, 0, 136, 0, 0, 140, 0, 0, 144, 0,
			0, 148, 0, 0, 152, 0, 0, 156, 0, 0,
			160, 0, 0, 164, 0, 0, 168, 0, 0, 172,
			0, 0, 176, 0, 0, 180, 0, 0, 184, 0,
			0, 188, 0, 0, 192, 0, 0, 196, 0, 0,
			200, 0, 0, 204, 0, 0, 208, 0, 0, 212,
			0, 0, 216, 0, 0, 220, 0, 0, 224, 0,
			0, 228, 0, 0, 232, 0, 0, 236, 0, 0,
			240, 0, 0, 244, 0, 0, 248, 0, 0, 252,
			0, 0, 256, 0, 0, 260, 0, 0, 264, 0,
			0, 268, 0, 0, 272, 0, 0, 276, 0, 0,
			280, 0, 0, 284, 0, 0, 288, 0, 0, 292,
			0, 0, 296, 0, 0, 300, 0, 0, 304, 0,
			0, 308, 0, 0, 312, 0, 0, 316, 0, 0,
			320, 0, 0, 324, 0, 0, 328, 0, 0, 332,
			0, 0, 336, 0, 0, 340, 0, 0, 344
		});
	}

	internal static void Initialize_g_run_len3_to_4()
	{
		GlobalVariables.g_run_len3_to_4 = Get_g_run_len3_to_4();
	}

	private static InlineArray_37_oeds4ea Get_String_zixkhbc()
	{
		return InlineArrayHelper.Create<InlineArray_37_oeds4ea, char>("(src_chans == 3) || (src_chans == 4)\0".ToCharacterSpan());
	}

	internal static void Initialize_String_zixkhbc()
	{
		GlobalVariables.String_zixkhbc = Get_String_zixkhbc();
	}

	private static InlineArray_37_oeds4ea Get_String_kppxlqc()
	{
		return InlineArrayHelper.Create<InlineArray_37_oeds4ea, char>("(dst_chans == 3) || (dst_chans == 4)\0".ToCharacterSpan());
	}

	internal static void Initialize_String_kppxlqc()
	{
		GlobalVariables.String_kppxlqc = Get_String_kppxlqc();
	}

	private static InlineArray_10_oeds4ea Get_String_ji2h3xd()
	{
		return InlineArrayHelper.Create<InlineArray_10_oeds4ea, char>("!comp_ofs\0".ToCharacterSpan());
	}

	internal static void Initialize_String_ji2h3xd()
	{
		GlobalVariables.String_ji2h3xd = Get_String_ji2h3xd();
	}

	private static InlineArray_19_w3otm9c Get_s_bit_length_order()
	{
		return InlineArrayHelper.Create<InlineArray_19_w3otm9c, byte>(new byte[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		});
	}

	internal static void Initialize_s_bit_length_order()
	{
		GlobalVariables.s_bit_length_order = Get_s_bit_length_order();
	}

	private static InlineArray_36_oeds4ea Get_String_nlshwsc()
	{
		return InlineArrayHelper.Create<InlineArray_36_oeds4ea, char>("sym_bits <= FPNG_DECODER_TABLE_BITS\0".ToCharacterSpan());
	}

	internal static void Initialize_String_nlshwsc()
	{
		GlobalVariables.String_nlshwsc = Get_String_nlshwsc();
	}

	private static InlineArray_42_oeds4ea Get_String_32otbnd()
	{
		return InlineArrayHelper.Create<InlineArray_42_oeds4ea, char>("pCode_sizes[i] <= FPNG_DECODER_TABLE_SIZE\0".ToCharacterSpan());
	}

	internal static void Initialize_String_32otbnd()
	{
		GlobalVariables.String_32otbnd = Get_String_32otbnd();
	}
}

// NBidi - a .Net implementation of the BIDI (Bi-Directional Text) algorithm.
// Copyright (C) 2007-2009 Itai Bar-Haim
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// ---
//
// Unicode Data Copyright:
// Copyright © 1991-2006 Unicode, Inc. All rights reserved. Distributed under the Terms of Use in http://www.unicode.org/copyright.html.

namespace NBidi
{
	/// <summary>
	/// An helper class that provides the mirrored alternatives for characters.
	/// </summary>
	public abstract class BidiCharacterMirrorResolver {
		/// <summary>
		/// Returns the corresponding mirrored character for the given character, if any. If no mirroring available, returns the given character.
		/// </summary>
		/// <param name="c">A character to mirror.</param>
		/// <returns>The mirrored character, or the given character if no mirroring available.</returns>
		public static char GetBidiCharacterMirror(char c)
		{
			switch (c) {
				case '\u0028': return '\u0029';
				case '\u0029': return '\u0028';
				case '\u003C': return '\u003E';
				case '\u003E': return '\u003C';
				case '\u005B': return '\u005D';
				case '\u005D': return '\u005B';
				case '\u007B': return '\u007D';
				case '\u007D': return '\u007B';
				case '\u00AB': return '\u00BB';
				case '\u00BB': return '\u00AB';
				case '\u0F3A': return '\u0F3B';
				case '\u0F3B': return '\u0F3A';
				case '\u0F3C': return '\u0F3D';
				case '\u0F3D': return '\u0F3C';
				case '\u169B': return '\u169C';
				case '\u169C': return '\u169B';
				case '\u2039': return '\u203A';
				case '\u203A': return '\u2039';
				case '\u2045': return '\u2046';
				case '\u2046': return '\u2045';
				case '\u207D': return '\u207E';
				case '\u207E': return '\u207D';
				case '\u208D': return '\u208E';
				case '\u208E': return '\u208D';
				case '\u2208': return '\u220B';
				case '\u2209': return '\u220C';
				case '\u220A': return '\u220D';
				case '\u220B': return '\u2208';
				case '\u220C': return '\u2209';
				case '\u220D': return '\u220A';
				case '\u2215': return '\u29F5';
				case '\u223C': return '\u223D';
				case '\u223D': return '\u223C';
				case '\u2243': return '\u22CD';
				case '\u2252': return '\u2253';
				case '\u2253': return '\u2252';
				case '\u2254': return '\u2255';
				case '\u2255': return '\u2254';
				case '\u2264': return '\u2265';
				case '\u2265': return '\u2264';
				case '\u2266': return '\u2267';
				case '\u2267': return '\u2266';
				case '\u2268': return '\u2269';
				case '\u2269': return '\u2268';
				case '\u226A': return '\u226B';
				case '\u226B': return '\u226A';
				case '\u226E': return '\u226F';
				case '\u226F': return '\u226E';
				case '\u2270': return '\u2271';
				case '\u2271': return '\u2270';
				case '\u2272': return '\u2273';
				case '\u2273': return '\u2272';
				case '\u2274': return '\u2275';
				case '\u2275': return '\u2274';
				case '\u2276': return '\u2277';
				case '\u2277': return '\u2276';
				case '\u2278': return '\u2279';
				case '\u2279': return '\u2278';
				case '\u227A': return '\u227B';
				case '\u227B': return '\u227A';
				case '\u227C': return '\u227D';
				case '\u227D': return '\u227C';
				case '\u227E': return '\u227F';
				case '\u227F': return '\u227E';
				case '\u2280': return '\u2281';
				case '\u2281': return '\u2280';
				case '\u2282': return '\u2283';
				case '\u2283': return '\u2282';
				case '\u2284': return '\u2285';
				case '\u2285': return '\u2284';
				case '\u2286': return '\u2287';
				case '\u2287': return '\u2286';
				case '\u2288': return '\u2289';
				case '\u2289': return '\u2288';
				case '\u228A': return '\u228B';
				case '\u228B': return '\u228A';
				case '\u228F': return '\u2290';
				case '\u2290': return '\u228F';
				case '\u2291': return '\u2292';
				case '\u2292': return '\u2291';
				case '\u2298': return '\u29B8';
				case '\u22A2': return '\u22A3';
				case '\u22A3': return '\u22A2';
				case '\u22A6': return '\u2ADE';
				case '\u22A8': return '\u2AE4';
				case '\u22A9': return '\u2AE3';
				case '\u22AB': return '\u2AE5';
				case '\u22B0': return '\u22B1';
				case '\u22B1': return '\u22B0';
				case '\u22B2': return '\u22B3';
				case '\u22B3': return '\u22B2';
				case '\u22B4': return '\u22B5';
				case '\u22B5': return '\u22B4';
				case '\u22B6': return '\u22B7';
				case '\u22B7': return '\u22B6';
				case '\u22C9': return '\u22CA';
				case '\u22CA': return '\u22C9';
				case '\u22CB': return '\u22CC';
				case '\u22CC': return '\u22CB';
				case '\u22CD': return '\u2243';
				case '\u22D0': return '\u22D1';
				case '\u22D1': return '\u22D0';
				case '\u22D6': return '\u22D7';
				case '\u22D7': return '\u22D6';
				case '\u22D8': return '\u22D9';
				case '\u22D9': return '\u22D8';
				case '\u22DA': return '\u22DB';
				case '\u22DB': return '\u22DA';
				case '\u22DC': return '\u22DD';
				case '\u22DD': return '\u22DC';
				case '\u22DE': return '\u22DF';
				case '\u22DF': return '\u22DE';
				case '\u22E0': return '\u22E1';
				case '\u22E1': return '\u22E0';
				case '\u22E2': return '\u22E3';
				case '\u22E3': return '\u22E2';
				case '\u22E4': return '\u22E5';
				case '\u22E5': return '\u22E4';
				case '\u22E6': return '\u22E7';
				case '\u22E7': return '\u22E6';
				case '\u22E8': return '\u22E9';
				case '\u22E9': return '\u22E8';
				case '\u22EA': return '\u22EB';
				case '\u22EB': return '\u22EA';
				case '\u22EC': return '\u22ED';
				case '\u22ED': return '\u22EC';
				case '\u22F0': return '\u22F1';
				case '\u22F1': return '\u22F0';
				case '\u22F2': return '\u22FA';
				case '\u22F3': return '\u22FB';
				case '\u22F4': return '\u22FC';
				case '\u22F6': return '\u22FD';
				case '\u22F7': return '\u22FE';
				case '\u22FA': return '\u22F2';
				case '\u22FB': return '\u22F3';
				case '\u22FC': return '\u22F4';
				case '\u22FD': return '\u22F6';
				case '\u22FE': return '\u22F7';
				case '\u2308': return '\u2309';
				case '\u2309': return '\u2308';
				case '\u230A': return '\u230B';
				case '\u230B': return '\u230A';
				case '\u2329': return '\u232A';
				case '\u232A': return '\u2329';
				case '\u2768': return '\u2769';
				case '\u2769': return '\u2768';
				case '\u276A': return '\u276B';
				case '\u276B': return '\u276A';
				case '\u276C': return '\u276D';
				case '\u276D': return '\u276C';
				case '\u276E': return '\u276F';
				case '\u276F': return '\u276E';
				case '\u2770': return '\u2771';
				case '\u2771': return '\u2770';
				case '\u2772': return '\u2773';
				case '\u2773': return '\u2772';
				case '\u2774': return '\u2775';
				case '\u2775': return '\u2774';
				case '\u27C3': return '\u27C4';
				case '\u27C4': return '\u27C3';
				case '\u27C5': return '\u27C6';
				case '\u27C6': return '\u27C5';
				case '\u27C8': return '\u27C9';
				case '\u27C9': return '\u27C8';
				case '\u27CB': return '\u27CD';
				case '\u27CD': return '\u27CB';
				case '\u27D5': return '\u27D6';
				case '\u27D6': return '\u27D5';
				case '\u27DD': return '\u27DE';
				case '\u27DE': return '\u27DD';
				case '\u27E2': return '\u27E3';
				case '\u27E3': return '\u27E2';
				case '\u27E4': return '\u27E5';
				case '\u27E5': return '\u27E4';
				case '\u27E6': return '\u27E7';
				case '\u27E7': return '\u27E6';
				case '\u27E8': return '\u27E9';
				case '\u27E9': return '\u27E8';
				case '\u27EA': return '\u27EB';
				case '\u27EB': return '\u27EA';
				case '\u27EC': return '\u27ED';
				case '\u27ED': return '\u27EC';
				case '\u27EE': return '\u27EF';
				case '\u27EF': return '\u27EE';
				case '\u2983': return '\u2984';
				case '\u2984': return '\u2983';
				case '\u2985': return '\u2986';
				case '\u2986': return '\u2985';
				case '\u2987': return '\u2988';
				case '\u2988': return '\u2987';
				case '\u2989': return '\u298A';
				case '\u298A': return '\u2989';
				case '\u298B': return '\u298C';
				case '\u298C': return '\u298B';
				case '\u298D': return '\u2990';
				case '\u298E': return '\u298F';
				case '\u298F': return '\u298E';
				case '\u2990': return '\u298D';
				case '\u2991': return '\u2992';
				case '\u2992': return '\u2991';
				case '\u2993': return '\u2994';
				case '\u2994': return '\u2993';
				case '\u2995': return '\u2996';
				case '\u2996': return '\u2995';
				case '\u2997': return '\u2998';
				case '\u2998': return '\u2997';
				case '\u29B8': return '\u2298';
				case '\u29C0': return '\u29C1';
				case '\u29C1': return '\u29C0';
				case '\u29C4': return '\u29C5';
				case '\u29C5': return '\u29C4';
				case '\u29CF': return '\u29D0';
				case '\u29D0': return '\u29CF';
				case '\u29D1': return '\u29D2';
				case '\u29D2': return '\u29D1';
				case '\u29D4': return '\u29D5';
				case '\u29D5': return '\u29D4';
				case '\u29D8': return '\u29D9';
				case '\u29D9': return '\u29D8';
				case '\u29DA': return '\u29DB';
				case '\u29DB': return '\u29DA';
				case '\u29F5': return '\u2215';
				case '\u29F8': return '\u29F9';
				case '\u29F9': return '\u29F8';
				case '\u29FC': return '\u29FD';
				case '\u29FD': return '\u29FC';
				case '\u2A2B': return '\u2A2C';
				case '\u2A2C': return '\u2A2B';
				case '\u2A2D': return '\u2A2E';
				case '\u2A2E': return '\u2A2D';
				case '\u2A34': return '\u2A35';
				case '\u2A35': return '\u2A34';
				case '\u2A3C': return '\u2A3D';
				case '\u2A3D': return '\u2A3C';
				case '\u2A64': return '\u2A65';
				case '\u2A65': return '\u2A64';
				case '\u2A79': return '\u2A7A';
				case '\u2A7A': return '\u2A79';
				case '\u2A7D': return '\u2A7E';
				case '\u2A7E': return '\u2A7D';
				case '\u2A7F': return '\u2A80';
				case '\u2A80': return '\u2A7F';
				case '\u2A81': return '\u2A82';
				case '\u2A82': return '\u2A81';
				case '\u2A83': return '\u2A84';
				case '\u2A84': return '\u2A83';
				case '\u2A8B': return '\u2A8C';
				case '\u2A8C': return '\u2A8B';
				case '\u2A91': return '\u2A92';
				case '\u2A92': return '\u2A91';
				case '\u2A93': return '\u2A94';
				case '\u2A94': return '\u2A93';
				case '\u2A95': return '\u2A96';
				case '\u2A96': return '\u2A95';
				case '\u2A97': return '\u2A98';
				case '\u2A98': return '\u2A97';
				case '\u2A99': return '\u2A9A';
				case '\u2A9A': return '\u2A99';
				case '\u2A9B': return '\u2A9C';
				case '\u2A9C': return '\u2A9B';
				case '\u2AA1': return '\u2AA2';
				case '\u2AA2': return '\u2AA1';
				case '\u2AA6': return '\u2AA7';
				case '\u2AA7': return '\u2AA6';
				case '\u2AA8': return '\u2AA9';
				case '\u2AA9': return '\u2AA8';
				case '\u2AAA': return '\u2AAB';
				case '\u2AAB': return '\u2AAA';
				case '\u2AAC': return '\u2AAD';
				case '\u2AAD': return '\u2AAC';
				case '\u2AAF': return '\u2AB0';
				case '\u2AB0': return '\u2AAF';
				case '\u2AB3': return '\u2AB4';
				case '\u2AB4': return '\u2AB3';
				case '\u2ABB': return '\u2ABC';
				case '\u2ABC': return '\u2ABB';
				case '\u2ABD': return '\u2ABE';
				case '\u2ABE': return '\u2ABD';
				case '\u2ABF': return '\u2AC0';
				case '\u2AC0': return '\u2ABF';
				case '\u2AC1': return '\u2AC2';
				case '\u2AC2': return '\u2AC1';
				case '\u2AC3': return '\u2AC4';
				case '\u2AC4': return '\u2AC3';
				case '\u2AC5': return '\u2AC6';
				case '\u2AC6': return '\u2AC5';
				case '\u2ACD': return '\u2ACE';
				case '\u2ACE': return '\u2ACD';
				case '\u2ACF': return '\u2AD0';
				case '\u2AD0': return '\u2ACF';
				case '\u2AD1': return '\u2AD2';
				case '\u2AD2': return '\u2AD1';
				case '\u2AD3': return '\u2AD4';
				case '\u2AD4': return '\u2AD3';
				case '\u2AD5': return '\u2AD6';
				case '\u2AD6': return '\u2AD5';
				case '\u2ADE': return '\u22A6';
				case '\u2AE3': return '\u22A9';
				case '\u2AE4': return '\u22A8';
				case '\u2AE5': return '\u22AB';
				case '\u2AEC': return '\u2AED';
				case '\u2AED': return '\u2AEC';
				case '\u2AF7': return '\u2AF8';
				case '\u2AF8': return '\u2AF7';
				case '\u2AF9': return '\u2AFA';
				case '\u2AFA': return '\u2AF9';
				case '\u2E02': return '\u2E03';
				case '\u2E03': return '\u2E02';
				case '\u2E04': return '\u2E05';
				case '\u2E05': return '\u2E04';
				case '\u2E09': return '\u2E0A';
				case '\u2E0A': return '\u2E09';
				case '\u2E0C': return '\u2E0D';
				case '\u2E0D': return '\u2E0C';
				case '\u2E1C': return '\u2E1D';
				case '\u2E1D': return '\u2E1C';
				case '\u2E20': return '\u2E21';
				case '\u2E21': return '\u2E20';
				case '\u2E22': return '\u2E23';
				case '\u2E23': return '\u2E22';
				case '\u2E24': return '\u2E25';
				case '\u2E25': return '\u2E24';
				case '\u2E26': return '\u2E27';
				case '\u2E27': return '\u2E26';
				case '\u2E28': return '\u2E29';
				case '\u2E29': return '\u2E28';
				case '\u3008': return '\u3009';
				case '\u3009': return '\u3008';
				case '\u300A': return '\u300B';
				case '\u300B': return '\u300A';
				case '\u300C': return '\u300D';
				case '\u300D': return '\u300C';
				case '\u300E': return '\u300F';
				case '\u300F': return '\u300E';
				case '\u3010': return '\u3011';
				case '\u3011': return '\u3010';
				case '\u3014': return '\u3015';
				case '\u3015': return '\u3014';
				case '\u3016': return '\u3017';
				case '\u3017': return '\u3016';
				case '\u3018': return '\u3019';
				case '\u3019': return '\u3018';
				case '\u301A': return '\u301B';
				case '\u301B': return '\u301A';
				case '\uFE59': return '\uFE5A';
				case '\uFE5A': return '\uFE59';
				case '\uFE5B': return '\uFE5C';
				case '\uFE5C': return '\uFE5B';
				case '\uFE5D': return '\uFE5E';
				case '\uFE5E': return '\uFE5D';
				case '\uFE64': return '\uFE65';
				case '\uFE65': return '\uFE64';
				case '\uFF08': return '\uFF09';
				case '\uFF09': return '\uFF08';
				case '\uFF1C': return '\uFF1E';
				case '\uFF1E': return '\uFF1C';
				case '\uFF3B': return '\uFF3D';
				case '\uFF3D': return '\uFF3B';
				case '\uFF5B': return '\uFF5D';
				case '\uFF5D': return '\uFF5B';
				case '\uFF5F': return '\uFF60';
				case '\uFF60': return '\uFF5F';
				case '\uFF62': return '\uFF63';
				case '\uFF63': return '\uFF62';
				default: return c;
			}
		}
	}
}

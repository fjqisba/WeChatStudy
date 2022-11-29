/*
 * BeaEngine 4 - x86 & x86-64 disassembler library
 *
 * Copyright 2006-2010, BeatriX
 * File coded by BeatriX
 *
 * This file is part of BeaEngine.
 *
 *    BeaEngine is free software: you can redistribute it and/or modify
 *    it under the terms of the GNU Lesser General Public License as published by
 *    the Free Software Foundation, either version 3 of the License, or
 *    (at your option) any later version.
 *
 *    BeaEngine is distributed in the hope that it will be useful,
 *    but WITHOUT ANY WARRANTY; without even the implied warranty of
 *    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *    GNU Lesser General Public License for more details.
 *
 *    You should have received a copy of the GNU Lesser General Public License
 *    along with BeaEngine.  If not, see <http://www.gnu.org/licenses/>. */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "BeaEngine.h"
#include "protos.h"
#include "internal_datas.h"
#include "instr_set/Data_opcode.h"
#include "instr_set/opcodes_A_M.c"
#include "instr_set/opcodes_N_Z.c"
#include "instr_set/opcodes_Grp1.c"
#include "instr_set/opcodes_Grp2.c"
#include "instr_set/opcodes_Grp3.c"
#include "instr_set/opcodes_Grp4.c"
#include "instr_set/opcodes_Grp5.c"
#include "instr_set/opcodes_Grp6.c"
#include "instr_set/opcodes_Grp7.c"
#include "instr_set/opcodes_Grp8.c"
#include "instr_set/opcodes_Grp9.c"
#include "instr_set/opcodes_Grp12.c"
#include "instr_set/opcodes_Grp13.c"
#include "instr_set/opcodes_Grp14.c"
#include "instr_set/opcodes_Grp15.c"
#include "instr_set/opcodes_Grp16.c"
#include "instr_set/opcodes_Grp17.c"
#include "instr_set/opcodes_FPU.c"
#include "instr_set/opcodes_MMX.c"
#include "instr_set/opcodes_SSE.c"
#include "instr_set/opcodes_AES.c"
#include "instr_set/opcodes_CLMUL.c"
#include "instr_set/opcodes_prefixes.c"
#include "Routines_ModRM.c"
#include "Routines_Disasm.c"
#include "BeaEngineVersion.c"

void BeaEngine(void){return;}

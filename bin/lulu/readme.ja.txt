
------------------------------------------------------------------
 LuLu 0.05
 http://lulu.luaforge.net/
                                                      2008/06/08
                                        hzkr <binhzkr@gmail.com>
                                     http://d.hatena.ne.jp/hzkr/
------------------------------------------------------------------


-- �g����

 > lua lulu.lua your_lua_program.lua



-- ����͂ȂɁH

 LuLu �� Lua ���g�Ŏ������ꂽ Lua 5.1 �� VM �ł��B

 ���܂̂Ƃ���ALuLu ���������Ă���̂́AVM�̖��ߗ�̉��߂ƃR���[�`���̏��������ł��B
 �f�[�^�^�i�������e�[�u���j��W�����C�u�����֐��̎����́A��{�I�Ƀz�X�g��Lua��
 �ۓ������Ă��܂��B

 Supported Features:
   - VM �̑S����
   - ���C�u�����֐��̑啔��
      - io.*         (forwarded to the host Lua)
      - file:*       (forwarded to the host Lua)
      - string.*     (forwarded to the host Lua, except string.dump)
      - math.*       (forwarded to the host Lua)
      - coroutine.*  (pure Lua implementation)

 Currently Unsupported Features:
   - ���^�e�[�u��
        (actually, all metamethods except __call should work under the metatable
         mechanism of the host Lua.)
   - �ȉ��̃��C�u�����֐�
      - dofile/load/loadfile/loadstring/string.dump
      - module/require/package.*
      - pcall/xpcall
      - debug.*


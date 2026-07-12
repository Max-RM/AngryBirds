using System.Collections.Generic;

internal class a1
{
	private static List<cw> m_a = new List<cw>();

	public static void m()
	{
		u.a().a("SPLASHES_SHEET_1.dat", A_1: true);
	}

	public static void l()
	{
		u.a().b("SPLASHES_SHEET_1.dat", global::h.d);
	}

	public static void k()
	{
		i();
		j();
		u.a().a("BUTTONS_SHEET_1.dat", A_1: false);
		u.a().a("LEVELSELECTION_SHEET_1.dat", A_1: true);
		u.a().a("MENU_BACKGROUNDS_1.dat", A_1: true);
		u.a().a("INGAME_BIRDS_1.dat", A_1: true);
		u.a().a("MENU_SHEET_1.dat", A_1: false);
		u.a().a("MENU_COMPRESSED.dat", A_1: true);
		u.a().a("MENU_UNCOMPRESSED.dat", A_1: true);
	}

	public static void j()
	{
		u.a().a("TUTORIALS_SHEET_1.dat", A_1: true);
	}

	public static void i()
	{
		u.a().a("GOLDEN_EGGS_COMBINED.dat", A_1: true);
	}

	public static void h()
	{
		u.a().a("CUTSCENE_COMBINED.dat", A_1: true);
		u.a().a("CUTSCENES_BACKGROUNDS_5.dat", A_1: true);
		u.a().a("CUTSCENES_BACKGROUNDS_6.dat", A_1: true);
	}

	public static void g()
	{
		u.a().a("INGAME_BIRDS_1.dat", A_1: true);
		u.a().a("INGAME_BLOCKS_1.dat", A_1: true);
	}

	public static void f()
	{
	}

	public static void b(a2 A_0)
	{
		if (A_0 != null)
		{
			for (int num = 0; num < A_0.c.Count; num++)
			{
				u.a().a(A_0.c[num].b + ".dat", A_1: false);
			}
			for (int num2 = 0; num2 < A_0.d.Count; num2++)
			{
				u.a().a(A_0.d[num2].b + ".dat", A_1: false);
			}
			int[] array = new int[17]
			{
				1, 2, 3, 4, 5, 6, 7, 8, 1, 2,
				3, 3, 4, 6, 7, 9, 1
			};
			int num3 = array[A_0.a - 1];
			string text = "INGAME_THEME_GROUND_" + num3;
			u.a().a(text + ".dat", A_1: true);
			if (A_0.a == 16)
			{
				u.a().a("INGAME_THEME_GROUND_3.dat", A_1: true);
			}
		}
	}

	public static void a(a2 A_0)
	{
		if (A_0 != null)
		{
			for (int num = 0; num < A_0.c.Count; num++)
			{
				u.a().b(A_0.c[num].b, global::h.d);
			}
			for (int num2 = 0; num2 < A_0.d.Count; num2++)
			{
				u.a().b(A_0.d[num2].b, global::h.d);
			}
			int[] array = new int[17]
			{
				1, 2, 3, 4, 5, 6, 7, 8, 1, 2,
				3, 3, 4, 6, 7, 9, 1
			};
			int num3 = array[A_0.a - 1];
			string a_ = "INGAME_THEME_GROUND_" + num3;
			u.a().b(a_, global::h.d);
			if (A_0.a == 16)
			{
				u.a().a("INGAME_THEME_GROUND_3.dat", A_1: true);
			}
		}
	}

	public static void e()
	{
		u.a().h("FONT_BASIC_WP7.dat");
		u.a().h("FONT_MENU_N900.dat");
		u.a().h("FONT_SCORE_N900.dat");
		u.a().h("FONT_BIG_NUMBERS_N900.dat");
		u.a().h("FONT_LS_SMALL_N900.dat");
		u.a().h("FONT_WP7_LIVE.dat");
	}

	public static void d()
	{
		u.a().b("bird 01 collision a1.wav", "bird 01 collision a1");
		u.a().b("bird 01 collision a2.wav", "bird 01 collision a2");
		u.a().b("bird 01 collision a3.wav", "bird 01 collision a3");
		u.a().b("bird 01 collision a4.wav", "bird 01 collision a4");
		u.a().b("bird 01 collision a1_low.wav", "bird 01 collision a1_low");
		u.a().b("bird 01 collision a2_low.wav", "bird 01 collision a2_low");
		u.a().b("bird 01 collision a3_low.wav", "bird 01 collision a3_low");
		u.a().b("bird 01 collision a4_low.wav", "bird 01 collision a4_low");
		u.a().b("bird 01 flying.wav", "bird_01_flying");
		u.a().b("bigbrother_fly.wav", "big_brother_flying");
		u.a().b("bigbrother_awakens.wav", "big_brother_awakens");
		u.a().b("bird 01 select.wav", "bird_01_select");
		u.a().b("bigbrother_select.wav", "big_brother_select");
		u.a().b("bird 02 collision a1.wav", "bird 02 collision a1");
		u.a().b("bird 02 collision a2.wav", "bird 02 collision a2");
		u.a().b("bird 02 collision a3.wav", "bird 02 collision a3");
		u.a().b("bird 02 collision a4.wav", "bird 02 collision a4");
		u.a().b("bird 02 collision a5.wav", "bird 02 collision a5");
		u.a().b("bird 02 flying.wav", "bird_02_flying");
		u.a().b("bird 02 select.wav", "bird_02_select");
		u.a().b("bird 03 collision a1.wav", "bird 03 collision a1");
		u.a().b("bird 03 collision a2.wav", "bird 03 collision a2");
		u.a().b("bird 03 collision a3.wav", "bird 03 collision a3");
		u.a().b("bird 03 collision a4.wav", "bird 03 collision a4");
		u.a().b("bird 03 collision a5.wav", "bird 03 collision a5");
		u.a().b("bird 03 flying.wav", "bird_03_flying");
		u.a().b("bird 03 select.wav", "bird_03_select");
		u.a().b("bird 04 flying.wav", "bird_04_flying");
		u.a().b("bird 04 select.wav", "bird_04_select");
		u.a().b("bird 04 collision a1.wav", "bird 04 collision a1");
		u.a().b("bird 04 collision a2.wav", "bird 04 collision a2");
		u.a().b("bird 04 collision a3.wav", "bird 04 collision a3");
		u.a().b("bird 04 collision a4.wav", "bird 04 collision a4");
		u.a().b("bird 05 collision a1.wav", "bird 05 collision a1");
		u.a().b("bird 05 collision a2.wav", "bird 05 collision a2");
		u.a().b("bird 05 collision a3.wav", "bird 05 collision a3");
		u.a().b("bird 05 collision a4.wav", "bird 05 collision a4");
		u.a().b("bird 05 collision a5.wav", "bird 05 collision a5");
		u.a().b("bird 05 flying.wav", "bird_05_flying");
		u.a().b("bird 05 select.wav", "bird_05_select");
		u.a().b("bird_06_flying.wav", "bird_06_flying");
		u.a().b("boomerang_select.wav", "boomerang_select");
		u.a().b("bird misc a1.wav", "bird_misc_a1");
		u.a().b("bird misc a2.wav", "bird_misc_a2");
		u.a().b("bird misc a3.wav", "bird_misc_a3");
		u.a().b("bird misc a4.wav", "bird_misc_a4");
		u.a().b("bird misc a5.wav", "bird_misc_a5");
		u.a().b("bird misc a6.wav", "bird_misc_a6");
		u.a().b("bird misc a7.wav", "bird_misc_a7");
		u.a().b("bird misc a8.wav", "bird_misc_a8");
		u.a().b("bird misc a9.wav", "bird_misc_a9");
		u.a().b("bird misc a10.wav", "bird_misc_a10");
		u.a().b("bird misc a11.wav", "bird_misc_a11");
		u.a().b("bird misc a12.wav", "bird_misc_a12");
		u.a().b("bird destroyed.wav", "bird_destroyed");
		u.a().b("bird next military a1.wav", "bird next military a1");
		u.a().b("bird next military a2.wav", "bird next military a2");
		u.a().b("bird next military a3.wav", "bird next military a3");
		u.a().b("bird shot-a1.wav", "bird shot a1");
		u.a().b("bird shot-a2.wav", "bird shot a2");
		u.a().b("bird shot-a3.wav", "bird shot a3");
		u.a().b("level clear military a1.mp3", "level clear military a1");
		u.a().b("level clear military a2.mp3", "level clear military a2");
		u.a().b("level failed piglets a1.mp3", "level failed piglets a1");
		u.a().b("level failed piglets a2.mp3", "level failed piglets a2");
		u.a().b("level start military a1.mp3", "level start military a1");
		u.a().b("level start military a2.mp3", "level start military a2");
		u.a().b("ice light collision a1.wav", "light collision a1");
		u.a().b("ice light collision a2.wav", "light collision a2");
		u.a().b("ice light collision a3.wav", "light collision a3");
		u.a().b("ice light collision a4.wav", "light collision a4");
		u.a().b("ice light collision a5.wav", "light collision a5");
		u.a().b("ice light collision a6.wav", "light collision a6");
		u.a().b("ice light collision a7.wav", "light collision a7");
		u.a().b("ice light collision a8.wav", "light collision a8");
		u.a().b("light damage a1.wav", "light damage a1");
		u.a().b("light damage a2.wav", "light damage a2");
		u.a().b("light damage a3.wav", "light damage a3");
		u.a().b("light destroyed a1.wav", "light destroyed a1");
		u.a().b("light destroyed a2.wav", "light destroyed a2");
		u.a().b("light destroyed a3.wav", "light destroyed a3");
		u.a().b("light rolling.wav", "light_rolling");
		u.a().b("menu back.wav", "menu_back");
		u.a().b("menu confirm.wav", "menu_confirm");
		u.a().b("menu select.wav", "menu_select");
		u.a().b("piglette collision a1.wav", "piglette collision a1");
		u.a().b("piglette collision a2.wav", "piglette collision a2");
		u.a().b("piglette collision a3.wav", "piglette collision a3");
		u.a().b("piglette collision a4.wav", "piglette collision a4");
		u.a().b("piglette collision a5.wav", "piglette collision a5");
		u.a().b("piglette collision a6.wav", "piglette collision a6");
		u.a().b("piglette collision a7.wav", "piglette collision a7");
		u.a().b("piglette collision a8.wav", "piglette collision a8");
		u.a().b("piglette damage a1.wav", "piglette damage a1");
		u.a().b("piglette damage a2.wav", "piglette damage a2");
		u.a().b("piglette damage a3.wav", "piglette damage a3");
		u.a().b("piglette damage a4.wav", "piglette damage a4");
		u.a().b("piglette damage a5.wav", "piglette damage a5");
		u.a().b("piglette damage a6.wav", "piglette damage a6");
		u.a().b("piglette damage a7.wav", "piglette damage a7");
		u.a().b("piglette damage a8.wav", "piglette damage a8");
		u.a().b("piglette destroyed.wav", "piglette_destroyed");
		u.a().b("rock collision a1.wav", "rock collision a1");
		u.a().b("rock collision a2.wav", "rock collision a2");
		u.a().b("rock collision a3.wav", "rock collision a3");
		u.a().b("rock collision a4.wav", "rock collision a4");
		u.a().b("rock collision a5.wav", "rock collision a5");
		u.a().b("rock damage a1.wav", "rock damage a1");
		u.a().b("rock damage a2.wav", "rock damage a2");
		u.a().b("rock damage a3.wav", "rock damage a3");
		u.a().b("rock destroyed a1.wav", "rock destroyed a1");
		u.a().b("rock destroyed a2.wav", "rock destroyed a2");
		u.a().b("rock destroyed a3.wav", "rock destroyed a3");
		u.a().b("rock rolling.wav", "rock_rolling");
		u.a().b("special boost.wav", "special_boost");
		u.a().b("special egg explosion.wav", "special_explosion");
		u.a().b("special group.wav", "special_egg");
		u.a().b("special egg.wav", "special_group");
		u.a().b("wood collision a1.wav", "wood collision a1");
		u.a().b("wood collision a2.wav", "wood collision a2");
		u.a().b("wood collision a3.wav", "wood collision a3");
		u.a().b("wood collision a4.wav", "wood collision a4");
		u.a().b("wood collision a5.wav", "wood collision a5");
		u.a().b("wood collision a6.wav", "wood collision a6");
		u.a().b("wood damage a1.wav", "wood damage a1");
		u.a().b("wood damage a2.wav", "wood damage a2");
		u.a().b("wood damage a3.wav", "wood damage a3");
		u.a().b("wood destroyed a1.wav", "wood destroyed a1");
		u.a().b("wood destroyed a2.wav", "wood destroyed a2");
		u.a().b("wood destroyed a3.wav", "wood destroyed a3");
		u.a().b("wood rolling.wav", "wood_rolling");
		u.a().b("balloon_pop.wav", "balloon_pop");
		u.a().b("bird pushing egg out.wav", "bird_pushing_egg_out");
		u.a().b("slingshot streched.wav", "slingshot_stretched");
		u.a().b("tnt box explodes.wav", "tnt_explodes");
		u.a().b("boomerang_swish.wav", "boomerang_swish");
		u.a().b("boomerang_activate.wav", "boomerang_activate");
		u.a().b("trampoline.wav", "trampoline");
		u.a().b("redbird_yell01.wav", "red_special_1");
		u.a().b("redbird_yell02.wav", "red_special_2");
		u.a().b("redbird_yell03.wav", "red_special_3");
		u.a().b("bigbrother_yell.wav", "big_brother_special_1");
		u.a().b("piglette oink a1.wav", "piglette_a1");
		u.a().b("piglette oink a2.wav", "piglette_a2");
		u.a().b("piglette oink a3.wav", "piglette_a3");
		u.a().b("piglette oink a4.wav", "piglette_a4");
		u.a().b("piglette oink a5.wav", "piglette_a5");
		u.a().b("piglette oink a8.wav", "piglette_a8");
		u.a().b("piglette oink a9.wav", "piglette_a9");
		u.a().b("piglette oink a10.wav", "piglette_a10");
		u.a().b("piglette oink a11.wav", "piglette_a11");
		u.a().b("piglette oink a12.wav", "piglette_a12");
		u.a().b("star_collect.wav", "star_collect");
		u.a().b("button_radio.wav", "button_radio");
		u.a().b("goldenegg.wav", "goldenegg");
		u.a().b("piano-c.wav", "noteC");
		u.a().b("piano-cis.wav", "noteCis");
		u.a().b("piano-d.wav", "noteD");
		u.a().b("piano-dis.wav", "notedis");
		u.a().b("piano-e.wav", "noteE");
		u.a().b("piano-f.wav", "noteF");
		u.a().b("piano-fis.wav", "noteFis");
		u.a().b("piano-g.wav", "noteG");
		u.a().b("piglette oink story.wav", "piglette_oink_story");
		u.a().b("ball_bounce.wav", "ball_bounce");
		u.a().b("pig_bd.wav", "pig_bd");
		u.a().b("pig_snare_1.wav", "pig_snare_1");
		u.a().b("pig_snare_2.wav", "pig_snare_2");
		u.a().b("pig_snare_3.wav", "pig_snare_3");
		u.a().b("pig_snare_4.wav", "pig_snare_4");
		u.a().b("pig_hi-hat_1.wav", "pig_hi-hat_1");
		u.a().b("pig_hi-hat_2.wav", "pig_hi-hat_2");
		u.a().b("cminor_left.wav", "cminor_left");
		u.a().b("dismajor_left.wav", "dismajor_left");
		u.a().b("fmajor_left.wav", "fmajor_left");
		u.a().b("gminor_left.wav", "gminor_left");
		u.a().b("bmajor_left.wav", "bmajor_left");
		u.a().b("cminor_right.wav", "cminor_right");
		u.a().b("dismajor_right.wav", "dismajor_right");
		u.a().b("fmajor_right.wav", "fmajor_right");
		u.a().b("gminor_right.wav", "gminor_right");
		u.a().b("bmajor_right.wav", "bmajor_right");
		u.a().b("accordion_empty_pull.wav", "empty_accordion_left");
		u.a().b("accordion_empty_push.wav", "empty_accordion_right");
		u.a().b("accordion_break.wav", "accordion_break");
		u.a().b("pig_singing_1.wav", "pig_singing_1");
		u.a().b("pig_singing_2.wav", "pig_singing_2");
		u.a().b("pig_singing_3.wav", "pig_singing_3");
		u.a().b("pig_singing_4.wav", "pig_singing_4");
		u.a().b("pig_singing_5.wav", "pig_singing_5");
		u.a().b("pig_singing_6.wav", "pig_singing_6");
		u.a().b("pig_singing_7.wav", "pig_singing_7");
		u.a().b("pig_singing_8.wav", "pig_singing_8");
	}

	public static void c()
	{
		u.a().a("title_theme.mp3", "title_theme");
		u.a().a("funky_theme.mp3", "funky_theme");
		u.a().b("birds_outro.mp3", "birds_outro");
		u.a().b("birds_intro.mp3", "birds_intro");
		u.a().b("birds_boss.mp3", "birds_boss");
		u.a().a("ambient_white_dryforest.mp3", "ambient_theme1");
		u.a().a("ambient_green_jungleish.mp3", "ambient_theme2");
		u.a().a("ambient_red_savannah.mp3", "ambient_theme3");
	}

	public static void a(string A_0)
	{
		a1.m_a.Add(u.a().a("level_complete.mp3", "level_complete"));
		a1.m_a.Add(u.a().a("game_complete.mp3", "game_complete"));
		switch (A_0)
		{
		case "ambient_theme1":
			a1.m_a.Add(u.a().a("ambient_white_dryforest.mp3", "ambient_theme1"));
			break;
		case "ambient_theme2":
			a1.m_a.Add(u.a().a("ambient_green_jungleish.mp3", "ambient_theme2"));
			break;
		case "ambient_theme3":
			a1.m_a.Add(u.a().a("ambient_red_savannah.mp3", "ambient_theme3"));
			break;
		case "ambient_theme7":
			a1.m_a.Add(u.a().a("ambient_city.mp3", "ambient_theme7"));
			break;
		case "construction_theme1":
			a1.m_a.Add(u.a().a("ambient_construction.mp3", "construction_theme1"));
			break;
		}
	}

	public static void b()
	{
		foreach (cw item in a1.m_a)
		{
			u.a().a(item);
		}
		a1.m_a.Clear();
	}

	public static void a()
	{
		u.a().k("TEXTS_BASIC.dat");
	}
}

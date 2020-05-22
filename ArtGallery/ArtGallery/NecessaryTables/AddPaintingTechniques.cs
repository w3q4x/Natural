﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.NecessaryTables
{
    class AddPaintingTechniques
    {
        public static void Fill()
        {
            using (GalleryContext galleryContext = new GalleryContext())
            {
                if (!galleryContext.PaintingTechniques.Any())
                {
                    PaintingTechnique pt1 = new PaintingTechnique
                    {
                        Name = "Лессировка",
                        Description = "Это техника рисования краской тонким слоем сразу по основе или по просушенному слою краски. Характерна только для прозрачных красок - масла, акварели, иногда акрила. Основное качество лессировки - прозрачность. Нанесённый поверх предыдущего слоя краски слой лессировки как бы глазирует поверхность картины, придаёт особую выразительность и глубину слоям краски, лежащим под лессировкой. В сочетании с плотными укрывистыми слоями краски в картине маслом лессировка создаёт иллюзию глубины и прозрачности, благодаря ей появляется объёмная живопись."
                    };
                    PaintingTechnique pt2 = new PaintingTechnique
                    {
                        Name = "Мазковая техника живописи",
                        Description = "Среди техник живописи мазковая выделяется особо. Это такой способ живописи, когда краска смешивается на палитре и наносится на холст отдельными мазками - каждый мазок на своё место. Таким образом, объём и форма в живописи вылепливаются наложенными на холст мазками нужного цвета, тона, размера. Фактурная живопись, демонстрирующая множество мазков разного качества и рельефа, рассматривается на расстоянии, таким образом отдельные мазки краски сливаются в единое целое изображение и придают картине реалистичность, живость, динамичность. Мазковая техника живописи учит художника точно намешивать нужные оттенки и класть их в нужное место, поэтому она используется при обучении художников чаще всего."
                    };
                    galleryContext.PaintingTechniques.AddRange(new List<PaintingTechnique> { pt1, pt2 });
                    galleryContext.SaveChanges();
                }
            }
        }
    }
}
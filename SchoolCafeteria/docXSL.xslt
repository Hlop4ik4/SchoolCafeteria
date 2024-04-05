<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<w:document
			xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas"
			xmlns:cx="http://schemas.microsoft.com/office/drawing/2014/chartex"
			xmlns:cx1="http://schemas.microsoft.com/office/drawing/2015/9/8/chartex"
			xmlns:cx2="http://schemas.microsoft.com/office/drawing/2015/10/21/chartex"
			xmlns:cx3="http://schemas.microsoft.com/office/drawing/2016/5/9/chartex"
			xmlns:cx4="http://schemas.microsoft.com/office/drawing/2016/5/10/chartex"
			xmlns:cx5="http://schemas.microsoft.com/office/drawing/2016/5/11/chartex"
			xmlns:cx6="http://schemas.microsoft.com/office/drawing/2016/5/12/chartex"
			xmlns:cx7="http://schemas.microsoft.com/office/drawing/2016/5/13/chartex"
			xmlns:cx8="http://schemas.microsoft.com/office/drawing/2016/5/14/chartex"
			xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
			xmlns:aink="http://schemas.microsoft.com/office/drawing/2016/ink"
			xmlns:am3d="http://schemas.microsoft.com/office/drawing/2017/model3d"
			xmlns:o="urn:schemas-microsoft-com:office:office"
			xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships"
			xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math"
			xmlns:v="urn:schemas-microsoft-com:vml"
			xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing"
			xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing"
			xmlns:w10="urn:schemas-microsoft-com:office:word"
			xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main"
			xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml"
			xmlns:w15="http://schemas.microsoft.com/office/word/2012/wordml"
			xmlns:w16cex="http://schemas.microsoft.com/office/word/2018/wordml/cex"
			xmlns:w16cid="http://schemas.microsoft.com/office/word/2016/wordml/cid"
			xmlns:w16="http://schemas.microsoft.com/office/word/2018/wordml"
			xmlns:w16sdtdh="http://schemas.microsoft.com/office/word/2020/wordml/sdtdatahash"
			xmlns:w16se="http://schemas.microsoft.com/office/word/2015/wordml/symex"
			xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup"
			xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk"
			xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml"
			xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape" mc:Ignorable="w14 w15 w16se w16cid w16 w16cex w16sdtdh wp14">
			<w:body>
				<w:p w14:paraId="7C81162E" w14:textId="6AFEA173" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:jc w:val="center"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:b/>
							<w:bCs/>
							<w:sz w:val="28"/>
							<w:szCs w:val="28"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:b/>
							<w:bCs/>
							<w:sz w:val="28"/>
							<w:szCs w:val="28"/>
						</w:rPr>
						<w:t>
							Технологическая карта кулинарного изделия (блюда) № <xsl:value-of select="//TechMap/Id"/>
						</w:t>
					</w:r>
				</w:p>
				<w:p w14:paraId="4584B95B" w14:textId="42EA3040" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>Наименование кулинарного изделия (блюда): <xsl:value-of select="//TechMap/DishName"/></w:t>
					</w:r>
				</w:p>
				<w:p w14:paraId="2D49D1CE" w14:textId="1649AC58" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>Номер рецептуры: <xsl:value-of select="//TechMap/RecipeNumber"/></w:t>
					</w:r>
				</w:p>
				<w:tbl>
					<w:tblPr>
						<w:tblStyle w:val="a3"/>
						<w:tblW w:w="0" w:type="auto"/>
						<w:tblLook w:val="04A0" w:firstRow="1" w:lastRow="0" w:firstColumn="1" w:lastColumn="0" w:noHBand="0" w:noVBand="1"/>
					</w:tblPr>
					<w:tblGrid>
						<w:gridCol w:w="2922"/>
						<w:gridCol w:w="1326"/>
						<w:gridCol w:w="1467"/>
						<w:gridCol w:w="1817"/>
						<w:gridCol w:w="1813"/>
					</w:tblGrid>
					<w:tr w:rsidR="00D26BE5" w14:paraId="3B984DFE" w14:textId="77777777" w:rsidTr="00D26BE5">
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="2922" w:type="dxa"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="5DB845E4" w14:textId="352DA722" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Наименование сырья</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="6423" w:type="dxa"/>
								<w:gridSpan w:val="4"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="430F435E" w14:textId="3028B86E" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Расход сырья и полуфабрикатов</w:t>
								</w:r>
							</w:p>
						</w:tc>
					</w:tr>
					<w:tr w:rsidR="00D26BE5" w14:paraId="4D17E250" w14:textId="77777777" w:rsidTr="00D26BE5">
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="2922" w:type="dxa"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="5CF4ED87" w14:textId="77777777" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="2793" w:type="dxa"/>
								<w:gridSpan w:val="2"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="01A5C673" w14:textId="2DAF7D48" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>1 порция</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="3630" w:type="dxa"/>
								<w:gridSpan w:val="2"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="4F1754AA" w14:textId="1704E32B" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>100 порций</w:t>
								</w:r>
							</w:p>
						</w:tc>
					</w:tr>
					<w:tr w:rsidR="00D26BE5" w14:paraId="4167BC59" w14:textId="77777777" w:rsidTr="00D26BE5">
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="2922" w:type="dxa"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="2851E7C3" w14:textId="77777777" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="1326" w:type="dxa"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="6934EF5E" w14:textId="2566796B" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Брутто, г</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="1467" w:type="dxa"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="2ECFC696" w14:textId="25601CB4" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Нетто, г</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="1817" w:type="dxa"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="74022F5F" w14:textId="3259FF5B" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Брутто, г</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="1813" w:type="dxa"/>
								<w:vAlign w:val="center"/>
							</w:tcPr>
							<w:p w14:paraId="12E04946" w14:textId="03AB8E81" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:jc w:val="center"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Нетто, г</w:t>
								</w:r>
							</w:p>
						</w:tc>
					</w:tr>
					<xsl:for-each select="//TechMap/TechMapGoods/Goods">
						<w:tr w:rsidR="00D26BE5" w14:paraId="0D40D930" w14:textId="77777777" w:rsidTr="00D26BE5">
							<w:tc>
								<w:tcPr>
									<w:tcW w:w="2922" w:type="dxa"/>
									<w:vAlign w:val="center"/>
								</w:tcPr>
								<w:p w14:paraId="43B18BD5" w14:textId="7FB8A15B" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
									<w:pPr>
										<w:jc w:val="center"/>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
									</w:pPr>
									<w:r>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
										<w:t><xsl:value-of select="Name"/></w:t>
									</w:r>
								</w:p>
							</w:tc>
							<w:tc>
								<w:tcPr>
									<w:tcW w:w="1326" w:type="dxa"/>
									<w:vAlign w:val="center"/>
								</w:tcPr>
								<w:p w14:paraId="0D4E3AA1" w14:textId="1D0604E2" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
									<w:pPr>
										<w:jc w:val="center"/>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
									</w:pPr>
									<w:r>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
										<w:t><xsl:value-of select="Brutto"/></w:t>
									</w:r>
								</w:p>
							</w:tc>
							<w:tc>
								<w:tcPr>
									<w:tcW w:w="1467" w:type="dxa"/>
									<w:vAlign w:val="center"/>
								</w:tcPr>
								<w:p w14:paraId="0D2BFA93" w14:textId="1DFB5104" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
									<w:pPr>
										<w:jc w:val="center"/>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
									</w:pPr>
									<w:r>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
										<w:t><xsl:value-of select="Netto"/></w:t>
									</w:r>
								</w:p>
							</w:tc>
							<w:tc>
								<w:tcPr>
									<w:tcW w:w="1817" w:type="dxa"/>
									<w:vAlign w:val="center"/>
								</w:tcPr>
								<w:p w14:paraId="6B3882D6" w14:textId="46E1516F" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
									<w:pPr>
										<w:jc w:val="center"/>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
									</w:pPr>
									<w:r>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
										<w:t><xsl:value-of select="Brutto100"/></w:t>
									</w:r>
								</w:p>
							</w:tc>
							<w:tc>
								<w:tcPr>
									<w:tcW w:w="1813" w:type="dxa"/>
									<w:vAlign w:val="center"/>
								</w:tcPr>
								<w:p w14:paraId="720036BD" w14:textId="12CFB435" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
									<w:pPr>
										<w:jc w:val="center"/>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
									</w:pPr>
									<w:r>
										<w:rPr>
											<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
											<w:sz w:val="24"/>
											<w:szCs w:val="24"/>
										</w:rPr>
										<w:t><xsl:value-of select="Netto100"/></w:t>
									</w:r>
								</w:p>
							</w:tc>
						</w:tr>
					</xsl:for-each>
				</w:tbl>
				<w:p w14:paraId="3E65B36E" w14:textId="0FF4912B" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:spacing w:before="240" w:after="0"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>Химический состав, витамины и микроэлементы на 1 порцию</w:t>
					</w:r>
				</w:p>
				<w:tbl>
					<w:tblPr>
						<w:tblStyle w:val="a3"/>
						<w:tblW w:w="0" w:type="auto"/>
						<w:tblLook w:val="04A0" w:firstRow="1" w:lastRow="0" w:firstColumn="1" w:lastColumn="0" w:noHBand="0" w:noVBand="1"/>
					</w:tblPr>
					<w:tblGrid>
						<w:gridCol w:w="849"/>
						<w:gridCol w:w="849"/>
						<w:gridCol w:w="849"/>
						<w:gridCol w:w="849"/>
						<w:gridCol w:w="849"/>
						<w:gridCol w:w="850"/>
						<w:gridCol w:w="850"/>
						<w:gridCol w:w="850"/>
						<w:gridCol w:w="850"/>
						<w:gridCol w:w="850"/>
						<w:gridCol w:w="850"/>
					</w:tblGrid>
					<w:tr w:rsidR="00D26BE5" w14:paraId="0A6851FD" w14:textId="5B7028DD" w:rsidTr="00D26BE5">
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="27679EE5" w14:textId="04B73AF0" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Б</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="4D4783D8" w14:textId="045CBD1E" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>Ж</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="4B99C857" w14:textId="74CFD6A7" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t>У</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="65A78765" w14:textId="07FB71DF" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>B1</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="67022D11" w14:textId="544C25B8" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>C</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="5987DD49" w14:textId="084FED0A" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>A</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="4C4119E0" w14:textId="7D453DB8" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>E</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="788A96D7" w14:textId="7A828FFF" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>Ca</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="77C9A898" w14:textId="4B5C2D1D" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>P</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="0E55BE0B" w14:textId="4705EE93" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>Mg</w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="78DC8F68" w14:textId="5D0C7A18" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t>Fe</w:t>
								</w:r>
							</w:p>
						</w:tc>
					</w:tr>
					<w:tr w:rsidR="00D26BE5" w14:paraId="1FCFDF53" w14:textId="77777777" w:rsidTr="00D26BE5">
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="47BB5696" w14:textId="01242893" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/Protein"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="78F5A28D" w14:textId="26435062" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/Fat"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="0269EC85" w14:textId="6B0B7CF2" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/Carb"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="34A35002" w14:textId="32BDC448" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/B1"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="849" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="78411E37" w14:textId="780F510F" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/C"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="75310B61" w14:textId="6887579F" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/A"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="758E7B8D" w14:textId="509162A4" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/E"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="7626BF0A" w14:textId="71416021" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/Ca"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="477BD559" w14:textId="19FD9299" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/P"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="74B494C4" w14:textId="1E0E71D4" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/Mg"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="850" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="4EBC1073" w14:textId="79090F59" w:rsidR="00D26BE5" w:rsidRPr="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
										<w:lang w:val="en-US"/>
									</w:rPr>
									<w:t><xsl:value-of select="//TechMap/Composition/Fe"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
					</w:tr>
				</w:tbl>
				<w:p w14:paraId="3471D518" w14:textId="7542E80F" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:spacing w:before="240" w:after="0"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>Технология приготовления: с указанием процессов приготовления и технологических режимов</w:t>
					</w:r>
				</w:p>
				<w:tbl>
					<w:tblPr>
						<w:tblStyle w:val="a3"/>
						<w:tblW w:w="0" w:type="auto"/>
						<w:tblLook w:val="04A0" w:firstRow="1" w:lastRow="0" w:firstColumn="1" w:lastColumn="0" w:noHBand="0" w:noVBand="1"/>
					</w:tblPr>
					<w:tblGrid>
						<w:gridCol w:w="9345"/>
					</w:tblGrid>
					<w:tr w:rsidR="00D26BE5" w14:paraId="23D7E3F2" w14:textId="77777777" w:rsidTr="00D26BE5">
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="9345" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="0E9FCF14" w14:textId="3C1BC530" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t xml:space="preserve"><xsl:value-of select="//TechMap/CookingTechnology"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
					</w:tr>
				</w:tbl>
				<w:p w14:paraId="22CD7020" w14:textId="10688A39" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:spacing w:before="240" w:after="0"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>Описание качества блюда</w:t>
					</w:r>
				</w:p>
				<w:tbl>
					<w:tblPr>
						<w:tblStyle w:val="a3"/>
						<w:tblW w:w="0" w:type="auto"/>
						<w:tblLook w:val="04A0" w:firstRow="1" w:lastRow="0" w:firstColumn="1" w:lastColumn="0" w:noHBand="0" w:noVBand="1"/>
					</w:tblPr>
					<w:tblGrid>
						<w:gridCol w:w="9345"/>
					</w:tblGrid>
					<w:tr w:rsidR="00D26BE5" w14:paraId="2A86D52F" w14:textId="77777777" w:rsidTr="00D26BE5">
						<w:tc>
							<w:tcPr>
								<w:tcW w:w="9345" w:type="dxa"/>
							</w:tcPr>
							<w:p w14:paraId="0F82DDE2" w14:textId="01A9D4FF" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
								<w:pPr>
									<w:spacing w:before="240"/>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
								</w:pPr>
								<w:r>
									<w:rPr>
										<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
										<w:sz w:val="24"/>
										<w:szCs w:val="24"/>
									</w:rPr>
									<w:t xml:space="preserve"><xsl:value-of select="//TechMap/Description"/></w:t>
								</w:r>
							</w:p>
						</w:tc>
					</w:tr>
				</w:tbl>
				<w:p w14:paraId="158B60A3" w14:textId="75B91959" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:spacing w:before="240"/>
						<w:jc w:val="center"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:proofErr w:type="spellStart"/>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>Утвержденно</w:t>
					</w:r>
					<w:proofErr w:type="spellEnd"/>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t xml:space="preserve">: ______________________________ </w:t>
					</w:r>
					<w:proofErr w:type="spellStart"/>
					<w:r w:rsidR="00E008B0">
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>Долгоновский</w:t>
					</w:r>
					<w:proofErr w:type="spellEnd"/>
					<w:r w:rsidR="00E008B0">
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t xml:space="preserve"> Ю.М</w:t>
					</w:r>
				</w:p>
				<w:p w14:paraId="758ED942" w14:textId="05DDD1E7" w:rsidR="00D26BE5" w:rsidRDefault="00D26BE5" w:rsidP="00D26BE5">
					<w:pPr>
						<w:jc w:val="center"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:tab/>
					</w:r>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:tab/>
					</w:r>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:tab/>
					</w:r>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:tab/>
					</w:r>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:tab/>
					</w:r>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:tab/>
					</w:r>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:tab/>
						<w:t>Директор</w:t>
					</w:r>
				</w:p>
				<w:p w14:paraId="29CA393A" w14:textId="5E76692B" w:rsidR="00D26BE5" w:rsidRDefault="00E008B0" w:rsidP="00D26BE5">
					<w:pPr>
						<w:jc w:val="right"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
					<w:r>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
						<w:t>МОУ СОШ с. Выползово <xsl:value-of select="//TechMap/CreateDt"/></w:t>
					</w:r>
				</w:p>
				<w:p w14:paraId="7FAD928D" w14:textId="77777777" w:rsidR="00E008B0" w:rsidRPr="00D26BE5" w:rsidRDefault="00E008B0" w:rsidP="00D26BE5">
					<w:pPr>
						<w:jc w:val="right"/>
						<w:rPr>
							<w:rFonts w:ascii="Times New Roman" w:hAnsi="Times New Roman" w:cs="Times New Roman"/>
							<w:sz w:val="24"/>
							<w:szCs w:val="24"/>
						</w:rPr>
					</w:pPr>
				</w:p>
				<w:sectPr w:rsidR="00E008B0" w:rsidRPr="00D26BE5">
					<w:pgSz w:w="11906" w:h="16838"/>
					<w:pgMar w:top="1134" w:right="850" w:bottom="1134" w:left="1701" w:header="708" w:footer="708" w:gutter="0"/>
					<w:cols w:space="708"/>
					<w:docGrid w:linePitch="360"/>
				</w:sectPr>
			</w:body>
		</w:document>
	</xsl:template>
</xsl:stylesheet>

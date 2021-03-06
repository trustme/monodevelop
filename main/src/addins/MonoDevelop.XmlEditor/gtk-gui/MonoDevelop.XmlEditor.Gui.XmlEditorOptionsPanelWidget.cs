
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.XmlEditor.Gui
{
	public partial class XmlEditorOptionsPanelWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.CheckButton autoCompleteElementsCheck;
		private global::Gtk.CheckButton autoAddPunctuationCheck;
		private global::Gtk.CheckButton showSchemaAnnotationCheck;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.XmlEditor.Gui.XmlEditorOptionsPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.XmlEditor.Gui.XmlEditorOptionsPanelWidget";
			// Container child MonoDevelop.XmlEditor.Gui.XmlEditorOptionsPanelWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.autoCompleteElementsCheck = new global::Gtk.CheckButton ();
			this.autoCompleteElementsCheck.CanFocus = true;
			this.autoCompleteElementsCheck.Name = "autoCompleteElementsCheck";
			this.autoCompleteElementsCheck.Label = global::Mono.Unix.Catalog.GetString ("Automatically insert closing tags");
			this.autoCompleteElementsCheck.DrawIndicator = true;
			this.autoCompleteElementsCheck.UseUnderline = true;
			this.vbox1.Add (this.autoCompleteElementsCheck);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.autoCompleteElementsCheck]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.autoAddPunctuationCheck = new global::Gtk.CheckButton ();
			this.autoAddPunctuationCheck.CanFocus = true;
			this.autoAddPunctuationCheck.Name = "autoAddPunctuationCheck";
			this.autoAddPunctuationCheck.Label = global::Mono.Unix.Catalog.GetString ("Automatically insert punctuation (=\"\", />, etc.)");
			this.autoAddPunctuationCheck.Active = true;
			this.autoAddPunctuationCheck.DrawIndicator = true;
			this.autoAddPunctuationCheck.UseUnderline = true;
			this.vbox1.Add (this.autoAddPunctuationCheck);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.autoAddPunctuationCheck]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.showSchemaAnnotationCheck = new global::Gtk.CheckButton ();
			this.showSchemaAnnotationCheck.Sensitive = false;
			this.showSchemaAnnotationCheck.CanFocus = true;
			this.showSchemaAnnotationCheck.Name = "showSchemaAnnotationCheck";
			this.showSchemaAnnotationCheck.Label = global::Mono.Unix.Catalog.GetString ("Show schema annotation");
			this.showSchemaAnnotationCheck.DrawIndicator = true;
			this.showSchemaAnnotationCheck.UseUnderline = true;
			this.vbox1.Add (this.showSchemaAnnotationCheck);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.showSchemaAnnotationCheck]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}

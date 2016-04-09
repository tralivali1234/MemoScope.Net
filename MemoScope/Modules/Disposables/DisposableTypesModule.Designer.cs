﻿namespace MemoScope.Modules.Disposables
{
    partial class DisposableTypesModule
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dlvDisposableTypes = new WinFwk.UITools.DefaultListView();
            this.regexFilterControl = new MemoScope.Tools.RegexFilter.RegexFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.dlvDisposableTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dlvDelegates
            // 
            this.dlvDisposableTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlvDisposableTypes.CellEditUseWholeCell = false;
            this.dlvDisposableTypes.FullRowSelect = true;
            this.dlvDisposableTypes.HideSelection = false;
            this.dlvDisposableTypes.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.dlvDisposableTypes.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.dlvDisposableTypes.Location = new System.Drawing.Point(0, 33);
            this.dlvDisposableTypes.Name = "dlvDelegates";
            this.dlvDisposableTypes.ShowGroups = false;
            this.dlvDisposableTypes.ShowImagesOnSubItems = true;
            this.dlvDisposableTypes.Size = new System.Drawing.Size(762, 450);
            this.dlvDisposableTypes.TabIndex = 0;
            this.dlvDisposableTypes.UseCompatibleStateImageBehavior = false;
            this.dlvDisposableTypes.View = System.Windows.Forms.View.Details;
            this.dlvDisposableTypes.VirtualMode = true;
            this.dlvDisposableTypes.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.dlvDelegates_CellClick);
            // 
            // regexFilterControl
            // 
            this.regexFilterControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regexFilterControl.Location = new System.Drawing.Point(0, 3);
            this.regexFilterControl.Name = "regexFilterControl";
            this.regexFilterControl.Size = new System.Drawing.Size(759, 24);
            this.regexFilterControl.TabIndex = 1;
            // 
            // DelegateModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.regexFilterControl);
            this.Controls.Add(this.dlvDisposableTypes);
            this.Name = "DelegateModule";
            this.Size = new System.Drawing.Size(762, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dlvDisposableTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFwk.UITools.DefaultListView dlvDisposableTypes;
        private Tools.RegexFilter.RegexFilterControl regexFilterControl;
    }
}
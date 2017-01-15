# GroupProject2try
            {
                //fill list with database orders and populate combobox with the value
                packages = PackagesDB.GetPackages();
                cboPackageId.DataSource = packages;
                cboPackageId.DisplayMember = "PackageId";
                cboPackageId.ValueMember = "PackageId";
            }
            //catch any database exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

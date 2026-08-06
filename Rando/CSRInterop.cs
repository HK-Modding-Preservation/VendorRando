using ConnectionSettingsRando;

namespace VendorRando {
    internal class CSRInterop {
        public static void Hook() {
            CSR.Register(
                VendorRando.instance.GetName(),
                () => VendorRando.globalSettings,
                s => SettingsRandomizer.CopyTo(s, VendorRando.globalSettings)
            );
        }
    }
}

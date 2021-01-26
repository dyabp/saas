import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { SaasComponent } from './components/saas.component';
import { SaasRoutingModule } from './saas-routing.module';

@NgModule({
  declarations: [SaasComponent],
  imports: [CoreModule, ThemeSharedModule, SaasRoutingModule],
  exports: [SaasComponent],
})
export class SaasModule {
  static forChild(): ModuleWithProviders<SaasModule> {
    return {
      ngModule: SaasModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<SaasModule> {
    return new LazyModuleFactory(SaasModule.forChild());
  }
}

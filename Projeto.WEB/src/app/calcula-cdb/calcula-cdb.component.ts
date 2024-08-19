import { Component } from '@angular/core';
import { LOCALE_ID } from '@angular/core';
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';

registerLocaleData(localePt);

@Component({
  selector: 'app-calcula-cdb',
  templateUrl: './calcula-cdb.component.html',
  styleUrls: ['./calcula-cdb.component.scss'],
  providers: [{ provide: LOCALE_ID, useValue: 'pt-BR' }],
})
export class CalculaCdbComponent {
  valorInicial: number | any = null;
  meses: number | null = null;

  onValorInicialChange(event: any) {
    const sanitized = event.target.value.replace(/\D/g, '');
    const numericValue = parseInt(sanitized, 10);

    let formattedValue = (numericValue / 100).toFixed(2);
    formattedValue = formattedValue.replace('.', ',');
    formattedValue = formattedValue.replace(/\B(?=(\d{3})+(?!\d))/g, '.');

    this.valorInicial = formattedValue;
    event.target.value = this.valorInicial;
    console.log(this.valorInicial);
  }

  onCalculate() {
    if (this.meses === null || this.meses < 1 || this.meses > 60) {
      alert('Os meses devem estar entre 1 e 60.');
      return;
    }

    if (this.valorInicial !== null && this.meses !== null) {
      console.log('Calculando com:', this.valorInicial, this.meses);
    } else {
      console.error('Preencha os campos corretamente');
    }
  }
}

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculaCdbComponent } from './calcula-cdb.component';

describe('CalculaCdbComponent', () => {
  let component: CalculaCdbComponent;
  let fixture: ComponentFixture<CalculaCdbComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CalculaCdbComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CalculaCdbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

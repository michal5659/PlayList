import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrConfirmComponent } from './registr-confirm.component';

describe('RegistrConfirmComponent', () => {
  let component: RegistrConfirmComponent;
  let fixture: ComponentFixture<RegistrConfirmComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegistrConfirmComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistrConfirmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

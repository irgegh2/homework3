using UnityEngine;

namespace DefaultNamespace
{
	
	[RequireComponent(typeof(PositionSaver))]
	public class EditorMover : MonoBehaviour
	{
		private PositionSaver _save;
		private float _currentDelay;
		
		//todo comment: Что произойдёт, если _delay > _duration?
		// Если _delay > _duration, то за время _duration не успеет пройти ни одного цикла сохранения позиции и Records останется пустым.
		[Range(0.2f, 1.0f)]
		private float _delay = 0.5f;
		[Min(0.2f)]
		private float _duration = 5f;

		private void Start()
		{
			//todo comment: Почему этот поиск производится здесь, а не в начале метода Update?
			// Поиск производится в Start, а не в Update, для оптимизации - GetComponent вызывается только один раз, а не каждый кадр
			_save = GetComponent<PositionSaver>();
			_save.Records.Clear();
			
			if (_duration <= _delay)
			{
				_duration = _delay * 5f;
				Debug.LogWarning($"Duration ({_duration}) was less than or equal to delay ({_delay}). Setting duration to {_duration}");
			}
		}

		private void Update()
		{
			_duration -= Time.deltaTime;
			if (_duration <= 0f)
			{
				enabled = false;
				Debug.Log($"<b>{name}</b> finished", this);
				return;
			}
			
			//todo comment: Почему не написать (_delay -= Time.deltaTime;) по аналогии с полем _duration?
			// Нельзя изменять _delay напрямую, потому что это значение интервала между сохранениями, которое должно оставаться постоянным. _currentDelay - это счетчик времени до следующего сохранения
			_currentDelay -= Time.deltaTime;
			if (_currentDelay <= 0f)
			{
				_currentDelay = _delay;
				_save.Records.Add(new PositionSaver.Data
				{
					Position = transform.position,
					//todo comment: Для чего сохраняется значение игрового времени?
					// Игровое время сохраняется для синхронизации воспроизведения - чтобы ReplayMover мог точно воспроизвести движение с теми же временными интервалами.
					Time = Time.time,
				});
			}
		}
	}
}

